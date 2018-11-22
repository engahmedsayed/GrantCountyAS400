using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting.Repository
{
    public interface IAccountPayableRepository
    {
        IEnumerable<VenderWarrent> GetAll(
            string vendorId, string name, string representative, DateTime? minPayDate, DateTime? maxPayDate, out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}