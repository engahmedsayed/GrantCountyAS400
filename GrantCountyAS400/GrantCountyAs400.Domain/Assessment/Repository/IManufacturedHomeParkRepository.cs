using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IManufacturedHomeParkRepository
    {
        IEnumerable<ManufacturedHomePark> GetAll(string parkCode, string parkName, string contactName, out int resultCount, int pageNumber = 1, int pageSize = 50);

        ManufacturedHomeParkDetails Details(int id);
    }
}