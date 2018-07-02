using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Mappers;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class PersonnelRepository : IPersonnelRepository
    {
        private readonly GrantCountyDbContext _context;

        public PersonnelRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Personnel> GetAll()
        {
            return _context.AcctPersonnel
                            .Select(PersonnelMapper.Map)
                            .ToList();
        }

        public IEnumerable<Personnel> GetAllWithContracts()
        {
            List<Personnel> results = new List<Personnel>();

            var personnelRecords = _context.AcctPersonnel
                                    .Select(PersonnelMapper.Map)
                                    .ToList();

            var listOfRetrievedSSNumbers = personnelRecords.Select(personnel => personnel.SSNumber).ToList();

            var employeeRecords = _context.AcctEmployee
                                    .Where(emp => listOfRetrievedSSNumbers.Contains(emp.Ssnumber.Value))
                                    .Select(EmployeeMapper.Map)
                                    .ToList();

            foreach (var personnel in personnelRecords)
            {
                results.Add(new Personnel(
                    personnel.Id, personnel.Name, personnel.SSNumber, personnel.PersonNumber,
                    employeeRecords.Where(emp => emp.SSNumber == personnel.SSNumber)
                ));
            }

            return results;
        }
    }
}