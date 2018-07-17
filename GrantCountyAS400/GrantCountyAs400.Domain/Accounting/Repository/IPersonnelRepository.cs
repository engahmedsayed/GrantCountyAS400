using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting.Repository
{
    public interface IPersonnelRepository
    {
        IEnumerable<Personnel> GetAll();

        IEnumerable<Personnel> GetAllWithContracts(string firstName, string lastName, decimal Ssn, out int resultCount, int pageNumber = 1, int pageSize = 50);

        PersonnelWithContractFullDetails Details(int id, string deductionCode, int? fromYear, int? toYear);
    }
}