using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IPlatCondoRepository
    {
        IEnumerable<PlatCondo> GetAll(string codeType, string code, string nameDesc, out int resultCount, int pageNumber = 1, int pageSize = 50);

        PlatCondo Details(int id);

        IEnumerable<string> GetAllPlatCodeTypes();
    }
}