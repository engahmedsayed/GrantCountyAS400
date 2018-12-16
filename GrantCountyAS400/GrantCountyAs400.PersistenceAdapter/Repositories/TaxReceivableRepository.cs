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
            decimal minParcelNumber,
            decimal? maxParcelNumber,
            out int resultCount,
            int pageNumber = 1,
            int pageSize = 50)
        {
            List<TaxReceivable> results = new List<TaxReceivable>();

            // if Max ParcelNumber is null or zero, make it same as Min value as if "single" value was provided
            if (!maxParcelNumber.HasValue || maxParcelNumber.Value == 0)
            {
                maxParcelNumber = minParcelNumber;
            }

            var query = (from treasurerProperty in _context.TreasPropertyMasterInfoView
                         where ((minParcelNumber <= 0) || treasurerProperty.ParcelNumber >= minParcelNumber)
                         && ((maxParcelNumber <= 0) || treasurerProperty.ParcelNumber <= maxParcelNumber)
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

            var targetYears = propTaxReceivablesRecords.Select(x => x.TaxYear.Value).Distinct();
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
            // Query for propertyTransaction(TreasallPropertyTaxReceivableTransactions), along with all related specialTransaction(TreasspecialAssessmentsTransactions)
            // A single "propertyTransaction" could have multiple or none "specialTransaction"
            var query = (from propertyTransaction in _context.TreasallPropertyTaxReceivableTransactions
                         join specialTransaction in _context.TreasspecialAssessmentsTransactions
                         on new
                         {
                             propertyTransaction.ParcelNumber,
                             propertyTransaction.TaxYear,
                         }
                         equals new
                         {
                             specialTransaction.ParcelNumber,
                             specialTransaction.TaxYear,
                         }
                         where (propertyTransaction.ParcelNumber == parcelNumber && targetYears.Contains(propertyTransaction.TaxYear.Value)) &&
                               (specialTransaction.ParcelNumber == parcelNumber && targetYears.Contains(specialTransaction.TaxYear.Value))
                         select new
                         {
                             PropertyTransactionRecord = propertyTransaction,
                             SpecialTransactionRecord = specialTransaction
                         })
                         .ToList();

            // Instead of doing grouping in the SQL query itself(which could be complex and unreadable), do it in memeory using C#
            // Key => PropertyTransactionRecord (which is the main transaction record)
            // Value => list of related "SpecialTransactionRecord", which belongs to the specified key
            //       => because propertyTransaction could have NONE specialTransaction, then it should be filtered by Transaction Number
            return query.GroupBy(
                     g => g.PropertyTransactionRecord,
                     g => g.SpecialTransactionRecord,
                     (propertyTransaction, specialTransaction)
                        => TaxReceivableMapper.Map(
                                propertyTransaction,
                                specialTransaction.Where(x => x.ReceiptTransactionNumber == propertyTransaction.ReceiptTranNumber))
                           ).ToList();
        }
    }
}