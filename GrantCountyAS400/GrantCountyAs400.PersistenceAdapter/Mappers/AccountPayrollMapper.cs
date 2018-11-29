using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class AccountPayrollMapper
    {
        internal static AccountPayroll Map(AcctPersonnel personnel, IEnumerable<AcctPrWarrant> warrants)
            => new AccountPayroll(personnel.Id, personnel.Name, personnel.Ssnumber.Value, personnel.PersonNumber.Value, warrants.Select(Map));

        private static AccountPayrollWarrant Map(AcctPrWarrant warrant)
            => new AccountPayrollWarrant(warrant.Id, warrant.WarrantNumber, warrant.CheckNumber, warrant.EmployeeNumber, warrant.Date, warrant.Gross, warrant.Fica,
                warrant.Medical, warrant.RetirementBenefitsEmployee, warrant.RetirementBenefitsEmployer, warrant.NetPay);
    }
}