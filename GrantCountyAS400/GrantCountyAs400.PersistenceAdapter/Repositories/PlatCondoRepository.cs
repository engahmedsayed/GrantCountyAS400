using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class PlatCondoRepository : IPlatCondoRepository
    {
        private readonly GrantCountyDbContext _context;

        public PlatCondoRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<PlatCondo> GetAll(out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<PlatCondo> results = new List<PlatCondo>();

            var query = from platcondo in _context.AsmtplatCondoMaster
                        select PlatCondoMapper.Map(platcondo);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.PlatCode)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.PlatCode)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public PlatCondo Details(int id)
        {
            return _context.AsmtplatCondoMaster
                           .Select(PlatCondoMapper.Map)
                           .SingleOrDefault(t => t.Id == id);
        }
    }
}