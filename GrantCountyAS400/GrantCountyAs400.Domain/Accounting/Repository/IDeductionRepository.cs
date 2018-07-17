using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting
{
    public interface IDeductionRepository
    {
        IEnumerable<string> GetAllCodes();
    }
}