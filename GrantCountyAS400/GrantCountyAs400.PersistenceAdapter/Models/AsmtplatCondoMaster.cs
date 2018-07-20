using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtplatCondoMaster
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public string PlatCodeType { get; set; }
        public string PlatCode { get; set; }
        public string PlatNameDesc { get; set; }
        public string PlatAbbreviation { get; set; }
        public DateTime? PlatDate { get; set; }
        public decimal? Township { get; set; }
        public decimal? Range { get; set; }
        public decimal? Section { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Page { get; set; }
        public string CommentLine1 { get; set; }
        public string CommentLine2 { get; set; }
        public string CommentLine3 { get; set; }
        public string CommentLine4 { get; set; }
        public string CommentLine5 { get; set; }
        public decimal? Acres { get; set; }
        public string HangerNumber { get; set; }
        public string ChangeId { get; set; }
        public string RevalutionPhase { get; set; }
        public string AppraiserCode { get; set; }
        public decimal? FieldBook { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
