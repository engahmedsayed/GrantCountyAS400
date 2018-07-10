using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class EmployeeMapper
    {
        internal static Contract Map(AcctEmployee employee) =>
            new Contract(employee.Id, employee.Ssnumber.Value, employee.Number, new Organization((int)employee.Fund.Value,
                (int)employee.Department.Value), employee.HireDate, employee.TerminationDate, (int)employee.Count.Value, Map(employee.PayCode),
                employee.Rate.Value, employee.Table, employee.Grade, employee.Step, employee.JobCode, employee.EmpLongevityAmount.Value,
                employee.Type.Value, employee.EmpFilled.Value, employee.RetirementLock.Value, employee.RetirementCode.Value, employee.ServiceDate,
                employee.AnniversaryDate, employee.RetirementNumber.Value, employee.TerminationType, employee.MeritStatus, employee.EmpEeofunction);

        internal static PersonnelWithContractFullDetails Map(AcctPersonnel personnel, AcctEmployee employee, AcctPayrollJobCodes jobCode) =>
            new PersonnelWithContractFullDetails(personnel.Name, personnel.Ssnumber.Value, personnel.PersonNumber.Value,
                employee.Id, new Organization((int)employee.Fund.Value, (int)employee.Department.Value), employee.HireDate, employee.TerminationDate,
                (int)employee.Count.Value, Map(employee.PayCode), employee.Rate.Value, employee.Table, employee.Grade, employee.Step, employee.JobCode,
                employee.EmpLongevityAmount.Value, employee.Type.Value, employee.EmpFilled.Value, employee.RetirementLock.Value,
                employee.RetirementCode.Value, employee.ServiceDate, employee.AnniversaryDate, employee.RetirementNumber.Value,
                employee.TerminationType, employee.MeritStatus, employee.EmpEeofunction, jobCode.JobTitle);

        private static PayCode Map(string payCode)
        {
            switch (payCode)
            {
                case "H":
                    return PayCode.Hourly;

                case "S":
                    return PayCode.Salaried;

                default:
                    throw new ArgumentOutOfRangeException(nameof(payCode));
            }
        }
    }
}