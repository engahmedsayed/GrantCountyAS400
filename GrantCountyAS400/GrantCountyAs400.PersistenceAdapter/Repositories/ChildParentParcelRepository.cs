using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class ChildParentParcelRepository : IChildParentParcelRepository
    {
        private readonly GrantCountyDbContext _context;

        public ChildParentParcelRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<ChildParentParcel> GetAll(decimal parcelNumber, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<ChildParentParcel> results = new List<ChildParentParcel>();

            var query = from childParent in _context.AsmtparentChildRelationshipsChanged
                        where ((parcelNumber <= 0) || (childParent.ParentParcel == parcelNumber || childParent.ChildParcel == parcelNumber))
                        select ChildParentParcelMapper.Map(childParent);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ParentParcel)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ParentParcel)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public ChildParentParcelDetails Details(int id)
        {
            var result = (from childParent in _context.AsmtparentChildRelationshipsChanged
                          join masterRecord in _context.AsmtrealPropertyAssessedValueMaster on childParent.ParentParcel equals masterRecord.ParcelNumber
                          join names in _context.ASMTValueMasterNameView on childParent.ParentParcel equals names.ParcelNumber
                          where childParent.Id == id
                          select ChildParentParcelMapper.Map(childParent, names, masterRecord)
                          ).SingleOrDefault();

            return result;
        }
    }
}