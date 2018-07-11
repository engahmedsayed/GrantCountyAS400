namespace GrantCountyAs400.Domain.Accounting
{
    public class YtdHistory
    {
        public int Id { get; }
        public int Year { get; }
        public decimal Group { get; }
        public string Name { get; }
        public decimal Number { get; }
        public decimal Fund { get; }
        public decimal Department { get; }
        public decimal YearlyGrossPay { get; }
        public decimal YearlyGrossPayDeferred { get; }
        public decimal YearlyNonTaxable { get; }
        public decimal YearlyTaxable { get; }
        public decimal YearlyFicaGross { get; }
        public decimal YearlyFederalWithholding { get; }
        public decimal YearlyStatWithholding { get; }
        public decimal YearlyFica { get; }
        public decimal YearlyFicaBenefit { get; }
        public decimal YearlyMedicalGross { get; }
        public decimal YearlyMedical { get; }
        public decimal YearlyMedicalBenefit { get; }
        public decimal YearlyTaxableBenefit { get; }
        public decimal YearlyNetPay { get; }
        public decimal YearlyTotalPay { get; }
        public decimal YearlyRetirementGross { get; }
        public decimal YearlyRetirement { get; }
        public decimal YearlyRetirementBenefitEmployee { get; }
        public decimal YearlyRetirementBenefitEmployer { get; }

        public YtdHistory(int id, int year, decimal group, string name, decimal number, decimal fund, decimal department, decimal yearlyGrossPay,
            decimal yearlyGrossPayDeferred, decimal yearlyNonTaxable, decimal yearlyTaxable, decimal yearlyFicaGross, decimal yearlyFederalWithholding,
            decimal yearlyStatWithholding, decimal yearlyFica, decimal yearlyFicaBenefit, decimal yearlyMedicalGross, decimal yearlyMedical,
            decimal yearlyMedicalBenefit, decimal yearlyTaxableBenefit, decimal yearlyNetPay, decimal yearlyTotalPay, decimal yearlyRetirementGross,
            decimal yearlyRetirement, decimal yearlyRetirementBenefitEmployee, decimal yearlyRetirementBenefitEmployer)
        {
            Id = id;
            Year = year;
            Group = group;
            Name = name;
            Number = number;
            Fund = fund;
            Department = department;
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