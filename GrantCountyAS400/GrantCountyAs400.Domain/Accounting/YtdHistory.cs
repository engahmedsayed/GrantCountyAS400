namespace GrantCountyAs400.Domain.Accounting
{
    public class YtdHistory
    {
        public int Id { get; }
        public int Year { get; }
        public decimal? Group { get; }
        public string Name { get; }
        public decimal Number { get; }
        public decimal? Ssnumber { get; }
        public decimal? Count { get; }
        public decimal? Fund { get; }
        public decimal? Department { get; }
        public decimal? RetirementNumber { get; }
        public decimal? RetirementFlag { get; }
        public decimal? RetirementCode { get; }
        public string PayCode { get; }
        public decimal? PayStatus { get; }
        public decimal? BondType { get; }
        public decimal? BondPurchase { get; }
        public decimal? BondCurrent { get; }
        public decimal? Embondcnt { get; }
        public decimal? Rate { get; }
        public string Emsftabl { get; }
        public decimal? Saif { get; }
        public decimal? Filled { get; }
        public decimal? Percent { get; }
        public decimal? Longevity { get; }
        public decimal? FicaExempt { get; }
        public decimal? FicaCode { get; }
        public string EmpJobCode { get; }
        public string Table { get; }
        public string Grade { get; }
        public string Step { get; }
        public string BargainingUnit { get; }
        public string MeritFlag { get; }
        public decimal? Type { get; }
        public string Flsa { get; }
        public decimal? YearlyGrossPay { get; }
        public decimal? YearlyGrossPayDeferred { get; }
        public decimal? YearlyNonTaxable { get; }
        public decimal? YearlyTaxable { get; }
        public decimal? YearlyFicaGross { get; }
        public decimal? YearlyFederalWithholding { get; }
        public decimal? YearlyStatWithholding { get; }
        public decimal? YearlyFica { get; }
        public decimal? YearlyFicaBenefit { get; }
        public decimal? YearlyMedicalGross { get; }
        public decimal? YearlyMedical { get; }
        public decimal? YearlyMedicalBenefit { get; }
        public decimal? YearlyTaxableBenefit { get; }
        public decimal? YearlyNetPay { get; }
        public decimal? YearlyTotalPay { get; }
        public decimal? YearlyRetirementGross { get; }
        public decimal? YearlyRetirement { get; }
        public decimal? YearlyRetirementBenefitEmployee { get; }
        public decimal? YearlyRetirementBenefitEmployer { get; }

        public YtdHistory(
            int id, int year, decimal? group, string name, decimal number, decimal? ssnumber, decimal? count, decimal? fund, decimal? department,
            decimal? retirementNumber, decimal? retirementFlag, decimal? retirementCode, string payCode, decimal? payStatus, decimal? bondType, decimal? bondPurchase,
            decimal? bondCurrent, decimal? embondcnt, decimal? rate, string emsftabl, decimal? saif, decimal? filled, decimal? percent, decimal? longevity,
            decimal? ficaExempt, decimal? ficaCode, string empJobCode, string table, string grade, string step, string bargainingUnit, string meritFlag, decimal? type,
            string flsa, decimal? yearlyGrossPay, decimal? yearlyGrossPayDeferred, decimal? yearlyNonTaxable, decimal? yearlyTaxable, decimal? yearlyFicaGross,
            decimal? yearlyFederalWithholding, decimal? yearlyStatWithholding, decimal? yearlyFica, decimal? yearlyFicaBenefit, decimal? yearlyMedicalGross,
            decimal? yearlyMedical, decimal? yearlyMedicalBenefit, decimal? yearlyTaxableBenefit, decimal? yearlyNetPay, decimal? yearlyTotalPay,
            decimal? yearlyRetirementGross, decimal? yearlyRetirement, decimal? yearlyRetirementBenefitEmployee, decimal? yearlyRetirementBenefitEmployer)
        {
            Id = id;
            Year = year;
            Group = group;
            Name = name;
            Number = number;
            Ssnumber = ssnumber;
            Count = count;
            Fund = fund;
            Department = department;
            RetirementNumber = retirementNumber;
            RetirementFlag = retirementFlag;
            RetirementCode = retirementCode;
            PayCode = payCode;
            PayStatus = payStatus;
            BondType = bondType;
            BondPurchase = bondPurchase;
            BondCurrent = bondCurrent;
            Embondcnt = embondcnt;
            Rate = rate;
            Emsftabl = emsftabl;
            Saif = saif;
            Filled = filled;
            Percent = percent;
            Longevity = longevity;
            FicaExempt = ficaExempt;
            FicaCode = ficaCode;
            EmpJobCode = empJobCode;
            Table = table;
            Grade = grade;
            Step = step;
            BargainingUnit = bargainingUnit;
            MeritFlag = meritFlag;
            Type = type;
            Flsa = flsa;
            YearlyGrossPay = yearlyGrossPay;
            YearlyGrossPayDeferred = yearlyGrossPayDeferred;
            YearlyNonTaxable = yearlyNonTaxable;
            YearlyTaxable = yearlyTaxable;
            YearlyFicaGross = yearlyFicaGross;
            YearlyFederalWithholding = yearlyFederalWithholding;
            YearlyStatWithholding = yearlyStatWithholding;
            YearlyFica = yearlyFica;
            YearlyFicaBenefit = yearlyFicaBenefit;
            YearlyMedicalGross = yearlyMedicalGross;
            YearlyMedical = yearlyMedical;
            YearlyMedicalBenefit = yearlyMedicalBenefit;
            YearlyTaxableBenefit = yearlyTaxableBenefit;
            YearlyNetPay = yearlyNetPay;
            YearlyTotalPay = yearlyTotalPay;
            YearlyRetirementGross = yearlyRetirementGross;
            YearlyRetirement = yearlyRetirement;
            YearlyRetirementBenefitEmployee = yearlyRetirementBenefitEmployee;
            YearlyRetirementBenefitEmployer = yearlyRetirementBenefitEmployer;
        }
    }
}