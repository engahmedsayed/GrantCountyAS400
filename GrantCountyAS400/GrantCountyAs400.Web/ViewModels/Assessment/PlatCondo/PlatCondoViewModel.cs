using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.PlatCondo
{
    public class PlatCondoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Code")]
        public string PlatCode { get; set; }

        [Display(Name = "Code Type")]
        public string PlatCodeType { get; set; }

        [Display(Name = "Plat Name")]
        public string PlatNameDesc { get; set; }

        [Display(Name = "Plat Date")]
        [DataType(DataType.Date)]
        public DateTime? PlatDate { get; set; }

        [Display(Name = "Township")]
        public decimal Township { get; set; }

        [Display(Name = "Range")]
        public decimal Range { get; set; }

        [Display(Name = "Section")]
        public decimal Section { get; set; }

        [Display(Name = "Book")]
        public decimal Volume { get; set; }

        [Display(Name = "Page")]
        public decimal Page { get; set; }

        [Display(Name = "Field Book")]
        public decimal FieldBook { get; set; }

        [Display(Name = "Reval Code")]
        public string RevalutionPhase { get; set; }

        [Display(Name = "Appraiser Code")]
        public string AppraiserCode { get; set; }

        [Display(Name = "Hanger No.")]
        public string HangerNumber { get; set; }

        public string CommentLine1 { get; set; }
        public string CommentLine2 { get; set; }
        public string CommentLine3 { get; set; }
        public string CommentLine4 { get; set; }
        public string CommentLine5 { get; set; }
    }
}