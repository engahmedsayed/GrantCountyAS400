using System;

namespace GrantCountyAs400.Domain.Assessment
{
    public class PlatCondo
    {
        public int Id { get; }
        public string PlatCode { get; }
        public string PlatCodeType { get; }
        public string PlatNameDesc { get; }
        public DateTime? PlatDate { get; }
        public decimal Township { get; }
        public decimal Range { get; }
        public decimal Section { get; }
        public decimal Volume { get; }
        public decimal Page { get; }
        public decimal FieldBook { get; }
        public string RevalutionPhase { get; }
        public string AppraiserCode { get; }
        public string HangerNumber { get; }
        public string CommentLine1 { get; }
        public string CommentLine2 { get; }
        public string CommentLine3 { get; }
        public string CommentLine4 { get; }
        public string CommentLine5 { get; }

        public PlatCondo(int id, string platCode, string platCodeType, string platName, DateTime? platDate, decimal township, decimal range,
            decimal section, decimal volume, decimal page, decimal fieldBook, string revalutionPhase, string appraiserCode, string hangerNumber,
            string commentLine1, string commentLine2, string commentLine3, string commentLine4, string commentLine5)
        {
            Id = id;
            PlatCode = platCode;
            PlatCodeType = platCodeType;
            PlatNameDesc = platName;
            PlatDate = platDate;
            Township = township;
            Range = range;
            Section = section;
            Volume = volume;
            Page = page;
            fieldBook = FieldBook;
            RevalutionPhase = revalutionPhase;
            AppraiserCode = appraiserCode;
            HangerNumber = hangerNumber;
            CommentLine1 = commentLine1;
            CommentLine2 = commentLine2;
            CommentLine3 = commentLine3;
            CommentLine4 = commentLine4;
            CommentLine5 = commentLine5;
        }
    }
}