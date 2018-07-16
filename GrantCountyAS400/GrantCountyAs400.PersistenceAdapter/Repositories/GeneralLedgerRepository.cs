using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Mappers;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class GeneralLedgerRepository : IGeneralLedgerRepository
    {
        private readonly GrantCountyDbContext _context;

        public GeneralLedgerRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<GeneralLedger> GetAll(out int resultCount, int pageNumber = 1, int pageSize = 50, int fiscalYear = 2008, string fund = "", string department = "", string program = "")
        {
            List<GeneralLedger> results = new List<GeneralLedger>();
            IQueryable<AcctGeneralLedger> query = _context.AcctGeneralLedger.Where(t=>t.FiscalYear == fiscalYear);
            if (!string.IsNullOrWhiteSpace(fund))
            {
                query = query.Where(t => t.Fund == fund);
            }
            if (!string.IsNullOrWhiteSpace(department))
            {
                query = query.Where(t => t.Department == department);
            }
            if (!string.IsNullOrWhiteSpace(program))
            {
                query = query.Where(t => t.Program == program);
            }
            if(pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .OrderBy(t => t.Id)
                                      .Select(GeneralLedgerMapper.Map)
                                      .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.Id)
                                     .Select(GeneralLedgerMapper.Map)
                                     .ToList();
                resultCount = results.Count();
            }
            return results;

        }
    }
}
