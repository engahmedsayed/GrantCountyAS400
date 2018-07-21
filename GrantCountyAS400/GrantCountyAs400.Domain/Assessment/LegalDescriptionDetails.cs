using System;

namespace GrantCountyAs400.Domain.Assessment
{
    public class LegalDescriptionDetails
    {
        private int Id { get; }
        public decimal ParcelNumber { get; }
        public string LegalDescrtiption { get; }
        public string Description1 { get; }
        public string Description2 { get; }
        public string Description3 { get; }
        public string Description4 { get; }
        public string Description5 { get; }
        public string TaxStatus { get; }
        public string ChangeId { get; }
        public DateTime ChangeDate { get; }

        public LegalDescriptionDetails(int id, decimal parcelNumber, string legalDescrtiption, string description1, string description2,
            string description3, string description4, string description5, string taxStatus, string changeId, DateTime changeDate)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            LegalDescrtiption = legalDescrtiption;
            Description1 = description1;
            Description2 = description2;
            Description3 = description3;
            Description4 = description4;
            Description5 = description5;
            TaxStatus = taxStatus;
            ChangeId = changeId;
            ChangeDate = changeDate;
        }
    }
}