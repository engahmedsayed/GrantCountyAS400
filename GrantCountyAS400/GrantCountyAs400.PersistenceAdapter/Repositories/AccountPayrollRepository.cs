using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.PersistenceAdapter.Extensions;
using GrantCountyAs400.PersistenceAdapter.Mappers;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class AccountPayrollRepository : IAccountPayrollRepository
    {
        private readonly GrantCountyDbContext _context;

        public AccountPayrollRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<AccountPayroll> GetAll(
            string firstName, string lastName, decimal ssn, DateTime? minDate, DateTime? maxDate, decimal employeeNumber, out int resultCount, int pageNumber = 1,
            int pageSize = 50)
        {
            List<AccountPayroll> results = new List<AccountPayroll>();
            IQueryable<AcctPersonnel> query = _context.AcctPersonnel;

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(t => t.Name.ToLower().SplitName(',', NameEnum.FirstName).Contains(firstName.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(t => t.Name.ToLower().SplitName(',', NameEnum.LastName).Contains(lastName.ToLower()));
            }
            if (ssn > 0)
            {
                query = query.Where(t => t.Ssnumber == ssn);
            }

            List<AcctPersonnel> personnelRecords = new List<AcctPersonnel>();
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                personnelRecords = query.Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .OrderBy(t => t.Name)
                                        .ToList();
            }
            else
            {
                personnelRecords = query.OrderBy(t => t.Name)
                                        .ToList();
                resultCount = personnelRecords.Count();
            }

            var listOfRetrievedSSNumbers = personnelRecords.Select(personnel => personnel.Ssnumber).ToList();

            var warrants = _context.AcctPrWarrant
                                   .Where(warrant => listOfRetrievedSSNumbers.Contains(warrant.Ssnubmer.Value) &&
                                                     ((employeeNumber <= 0) || (warrant.EmployeeNumber == employeeNumber)) &&
                                                     ((!minDate.HasValue) || warrant.Date >= minDate.Value) &&
                                                     ((!maxDate.HasValue) || warrant.Date <= maxDate.Value))
                                   .ToList();

            foreach (var personnel in personnelRecords)
            {
                results.Add(AccountPayrollMapper.Map(personnel, warrants.Where(warrant => warrant.Ssnubmer == personnel.Ssnumber)));
            }

            return results;
        }
    }
}