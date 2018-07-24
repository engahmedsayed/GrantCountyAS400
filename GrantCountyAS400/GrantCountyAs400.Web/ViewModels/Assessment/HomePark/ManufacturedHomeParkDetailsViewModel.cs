using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.HomePark
{
    public class ManufacturedHomeParkDetailsViewModel
    {
        [Display(Name = "M/H Park Code")]
        public string MhparkCode { get; set; }

        [Display(Name = "M/H Park Name")]
        public string Name { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "Contact Code")]
        public string ContactNameCode { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Display(Name = "Telephone #")]
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
        public string TelephoneNumber { get; set; }

        [Display(Name = "Assoc R/P")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Old Code")]
        public string Filler01 { get; set; }

        [Display(Name = "# of Spaces")]
        public decimal SpaceNumber { get; set; }

        [Display(Name = "Quality")]
        public string QualCode { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }

        public string TelephoneNumberDisplay =>
            // this to match empty string or strigs with only zeros (like 0000000000)
            string.IsNullOrWhiteSpace(TelephoneNumber) || string.IsNullOrWhiteSpace(TelephoneNumber.Replace("0", "")) ?
                    "" : string.Format("{0:(###) ###-####}", double.Parse(TelephoneNumber));
    }
}