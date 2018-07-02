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
                employee.Rate.Value, employee.Table, employee.Grade, employee.Step, employee.JobCode);

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