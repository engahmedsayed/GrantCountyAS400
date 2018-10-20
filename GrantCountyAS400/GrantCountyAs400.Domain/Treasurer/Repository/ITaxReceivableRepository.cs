using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Treasurer.Repository
{
    public interface ITaxReceivableRepository
    {
        IEnumerable<TreasurerMaster> GetAll(decimal parcelNumber, out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}
