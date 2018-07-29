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

        public IEnumerable<PlatCondo> GetAll(string codeType, string code, string nameDesc, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<PlatCondo> results = new List<PlatCondo>();

            var query = from platcondo in _context.AsmtplatCondoMaster
                        where !string.IsNullOrWhiteSpace(platcondo.PlatCodeType) && platcondo.PlatCodeType != "3P"
                        select PlatCondoMapper.Map(platcondo);

            if (!string.IsNullOrWhiteSpace(codeType))
            {
                query = query.Where(t => t.PlatCodeType.ToLower() == codeType.ToLower());
            }
            if (!string.IsNullOrWhiteSpace(code))
            {
                query = query.Where(t => t.PlatCode.ToLower().Contains(code.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(nameDesc))
            {
                query = query.Where(t => t.PlatNameDesc.ToLower().Contains(nameDesc.ToLower()));
            }

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

        public IEnumerable<string> GetAllPlatCodeTypes()
        {
            return _context.AsmtplatCondoMaster
                           .Where(platcondo => !string.IsNullOrWhiteSpace(platcondo.PlatCodeType) && platcondo.PlatCodeType != "3P")
                           .OrderBy(platcondo => platcondo.PlatCodeType.Trim())
                           .Select(platcondo => platcondo.PlatCodeType.Trim())
                           .Distinct()
                           .ToList();
        }
    }
}