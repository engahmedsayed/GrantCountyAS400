using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Treasurer.Repository
{
    public interface IExciseTaxRateRepository
    {
        IEnumerable<ExciseTaxRate> GetAll(string description, string recordType, out int resultCount, int pageNumber = 1, int pageSize = 50);
        IEnumerable<string> GetAllDescriptions();
    }
}
