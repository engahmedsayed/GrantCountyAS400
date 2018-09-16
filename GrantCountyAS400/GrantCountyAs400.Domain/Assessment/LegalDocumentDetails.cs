using System;

namespace GrantCountyAs400.Domain.Assessment
{
    public class LegalDocumentDetails
    {
        public decimal ParcelNumber { get; }
        public string TaxPayerCode { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerCode { get; }
        public string TitleOwnerName { get; }
        public string ContractHolderCode { get; }
        public string ContractHolderName { get; }
        public decimal LandUseCode { get; }
        public string LoanNumber { get; }
        public decimal BuildingValue { get; }
        public decimal UnimprovedLandValue { get; }
        public decimal ImprovedLandValue { get; }

        public DateTime? LegalInstrumentDate { get; }
        public string LegalDocumentType { get; }
        public string PreviousOwnerSeller { get; }
        public decimal Volume { get; }
        public decimal Page { get; }
        public decimal AffidavitNumber { get; }
        public string AffidavitNumberExtension { get; }
        public decimal AuditorFileNumber { get; }
        public string LegalDocumentComment { get; }
        public string ChangeId { get; }
        public DateTime ChangeDate { get; }
        public decimal AssocateParcelNumber { get; }
        public decimal ProbateNumber { get; }

        public decimal RPsalesAmount { get; }
        public decimal PPsalesAmount { get; }
        public string MultipleParcelSale { get; }
        public decimal SaleRejectionCode { get; }
        public string TaxDataComment { get; }
        public decimal PersPropParcel { get; }
        public string IncorporatedArea { get; }
        public decimal AssessedValue { get; }
        public decimal TaxYear { get; }
        public DateTime? SaleDate { get; }

        public string UseCodeShortDesc { get; }

        public string TaxCodeDesc { get; }
        public decimal TaxCodeArea { get; }

        public string InstrumentTypeDescription { get; }

        public string RejectionReasonCodeComment { get; }

        public LegalDocumentDetails(decimal parcelNumber, string taxPayerCode, string taxPayerName, string titleOwnerCode, string titleOwnerName, string contractHolderCode,
            string contractHolderName, string loanNumber, decimal buildingValue, decimal landUseCode, decimal unimprovedLandValue, decimal improvedLandValue,
            DateTime? legalInstrumentDate, string legalDocumentType, string previousOwnerSeller, decimal volume, decimal page, decimal affidavitNumber, string affidavitNumberExtension,
            decimal auditorFileNumber, string legalDocumentComment, string changeId, DateTime changeDate, decimal assocateParcelNumber, decimal probateNumber, decimal rpSalesAmount,
            decimal ppSalesAmount, string multipleParcelSale, decimal saleRejectionCode, string taxDataComment, decimal persPropParcel, string incorporatedArea, decimal assessedValue,
            decimal taxYear, DateTime? saleDate, decimal taxCodeArea, string taxCodeDesc, string useCodeShortDesc, string instrumentTypeDescription, string rejectionReasonCodeComment)
        {
            ParcelNumber = parcelNumber;
            TaxPayerCode = taxPayerCode;
            TaxPayerName = taxPayerName;
            TitleOwnerCode = titleOwnerCode;
            TitleOwnerName = titleOwnerName;
            ContractHolderCode = contractHolderCode;
            ContractHolderName = contractHolderName;
            LoanNumber = loanNumber;
            BuildingValue = buildingValue;
            LandUseCode = landUseCode;
            UnimprovedLandValue = unimprovedLandValue;
            ImprovedLandValue = improvedLandValue;
            LegalInstrumentDate = legalInstrumentDate;
            LegalDocumentType = legalDocumentType;
            PreviousOwnerSeller = previousOwnerSeller;
            Volume = volume;
            Page = page;
            AffidavitNumber = affidavitNumber;
            AffidavitNumberExtension = affidavitNumberExtension;
            AuditorFileNumber = auditorFileNumber;
            LegalDocumentComment = legalDocumentComment;
            ChangeId = changeId;
            ChangeDate = changeDate;
            AssocateParcelNumber = assocateParcelNumber;
            ProbateNumber = probateNumber;
            TaxCodeArea = taxCodeArea;
            RPsalesAmount = rpSalesAmount;
            PPsalesAmount = ppSalesAmount;
            MultipleParcelSale = multipleParcelSale;
            SaleRejectionCode = saleRejectionCode;
            TaxDataComment = taxDataComment;
            PersPropParcel = persPropParcel;
            IncorporatedArea = incorporatedArea;
            AssessedValue = assessedValue;
            TaxYear = taxYear;
            SaleDate = saleDate;
            TaxCodeDesc = taxCodeDesc;
            UseCodeShortDesc = useCodeShortDesc;
            InstrumentTypeDescription = instrumentTypeDescription;
            RejectionReasonCodeComment = rejectionReasonCodeComment;
        }
    }
}