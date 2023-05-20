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
        public decimal SSNumber { get; }
        public decimal? CheckNumber { get; }
        public decimal? EmployeeNumber { get; }
        public DateTime? Date { get; }
        public decimal? Gross { get; }
        public decimal? Fica { get; }
        public decimal? Medical { get; }
        public decimal? RetirementPay { get; }
        public decimal? RetirementBenefitsEmployer { get; }
        public decimal? NetPay { get; }
        public decimal? HoursWorked { get; }
        public decimal? DeferredGross { get; set; }

        public decimal? Taxable { get; set; }

        public AccountPayrollWarrant(
            int id, decimal warrantNumber, decimal ssNumber, decimal? checkNumber, decimal? employeeNumber, DateTime? date, decimal? gross, decimal? fica,
            decimal? medical, decimal? retirementPay, decimal? retirementBenefitsEmployer,
            decimal? netPay, decimal? hoursWorked,decimal? deferredGross,decimal? taxable)
        {
            Id = id;
            WarrantNumber = warrantNumber;
            SSNumber = ssNumber;
            CheckNumber = checkNumber;
            EmployeeNumber = employeeNumber;
            Date = date;
            Gross = gross;
            Fica = fica;
            Medical = medical;
            RetirementPay = retirementPay;
            RetirementBenefitsEmployer = retirementBenefitsEmployer;
            NetPay = netPay;
            HoursWorked = hoursWorked;
            DeferredGross = deferredGross;
            Taxable = taxable;
        }
    }
}