using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting.Repository
{
    public interface IDeductionRepository
    {
        IEnumerable<string> GetAllCodes();
    }
}