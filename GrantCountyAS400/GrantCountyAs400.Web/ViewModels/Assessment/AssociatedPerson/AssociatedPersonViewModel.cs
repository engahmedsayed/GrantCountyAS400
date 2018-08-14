using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson
{
    public class AssociatedPersonViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Parcel #")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayer { get; set; }

        [Display(Name = "Owner")]
        public string Owner { get; set; }

        [Display(Name ="Desc")]
        public string Description { get; set; }

        [Display(Name = "Land Use")]
        public string LandUse { get; set; }

        [Display(Name ="Second Desc")]
        public string SecondDescription { get; set; }

        [Display(Name = "Third Desc")]
        public string ThirdDescription { get; set; }

        [Display(Name = "Fourth  Desc")]
        public string FourthDescrition { get; set; }

        [Display (Name = "Fifth Desc")]
        public string FifthDescription { get; set; }

        [Display(Name ="Line Date")]
        [DataType(DataType.Date)]
        public DateTime? LineDate { get; set; }

        [Display(Name ="AF #")]
        public decimal? AffidavitNumber { get; set; }

        [Display(Name ="Zoning")]
        public string ZoneCodeDescr { get; set; }

        [Display(Name ="Tax Dists")]
        public string TaxCodeDesc { get; set; }

        [Display(Name ="FP AC")]
        public decimal? FirePatrolAcres { get; set; }

        public decimal? UnImprovedLandAcres { get; set; }

        public decimal? ImprovedLandAcres { get; set; }

        [Display(Name ="Tot Ac")]
        public decimal? TotalAcres { get { return UnImprovedLandAcres + ImprovedLandAcres; } }

        [Display(Name ="Ld Av")]
        public decimal? FMImprovedLandValue { get; set; }

        [Display(Name ="Im AV")]
        public decimal? BuildingValue { get; set; }

        [Display(Name ="As-Tx Yr")]
        public decimal? AffidavitTaxYear { get; set; }
        public List<LineValueViewModel> LineValues { get; set; }

        [Display(Name ="Name #")]
        public string NameCode { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }



        public string AddressLine1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public string Zip { get; set; }

        public string LocalAddress { get { return City + "," + State + " " + Zip; } }

        public string ChangeId { get; set; }

        public DateTime? ChangeDate { get; set; }

    }

}
