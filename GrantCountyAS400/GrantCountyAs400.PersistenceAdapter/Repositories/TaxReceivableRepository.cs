using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class TaxReceivableRepository : ITaxReceivableRepository
    {
        private readonly GrantCountyDbContext _context;

        public TaxReceivableRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<TaxReceivable> GetAll(
            decimal parcelNumber,
            out int resultCount,
            int pageNumber = 1,
            int pageSize = 50)
        {
            List<TaxReceivable> results = new List<TaxReceivable>();

            var query = (from treasurerProperty in _context.TreasPropertyMasterInfoView
                         where ((parcelNumber <= 0) || treasurerProperty.ParcelNumber == parcelNumber)
                         select TaxReceivableMapper.Map(treasurerProperty));

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.TaxpayerName)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.TaxpayerName)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public TaxReceivableDetails Details(int id)
        {
            var taxReceivable = _context.TreasPropertyMasterInfoView.FirstOrDefault(x => x.Id == id);
            if (taxReceivable != null)
            {
                decimal parcelNumber = taxReceivable.ParcelNumber.Value;
                var propertyTaxReceivables = GetPropertyTaxReceivables(parcelNumber);
                TaxReceivableDetails taxReceivableDetails = TaxReceivableMapper.Map(taxReceivable, propertyTaxReceivables);

                return taxReceivableDetails;
            }

            return null;
        }

        private IEnumerable<PropertyTaxReceivable> GetPropertyTaxReceivables(decimal parcelNumber)
        {
            List<PropertyTaxReceivable> result = new List<PropertyTaxReceivable>();
            var propTaxReceivablesRecords = _context.TreasallPropertyTaxReceivableMaster
                                                    .Where(x => x.ParcelNumber == parcelNumber)
                                                    .OrderByDescending(x => x.TaxYear)
                                                    .ToList();

            var targetYears = propTaxReceivablesRecords.Select(x => x.TaxYear.Value);
            var specialAssessmentTaxReceivableRecords = _context.TreasspecialAssessmentsTaxReceivableMaster
                                                                .Where(x => x.ParcelNumber == parcelNumber && targetYears.Contains(x.TaxYear.Value))
                                                                .ToList();

            var propertyTransactions = GetPropertyTaxReceivableTransactions(targetYears, parcelNumber);
            foreach (var propertyTaxReceivable in propTaxReceivablesRecords)
            {
                var targetYearSpecialTaxReceivables = specialAssessmentTaxReceivableRecords.Where(x => x.TaxYear == propertyTaxReceivable.TaxYear);
                var transactions = propertyTransactions.Where(x => x.TaxYear == propertyTaxReceivable.TaxYear)
                                                       .OrderBy(x => x.TransactionDate);
                result.Add(TaxReceivableMapper.Map(propertyTaxReceivable, targetYearSpecialTaxReceivables, transactions));
            }

            return result;
        }

        private IEnumerable<PropertyTaxReceivableTransaction> GetPropertyTaxReceivableTransactions(IEnumerable<decimal> targetYears, decimal parcelNumber)
        {
            var query = (from specialTransaction in _context.TreasspecialAssessmentsTransactions
                         join propertyTransaction in _context.TreasallPropertyTaxReceivableTransactions
                         on new
                         {
                             specialTransaction.ParcelNumber,
                             specialTransaction.TaxYear,
                             TransactionNumber = specialTransaction.ReceiptTransactionNumber
                         }
                         equals new
                         {
                             propertyTransaction.ParcelNumber,
                             propertyTransaction.TaxYear,
                             TransactionNumber = propertyTransaction.ReceiptTranNumber
                         }
                         where (specialTransaction.ParcelNumber == parcelNumber && targetYears.Contains(specialTransaction.TaxYear.Value)) &&
                               (propertyTransaction.ParcelNumber == parcelNumber && targetYears.Contains(propertyTransaction.TaxYear.Value))
                         select new
                         {
                             SpecialTransactionRecord = specialTransaction,
                             PropertyTransactionRecord = propertyTransaction
                         })
                         .ToList();

            return query.GroupBy(
                     g => g.PropertyTransactionRecord,
                     g => g.SpecialTransactionRecord,
                     (propertyTransaction, specialTransaction) => TaxReceivableMapper.Map(propertyTransaction, specialTransaction)).ToList();
        }
    }
}