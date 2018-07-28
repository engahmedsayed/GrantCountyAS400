using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IPlatCondoRepository
    {
        IEnumerable<PlatCondo> GetAll(out int resultCount, int pageNumber = 1, int pageSize = 50);

        PlatCondo Details(int id);
    }
}