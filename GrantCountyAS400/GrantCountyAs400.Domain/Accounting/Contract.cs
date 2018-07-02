using System;
using System.Diagnostics;

namespace GrantCountyAs400.Domain.Accounting
{
    public enum PayCode
    {
        Hourly,
        Salaried
    }

    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Organization
    {
        public int Fund { get; }
        public int Department { get; }

        public Organization(int fund, int department)
        {
            Fund = fund;
            Department = department;
        }

        private string DebuggerDisplay => $"Fund: {Fund}, Department: {Department}";
    }

    public class Contract
    {
        public int Id { get; }
        public decimal SSNumber { get; }
        public decimal PersonNumber { get; }
        public Organization Organization { get; }
        public DateTime? HireDate { get; }
        public DateTime? TerminationDate { get; }
        public string Status { get { return TerminationDate.HasValue ? "T" : ""; } }
        public int Count { get; }
        public PayCode PayCode { get; }
        public decimal Rate { get; }
        public string Table { get; }
        public string Grade { get; }
        public string Step { get; }
        public string JobCode { get; }

        public Contract(int id, decimal ssNumber, decimal personNumber, Organization organization, DateTime? hireDate, DateTime? terminationDate, int count, PayCode payCode,
            decimal rate, string table, string grade, string step, string jobCode)
        {
            Id = id;
            SSNumber = ssNumber;
            PersonNumber = personNumber;
            Organization = organization;
            HireDate = hireDate;
            TerminationDate = terminationDate;
            Count = count;
            PayCode = payCode;
            Rate = rate;
            Table = table;
            Grade = grade;
            Step = step;
            JobCode = jobCode;
        }
    }
}