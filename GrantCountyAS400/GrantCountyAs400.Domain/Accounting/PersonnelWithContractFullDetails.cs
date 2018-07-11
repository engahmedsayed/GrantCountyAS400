using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting
{
    public class PersonnelWithContractFullDetails
    {
        public string Name { get; }
        public decimal SSNumber { get; }
        public decimal PersonNumber { get; }

        public int Id { get; }
        public Organization Organization { get; }
        public DateTime? HireDate { get; }
        public DateTime? TerminationDate { get; }
        public int Count { get; }
        public PayCode PayCode { get; }
        public decimal Rate { get; }
        public string Table { get; }
        public string Grade { get; }
        public string Step { get; }
        public string JobCode { get; }
        public decimal EmpLongevityAmount { get; }
        public decimal Type { get; }
        public decimal EmpFilled { get; }
        public decimal RetirementLock { get; }
        public decimal RetirementCode { get; }
        public DateTime? ServiceDate { get; }
        public DateTime? AnniversaryDate { get; }
        public decimal RetirementNumber { get; }
        public string TerminationType { get; }
        public string MeritStatus { get; }
        public string EmpEeofunction { get; }
        public string JobTitle { get; }

        public IEnumerable<Deduction> Deductions { get; }
        public IEnumerable<YtdHistory> YtdHistories { get; }

        public PersonnelWithContractFullDetails(string name, decimal ssNumber, decimal personNumber, int contractId, Organization organization, DateTime? hireDate, DateTime? terminationDate, int count, PayCode payCode,
            decimal rate, string table, string grade, string step, string jobCode, decimal empLongevityAmount, decimal type, decimal empFilled,
            decimal retirementLock, decimal retirementCode, DateTime? serviceDate, DateTime? anniversaryDate, decimal retirementNumber,
            string terminationType, string meritStatus, string empEeofunction, string jobTitle, IEnumerable<Deduction> deductions,
           IEnumerable<YtdHistory> ytdHistories)
        {
            Name = name;
            SSNumber = ssNumber;
            PersonNumber = personNumber;

            Id = contractId;
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
            EmpLongevityAmount = empLongevityAmount;
            Type = type;
            EmpFilled = empFilled;
            RetirementLock = retirementLock;
            RetirementCode = retirementCode;
            ServiceDate = serviceDate;
            AnniversaryDate = anniversaryDate;
            RetirementNumber = retirementNumber;
            TerminationType = terminationType;
            MeritStatus = meritStatus;
            EmpEeofunction = empEeofunction;
            JobTitle = JobTitle;
            Deductions = deductions;
            YtdHistories = ytdHistories;
        }
    }
}