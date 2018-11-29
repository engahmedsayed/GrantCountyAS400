using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting
{
    public class AccountPayroll
    {
        public int Id { get; }
        public string Name { get; }
        public decimal SSNumber { get; }
        public decimal PersonNumber { get; }
        public IEnumerable<AccountPayrollWarrant> PayrollWarrants { get; }

        public AccountPayroll(int id, string name, decimal ssNumber, decimal personNumber)
        {
            Id = id;
            Name = name;
            SSNumber = ssNumber;
            PersonNumber = personNumber;
        }

        public AccountPayroll(int id, string name, decimal ssNumber, decimal personNumber, IEnumerable<AccountPayrollWarrant> payrollWarrents)
            : this(id, name, ssNumber, personNumber)
        {
            PayrollWarrants = payrollWarrents;
        }
    }

    public class AccountPayrollWarrant
    {
        public int Id { get; }
        public decimal WarrantNumber { get; }
        public decimal? CheckNumber { get; }
        public decimal? EmployeeNumber { get; }
        public DateTime? Date { get; }
        public decimal? Gross { get; }
        public decimal? Fica { get; }
        public decimal? Medical { get; }
        public decimal? RetirementBenefitsEmployee { get; }
        public decimal? RetirementBenefitsEmployer { get; }
        public decimal? NetPay { get; }

        public AccountPayrollWarrant(
            int id, decimal warrantNumber, decimal? checkNumber, decimal? employeeNumber, DateTime? date, decimal? gross, decimal? fica, decimal? medical,
            decimal? retirementBenefitsEmployee, decimal? retirementBenefitsEmployer, decimal? netPay)
        {
            Id = id;
            WarrantNumber = warrantNumber;
            CheckNumber = checkNumber;
            EmployeeNumber = employeeNumber;
            Date = date;
            Gross = gross;
            Fica = fica;
            Medical = medical;
            RetirementBenefitsEmployee = retirementBenefitsEmployee;
            RetirementBenefitsEmployer = retirementBenefitsEmployer;
            NetPay = netPay;
        }
    }
}