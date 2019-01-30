using System;

namespace GrantCountyAs400.Domain.Treasurer
{
    public class ExciseTaxRate
    {
        public int Id { get; }
        public string RecordTypeStateLocal { get; }
        public string AreaCode { get; }
        public decimal? EffectiveCode { get; }
        public string Description { get; }
        public decimal? TaxRate { get; }
        public decimal? PenaltyRate { get; }
        public decimal? PenaltyRate2 { get; }
        public decimal? PenaltyRate3 { get; }
        public decimal? InterestRate { get; }
        public string InterestMethod { get; }
        public string ChangeUserId { get; }
        public DateTime? ChangeDate { get; }
        public decimal? AdministrativeFeePercent { get; }

        public ExciseTaxRate(int id, string recordTypeStateLocal, string areaCode, decimal? effectiveCode, string description, decimal? taxRate, decimal? penaltyRate, decimal? penaltyRate2, decimal? penaltyRate3, decimal? interestRate, string interestMethod, string changeUserId, DateTime? changeDate, decimal? administrativeFeePercent)
        {
            Id = id;
            RecordTypeStateLocal = recordTypeStateLocal;
            AreaCode = areaCode;
            EffectiveCode = effectiveCode;
            Description = description;
            TaxRate = taxRate;
            PenaltyRate = penaltyRate;
            PenaltyRate2 = penaltyRate2;
            PenaltyRate3 = penaltyRate3;
            InterestRate = interestRate;
            InterestMethod = interestMethod;
            ChangeUserId = changeUserId;
            ChangeDate = changeDate;
            AdministrativeFeePercent = administrativeFeePercent;
        }
    }
}