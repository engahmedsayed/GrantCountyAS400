using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting
{
    public interface IPersonnelRepository
    {
        IEnumerable<Personnel> GetAll();
        IEnumerable<Personnel> GetAllWithContracts();
    }
}