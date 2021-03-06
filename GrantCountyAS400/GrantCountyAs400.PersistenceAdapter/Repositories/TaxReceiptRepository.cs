﻿using GrantCountyAs400.Domain.Treasurer;
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

        public TaxReceiptDetails Details(decimal receiptNumber)
        {
            var cashReceipts = (from x in _context.TreascashReceiptsTender
                                where x.ReceiptTranNumber == receiptNumber
                                select TaxReceiptMapper.Map(x)).ToList();

            var generalReceipts = (from x in _context.TreastenderGeneralReceipts
                                   where x.ReceiptTranNumber == receiptNumber
                                   select TaxReceiptMapper.Map(x)).ToList();

            var affadavitReceipts = (from x in _context.TreastenderAffadavits
                                     where x.ReceiptTranNumber == receiptNumber &&
                                           x.TotalPaid > 0
                                     select TaxReceiptMapper.Map(x)).ToList();

            IEnumerable<DateTime> receiptDates = cashReceipts.Select(x => x.ReceiptDate.Value);
            var propertyTransactions = GetPropertyTaxReceivableTransactions(receiptNumber, receiptDates);

            return new TaxReceiptDetails(receiptNumber, cashReceipts, generalReceipts, affadavitReceipts, propertyTransactions);
        }

        public IEnumerable<AffadavitReceipt> GetAllAffadavitReceipts(
            decimal minParcelNumber, decimal? maxParcelNumber, decimal minAffidavitNumber, decimal? maxAffidavitNumber, out int resultCount, int pageNumber = 1,
            int pageSize = 50)
        {
            var results = new List<AffadavitReceipt>();

            // if Max TransactionNumber is null or zero, make it same as Min value as if "single" value was provided
            if (!maxParcelNumber.HasValue || maxParcelNumber.Value == 0)
            {
                maxParcelNumber = minParcelNumber;
            }

            if (!maxAffidavitNumber.HasValue || maxAffidavitNumber.Value == 0)
            {
                maxAffidavitNumber = minAffidavitNumber;
            }

            var query = from receipt in _context.TreastenderAffadavits
                        where ((minParcelNumber <= 0) || receipt.ParcelNumber >= minParcelNumber)
                        && ((maxParcelNumber <= 0) || receipt.ParcelNumber <= maxParcelNumber)
                        && ((minAffidavitNumber <= 0) || receipt.ReceiptTran >= minAffidavitNumber)
                        && ((maxAffidavitNumber <= 0) || receipt.ReceiptTran <= maxAffidavitNumber)
                        && (receipt.TotalPaid > 0)
                        select TaxReceiptMapper.Map(receipt);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.AffidavitDate)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.AffidavitDate)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
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

        public IEnumerable<GeneralReceipt> GetAllGeneralReceipts(decimal receiptNumber, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            var results = new List<GeneralReceipt>();
            var query = from transaction in _context.TreastenderGeneralReceipts
                        where ((receiptNumber <= 0) || transaction.ReceiptTranNumber == receiptNumber)
                        select TaxReceiptMapper.Map(transaction)
                        ;

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

        public AffadavitReceiptDetails AffadavitReceiptDetails(int affadavitReceiptId)
        {
            var query = (from receipt in _context.TreastenderAffadavits
                         join cashReceipt in _context.TreascashReceiptsTender
                         on new { receipt.TranYear, receipt.ReceiptTranNumber } equals new { cashReceipt.TranYear, cashReceipt.ReceiptTranNumber }
                         into cashReceiptJoin
                         from cashReceiptRecord in cashReceiptJoin.DefaultIfEmpty()
                         join codeArea in _context.AsmttaxCodeArea on receipt.TaxCodeArea equals codeArea.TaxCodeArea
                         into codeAreaJoin
                         from codeAreaRecord in codeAreaJoin.DefaultIfEmpty()
                         where receipt.Id == affadavitReceiptId
                         select new
                         {
                             AffadavitReceipt = receipt,
                             CashReceipt = cashReceiptRecord,
                             CodeArea = codeAreaRecord
                         }).FirstOrDefault();

            var affadavitParcels = (from receipt in _context.TreastenderAffadavits
                                    join valueMaster in _context.AsmtrealPropertyAssessedValueMaster on receipt.ParcelNumber equals valueMaster.ParcelNumber
                                    join nameAddress in _context.AsmtmasterNameAddress
                                    on valueMaster.TitleOwnerCode equals nameAddress.NameCode
                                    join legalDescription in _context.AsmtfullLegalDescription.Where(t => t.SequenceNumber == 1)
                                    on receipt.ParcelNumber equals legalDescription.ParcelNumber
                                    into legalDescriptionJoin
                                    from legalDescriptionRecord in legalDescriptionJoin.DefaultIfEmpty()
                                    where receipt.ReceiptTran == query.AffadavitReceipt.ReceiptTran
                                    select TaxReceiptMapper.MapToParcel(receipt, valueMaster, nameAddress, legalDescriptionRecord)
                                   ).ToList();

            return TaxReceiptMapper.MapToDetails(query.AffadavitReceipt, query.CashReceipt, query.CodeArea, affadavitParcels);
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