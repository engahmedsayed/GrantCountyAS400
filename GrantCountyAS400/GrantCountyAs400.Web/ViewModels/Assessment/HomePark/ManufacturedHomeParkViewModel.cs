using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.HomePark
{
    public class ManufacturedHomeParkViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Code")]
        public string MhparkCode { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "Contact Code")]
        public string ContactNameCode { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName{ get; set; }

        [Display(Name = "Telephone #")]
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
        public string TelephoneNumber { get; set; }

        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        public string TelephoneNumberDisplay =>
            // this to match empty string or strigs with only zeros (like 0000000000)
            string.IsNullOrWhiteSpace(TelephoneNumber) || string.IsNullOrWhiteSpace(TelephoneNumber.Replace("0", "")) ?
                    "" : string.Format("{0:(###) ###-####}", double.Parse(TelephoneNumber));
    }
}