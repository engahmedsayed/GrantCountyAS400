using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class DeductionRepository : IDeductionRepository
    {
        private readonly GrantCountyDbContext _context;

        public DeductionRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<string> GetAllCodes()
        {
            return _context.AcctEmployeeMiscDeductions
                           .OrderBy(deduction => deduction.MiscCode.Trim())
                           .Select(deduction => deduction.MiscCode.Trim())
                           .Distinct()
                           .ToList();
        }
    }
}