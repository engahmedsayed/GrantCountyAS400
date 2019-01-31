using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.ExciseTaxRate
{
    public class ExciseTaxRateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Record Type")]
        public string RecordTypeStateLocal { get; set; }
        public string AreaCode { get; set; }
        [Display(Name = "Effective Code")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal? EffectiveCode { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Rate")]
        public decimal? TaxRate { get; set; }
        [Display(Name = "Penalty Rate 1")]
        public decimal? PenaltyRate { get; set; }
        [Display(Name = "Penalty Rate 2")]
        public decimal? PenaltyRate2 { get; set; }
        [Display(Name = "Penalty Rate 3")]
        public decimal? PenaltyRate3 { get; set; }
        [Display(Name = "Interest Rate")]
        public decimal? InterestRate { get; set; }
        public string InterestMethod { get; set; }
        [Display(Name = "Change User")]
        public string ChangeUserId { get; set; }
        [Display(Name = "Change Date")]
        [DataType(DataType.Date)]
        public DateTime? ChangeDate { get; set; }
        public decimal? AdministrativeFeePercent { get; set; }
    }
}