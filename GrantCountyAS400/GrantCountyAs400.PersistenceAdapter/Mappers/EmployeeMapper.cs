using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;

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

        internal static PersonnelWithContractFullDetails Map(Personnel personnel, Contract employee, JobCode jobCode,
            IEnumerable<Deduction> deductions, IEnumerable<YtdHistory> ytdHistories) =>
            new PersonnelWithContractFullDetails(personnel.Name, personnel.SSNumber, personnel.PersonNumber, employee.Id, employee.Organization,
                employee.HireDate, employee.TerminationDate, employee.Count, employee.PayCode, employee.Rate, employee.Table, employee.Grade,
                employee.Step, employee.JobCode, employee.EmpLongevityAmount, employee.Type, employee.EmpFilled, employee.RetirementLock,
                employee.RetirementCode, employee.ServiceDate, employee.AnniversaryDate, employee.RetirementNumber, employee.TerminationType,
                employee.MeritStatus, employee.EmpEeofunction, jobCode.Title, deductions, ytdHistories);

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