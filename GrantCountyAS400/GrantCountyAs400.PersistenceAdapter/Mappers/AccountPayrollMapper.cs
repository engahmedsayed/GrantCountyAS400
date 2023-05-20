using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class AccountPayrollMapper
    {
        internal static AccountPayroll Map(AcctPersonnel personnel, IEnumerable<AccountPayrollWarrant> warrants)
            => new AccountPayroll(personnel.Id, personnel.Name, personnel.Ssnumber.Value, personnel.PersonNumber.Value, warrants);

        internal static AccountPayrollWarrant Map(AcctPrWarrant warrant, decimal? hoursWorked)
            => new AccountPayrollWarrant(warrant.Id, warrant.WarrantNumber, warrant.Ssnubmer.Value, warrant.CheckNumber, warrant.EmployeeNumber, warrant.Date,
                warrant.Gross, warrant.Fica, warrant.Medical, warrant.RetirementPay, warrant.RetirementBenefitsEmployer,
                warrant.NetPay, hoursWorked, warrant.DeferredGross, warrant.Taxable);
    }
}