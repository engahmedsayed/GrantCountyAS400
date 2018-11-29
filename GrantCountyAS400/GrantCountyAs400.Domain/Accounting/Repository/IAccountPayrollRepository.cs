using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting.Repository
{
    public interface IAccountPayrollRepository
    {
        IEnumerable<AccountPayroll> GetAll(
            string firstName, string lastName, decimal ssn, DateTime? minDate, DateTime? maxDate, decimal employeeNumber, out int resultCount, int pageNumber = 1,
            int pageSize = 50);
    }
}