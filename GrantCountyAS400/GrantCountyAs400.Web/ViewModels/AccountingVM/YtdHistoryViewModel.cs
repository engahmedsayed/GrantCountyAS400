using GrantCountyAs400.Web.Extensions;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class YtdHistoryViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Year")]
        public int Year { get; set; }
        [Display(Name = "Group")]
        public decimal? Group { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Number")]
        public decimal Number { get; set; }
        public decimal? Ssnumber { get; set; }
        [Display(Name = "Count")]
        public decimal? Count { get; set; }
        [Display(Name = "Fund")]
        public decimal? Fund { get; set; }
        [Display(Name = "Department")]
        public decimal? Department { get; set; }
        [Display(Name = "Retirement Number")]
        public decimal? RetirementNumber { get; set; }
        [Display(Name = "Retirement Flag")]
        public decimal? RetirementFlag { get; set; }
        [Display(Name = "Retirement Code")]
        public decimal? RetirementCode { get; set; }
        [Display(Name = "Pay Code")]
        public string PayCode { get; set; }
        [Display(Name = "Pay Status")]
        public decimal? PayStatus { get; set; }
        [Display(Name = "Bond Type")]
        public decimal? BondType { get; set; }
        [Display(Name = "Bond Purchase")]
        public decimal? BondPurchase { get; set; }
        [Display(Name = "Bond Current")]
        public decimal? BondCurrent { get; set; }
        [Display(Name = "Embondcnt")]
        public decimal? Embondcnt { get; set; }
        [Display(Name = "Rate")]
        public decimal? Rate { get; set; }
        [Display(Name = "Emsftabl")]
        public string Emsftabl { get; set; }
        [Display(Name = "Saif")]
        public decimal? Saif { get; set; }
        [Display(Name = "Filled")]
        public decimal? Filled { get; set; }
        [Display(Name = "Percent")]
        public decimal? Percent { get; set; }
        [Display(Name = "Longevity")]
        public decimal? Longevity { get; set; }
        [Display(Name = "Fica Exempt")]
        public decimal? FicaExempt { get; set; }
        [Display(Name = "Fica Code")]
        public decimal? FicaCode { get; set; }
        [Display(Name = "Emp JobCode")]
        public string EmpJobCode { get; set; }
        [Display(Name = "Table")]
        public string Table { get; set; }
        [Display(Name = "Grade")]
        public string Grade { get; set; }
        [Display(Name = "Step")]
        public string Step { get; set; }
        [Display(Name = "Bargaining Unit")]
        public string BargainingUnit { get; set; }
        [Display(Name = "Merit Flag")]
        public string MeritFlag { get; set; }
        [Display(Name = "Type")]
        public decimal? Type { get; set; }
        [Display(Name = "Flsa")]
        public string Flsa { get; set; }

        [Display(Name = "Gross Pay")]
        public decimal? YearlyGrossPay { get; set; }

        [Display(Name = "Gross Deferred")]
        public decimal? YearlyGrossPayDeferred { get; set; }

        [Display(Name = "Non Taxable")]
        public decimal? YearlyNonTaxable { get; set; }

        [Display(Name = "Taxable")]
        public decimal? YearlyTaxable { get; set; }

        [Display(Name = "Fica Gross")]
        public decimal? YearlyFicaGross { get; set; }

        [Display(Name = "Federal WH")]
        public decimal? YearlyFederalWithholding { get; set; }

        [Display(Name = "Stat WH")]
        public decimal? YearlyStatWithholding { get; set; }

        [Display(Name = "Fica")]
        public decimal? YearlyFica { get; set; }

        public decimal? YearlyFicaBenefit { get; set; }
        public decimal? YearlyMedicalGross { get; set; }

        [Display(Name = "FICM")]
        public decimal? YearlyMedical { get; set; }

        public decimal? YearlyMedicalBenefit { get; set; }
        public decimal? YearlyTaxableBenefit { get; set; }

        [Display(Name = "Net Pay")]
        public decimal? YearlyNetPay { get; set; }

        [Display(Name = "Total Pay")]
        public decimal? YearlyTotalPay { get; set; }
        [Display(Name = "Retirement Gross")]
        public decimal? YearlyRetirementGross { get; set; }
        [Display(Name = "Retirement")]
        public decimal? YearlyRetirement { get; set; }
        [Display(Name = "Retirement Benefit Employee")]
        public decimal? YearlyRetirementBenefitEmployee { get; set; }
        [Display(Name = "Retirement Benefit Employer")]
        public decimal? YearlyRetirementBenefitEmployer { get; set; }

        [Display(Name = "SSN")]
        public string SSNumberDisplay => this.Ssnumber?.MaskSSN();
    }
}