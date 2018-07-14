using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class YtdHistoryViewModel
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public decimal Group { get; set; }
        public string Name { get; set; }
        public decimal Number { get; set; }
        public decimal Fund { get; set; }
        public decimal Department { get; set; }

        [Display(Name = "Gross Pay")]
        public decimal YearlyGrossPay { get; set; }

        [Display(Name = "Gross Pay Deferred")]
        public decimal YearlyGrossPayDeferred { get; set; }

        [Display(Name = "Non Taxable")]
        public decimal YearlyNonTaxable { get; set; }

        [Display(Name = "Taxable")]
        public decimal YearlyTaxable { get; set; }

        [Display(Name = "Fica Gross")]
        public decimal YearlyFicaGross { get; set; }

        [Display(Name = "Federal With Holding")]
        public decimal YearlyFederalWithholding { get; set; }

        [Display(Name = "Stat With Holding")]
        public decimal YearlyStatWithholding { get; set; }

        public decimal YearlyFica { get; set; }
        public decimal YearlyFicaBenefit { get; set; }
        public decimal YearlyMedicalGross { get; set; }
        public decimal YearlyMedical { get; set; }
        public decimal YearlyMedicalBenefit { get; set; }
        public decimal YearlyTaxableBenefit { get; set; }
        public decimal YearlyNetPay { get; set; }
        public decimal YearlyTotalPay { get; set; }
        public decimal YearlyRetirementGross { get; set; }
        public decimal YearlyRetirement { get; set; }
        public decimal YearlyRetirementBenefitEmployee { get; set; }
        public decimal YearlyRetirementBenefitEmployer { get; set; }
    }
}