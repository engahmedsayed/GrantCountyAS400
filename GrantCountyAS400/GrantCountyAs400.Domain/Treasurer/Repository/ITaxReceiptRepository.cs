using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Treasurer.Repository
{
    public interface ITaxReceiptRepository
    {
        TaxReceiptDetails Details(decimal transactionNumber);
    }
}
