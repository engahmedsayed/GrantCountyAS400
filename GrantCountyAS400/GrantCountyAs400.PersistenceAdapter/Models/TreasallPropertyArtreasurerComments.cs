using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasallPropertyArtreasurerComments
    {
        public int Id { get; set; }
        public string RecCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? ParcelExtension { get; set; }
        public string Filler01 { get; set; }
        public string CommentLine1 { get; set; }
        public string CommentLine2 { get; set; }
        public decimal? PPparcelNumber { get; set; }
        public decimal? PPprcExt { get; set; }
        public string Filler02 { get; set; }
        public string ChangeUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
