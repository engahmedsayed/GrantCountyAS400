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
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? Group { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Number")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal Number { get; set; }
        public decimal? Ssnumber { get; set; }
        [Display(Name = "Count")]
        public decimal? Count { get; set; }
        [Display(Name = "Fund")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? Fund { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "Department")]
        public decimal? Department { get; set; }
        [Display(Name = "Retirement Number")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? RetirementNumber { get; set; }
        [Display(Name = "Retirement Flag")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? RetirementFlag { get; set; }
        [Display(Name = "Retirement Code")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? RetirementCode { get; set; }
        [Display(Name = "Pay Code")]
        public string PayCode { get; set; }
        [Display(Name = "Pay Status")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? PayStatus { get; set; }
        [Display(Name = "Bond Type")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? BondType { get; set; }
        [Display(Name = "Bond Purchase")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? BondPurchase { get; set; }
        [Display(Name = "Bond Current")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? BondCurrent { get; set; }
        [Display(Name = "Embondcnt")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? Embondcnt { get; set; }
        [Display(Name = "Rate")]
        [DisplayFormat(DataFormatString = "{0:0.0000}")]
        public decimal? Rate { get; set; }
        [Display(Name = "Emsftabl")]
        public string Emsftabl { get; set; }
        [Display(Name = "Saif")]
        public decimal? Saif { get; set; }
        [Display(Name = "Filled")]
        [DisplayFormat(DataFormatString = "{0:0.0000}")]
        public decimal? Filled { get; set; }
        [Display(Name = "Percent")]
        [DisplayFormat(DataFormatString = "{0:0.0000}")]
        public decimal? Percent { get; set; }
        [Display(Name = "Longevity")]
        [DisplayFormat(DataFormatString = "{0:0.0000}")]
        public decimal? Longevity { get; set; }
        [Display(Name = "Fica Exempt")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? FicaExempt { get; set; }
        [Display(Name = "Fica Code")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
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
        [DisplayFormat(DataFormatString = "{0:n0}")]
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