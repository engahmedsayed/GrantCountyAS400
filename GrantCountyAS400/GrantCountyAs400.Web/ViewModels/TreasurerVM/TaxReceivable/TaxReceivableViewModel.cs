using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable
{
    public class TaxReceivableViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal? ParcelNumber { get; set; }
        public decimal? ParentParcelNumber { get; set; }
        [Display(Name = "Tax Payer Code")]
        public string TaxpayerCode { get; set; }
        [Display(Name = "Title Owner Code")]
        public string TitleOwnerCode { get; set; }
        [Display(Name = "Tax Code Area")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? TaxCodeArea { get; set; }
        public decimal? LandUseCode { get; set; }
        [Display(Name = "Tax Payer Name")]
        public string TaxpayerName { get; set; }
        [Display(Name = "Title Owner")]
        public string TitleOwnerName { get; set; }

        public string ParcelTypeDisplay => (ParcelNumber < 9_999_999) ? "P" : "R";
    }
}