using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable
{
    public class TreasurerMasterViewModel
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
        public decimal? TaxCodeArea { get; set; }
        public decimal? LandUseCode { get; set; }
        [Display(Name = "Tax Payer Name")]
        public string TaxpayerName { get; set; }
    }
}