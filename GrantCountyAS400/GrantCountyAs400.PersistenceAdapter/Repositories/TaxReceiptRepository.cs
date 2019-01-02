using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class TaxReceiptRepository : ITaxReceiptRepository
    {
        private readonly GrantCountyDbContext _context;

        public TaxReceiptRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<TaxReceipt> GetAll(
            decimal minReceiptNumber, decimal? maxReceiptNumber, decimal minAffidavitNumber, decimal? maxAffidavitNumber, DateTime? minDate, DateTime? maxDate,
            out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<TaxReceipt> results = new List<TaxReceipt>();

            // if Max TransactionNumber is null or zero, make it same as Min value as if "single" value was provided
            if (!maxReceiptNumber.HasValue || maxReceiptNumber.Value == 0)
            {
                maxReceiptNumber = minReceiptNumber;
            }

            if (!maxAffidavitNumber.HasValue || maxAffidavitNumber.Value == 0)
            {
                maxAffidavitNumber = minAffidavitNumber;
            }

            IQueryable<TaxReceipt> cashReceipts = Enumerable.Empty<TaxReceipt>().AsQueryable();
            // when filtering by "AffidavitNumber", ignore CashReceipts as it doesn't have matching propety for "AffidavitNumber"
            if (minAffidavitNumber <= 0)
            {
                cashReceipts = (from x in _context.TreascashReceiptsTender
                                where ((minReceiptNumber <= 0) || x.ReceiptTranNumber >= minReceiptNumber)
                                && ((maxReceiptNumber <= 0) || x.ReceiptTranNumber <= maxReceiptNumber)
                                && ((!minDate.HasValue) || x.ReceiptDate >= minDate.Value)
                                && ((!maxDate.HasValue) || x.ReceiptDate <= maxDate.Value)
                                select new TaxReceipt(x.ReceiptTranNumber.Value, x.ReceiptDate, null));
            }

            var generalReceipts = (from x in _context.TreastenderGeneralReceipts
                                   where ((minReceiptNumber <= 0) || x.ReceiptTranNumber >= minReceiptNumber)
                                   && ((maxReceiptNumber <= 0) || x.ReceiptTranNumber <= maxReceiptNumber)
                                   && ((minAffidavitNumber <= 0) || x.ReceiptTran >= minAffidavitNumber)
                                   && ((maxAffidavitNumber <= 0) || x.ReceiptTran <= maxAffidavitNumber)
                                   && ((!minDate.HasValue) || x.TranDate >= minDate.Value)
                                   && ((!maxDate.HasValue) || x.TranDate <= maxDate.Value)
                                   select new TaxReceipt(x.ReceiptTranNumber.Value, x.TranDate, x.ReceiptTran));

            var affadavitReceipts = (from x in _context.TreastenderAffadavits
                                     where ((minReceiptNumber <= 0) || x.ReceiptTranNumber >= minReceiptNumber)
                                     && ((maxReceiptNumber <= 0) || x.ReceiptTranNumber <= maxReceiptNumber)
                                     && ((minAffidavitNumber <= 0) || x.ReceiptTran >= minAffidavitNumber)
                                     && ((maxAffidavitNumber <= 0) || x.ReceiptTran <= maxAffidavitNumber)
                                     && ((!minDate.HasValue) || x.AffidavitDate >= minDate.Value)
                                     && ((!maxDate.HasValue) || x.AffidavitDate <= maxDate.Value)
                                     && (x.TotalPaid > 0)
                                     select new TaxReceipt(x.ReceiptTranNumber.Value, x.AffidavitDate, x.ReceiptTran));

            var query = cashReceipts.Union(generalReceipts).Union(affadavitReceipts).Distinct();
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ReceiptNumber)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ReceiptNumber)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public TaxReceiptDetails Details(decimal transactionNumber)
        {
            var cashReceipts = (from x in _context.TreascashReceiptsTender
                                where x.ReceiptTranNumber == transactionNumber
                                select TaxReceiptMapper.Map(x)).ToList();

            var generalReceipts = (from x in _context.TreastenderGeneralReceipts
                                   where x.ReceiptTranNumber == transactionNumber
                                   select TaxReceiptMapper.Map(x)).ToList();

            var affadavitReceipts = (from x in _context.TreastenderAffadavits
                                     where x.ReceiptTranNumber == transactionNumber &&
                                           x.TotalPaid > 0
                                     select TaxReceiptMapper.Map(x)).ToList();

            IEnumerable<DateTime> receiptDates = cashReceipts.Select(x => x.ReceiptDate.Value);
            var propertyTransactions = GetPropertyTaxReceivableTransactions(transactionNumber, receiptDates);

            return new TaxReceiptDetails(transactionNumber, cashReceipts, generalReceipts, affadavitReceipts, propertyTransactions);
        }

        public IEnumerable<TaxPaymentReceipt> GetAllTaxPaymentReceipts(
            decimal parcelNumber, decimal parcelExtension, int taxyear, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            var results = new List<TaxPaymentReceipt>();
            var query = from transaction in _context.TreasallPropertyTaxReceivableTransactions
                        where ((parcelNumber <= 0) || transaction.ParcelNumber == parcelNumber)
                        && ((parcelExtension <= 0) || transaction.ParcelExtension == parcelExtension)
                        && ((taxyear <= 0) || transaction.TaxYear == taxyear)
                        select TaxReceiptMapper.Map(transaction)
                        ;

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ParcelNumber)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ParcelNumber)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        private List<PropertyTaxReceivableTransaction> GetPropertyTaxReceivableTransactions(decimal transactionNumber, IEnumerable<DateTime> receiptDates)
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
                         where
                         propertyTransaction.ReceiptTranNumber == transactionNumber &&
                         specialTransaction.ReceiptTransactionNumber == transactionNumber &&
                         receiptDates.Contains(propertyTransaction.TranDate.Value) &&
                         receiptDates.Contains(specialTransaction.TranactionDate.Value)
                         orderby propertyTransaction.TaxYear, propertyTransaction.ParcelNumber, propertyTransaction.TaxAmount
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