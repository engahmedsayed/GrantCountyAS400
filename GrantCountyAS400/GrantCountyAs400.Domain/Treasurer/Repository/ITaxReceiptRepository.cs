using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Treasurer.Repository
{
    public interface ITaxReceiptRepository
    {
        IEnumerable<TaxReceipt> GetAll(
            decimal minReceiptNumber, decimal? maxReceiptNumber, decimal minAffidavitNumber, decimal? maxAffidavitNumber, DateTime? minDate, DateTime? maxDate,
            out int resultCount, int pageNumber = 1, int pageSize = 50);
        TaxReceiptDetails Details(decimal transactionNumber);

        IEnumerable<TaxPaymentReceipt> GetAllTaxPaymentReceipts(
            decimal parcelNumber, decimal parcelExtension, int taxyear, out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}
