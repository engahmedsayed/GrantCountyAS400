using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Extensions;
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

        public IEnumerable<Personnel> GetAllWithContracts(string firstName, string lastName, decimal ssn, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<Personnel> results = new List<Personnel>();
            IQueryable<AcctPersonnel> query = _context.AcctPersonnel;

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(t => t.Name.SplitName(',', NameEnum.FirstName).Contains(firstName));
            }
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(t => t.Name.SplitName(',', NameEnum.LastName).Contains(lastName));
            }
            if (ssn > 0)
            {
                query = query.Where(t => t.Ssnumber == ssn);
            }

            List<Personnel> personnelRecords = new List<Personnel>();
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                personnelRecords = query.Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .OrderBy(t => t.Name)
                                        .Select(PersonnelMapper.Map)
                                        .ToList();
            }
            else
            {
                personnelRecords = query.OrderBy(t => t.Name)
                                        .Select(PersonnelMapper.Map)
                                        .ToList();
                resultCount = personnelRecords.Count();
            }

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

            return results.ToList();
        }

        public PersonnelWithContractFullDetails Details(int id)
        {
            var detailsRecord = (from employee in _context.AcctEmployee
                                 join personnel in _context.AcctPersonnel on employee.Ssnumber equals personnel.Ssnumber
                                 join jobCode in _context.AcctPayrollJobCodes on employee.JobCode equals jobCode.JobCode
                                 where employee.Id == id
                                 select new
                                 {
                                     Peronnel = PersonnelMapper.Map(personnel),
                                     Contract = EmployeeMapper.Map(employee),
                                     JobCode = JobCodeMapper.Map(jobCode)
                                 }
                                ).SingleOrDefault();

            if (detailsRecord != null)
            {
                var deductions = _context.AcctEmployeeMiscDeductions.Where(t => t.EmployeeNumber == detailsRecord.Contract.PersonNumber)
                                                                    .OrderBy(t => t.MiscYear)
                                                                    .Select(DeductionMapper.Map)
                                                                    .ToList();
                var ytdHistories = _context.AcctEmployeeYtdhistory.Where(t => t.Ssnumber == detailsRecord.Contract.SSNumber)
                                                                  .OrderBy(t=>t.Year)
                                                                  .Select(YtdHistoryMapper.Map)
                                                                  .ToList();
                return EmployeeMapper.Map(detailsRecord.Peronnel, detailsRecord.Contract, detailsRecord.JobCode, deductions, ytdHistories);
            }
            else
            {
                return null;
            }
        }
    }
}