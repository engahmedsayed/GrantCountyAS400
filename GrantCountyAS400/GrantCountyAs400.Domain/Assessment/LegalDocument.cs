using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment
{
    public class RealPropertyLegalDocument
    {
        public decimal ParcelNumber { get; }
        public string TaxPayerCode { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerCode { get; }
        public string TitleOwnerName { get; }
        public string ContractHolderCode { get; }
        public string ContractHolderName { get; }
        public string LoanNumber { get; }
        public decimal BuildingValue { get; }
        public decimal ImprovedLandValue { get; }
        public decimal LandUseCode { get; }
        public decimal TaxYear { get; }
        public decimal TaxCodeArea { get; }
        public string TaxCodeDesc { get; }
        public string UseCodeShortDesc { get; }
        public decimal AssessedValue { get; }
        public decimal RPsalesAmount { get; }
        public decimal PPsalesAmount { get; }

        public IEnumerable<LegalDocument> LegalDocuments { get; }

        public RealPropertyLegalDocument(decimal parcelNumber, string taxPayerCode, string taxPayerName, string titleOwnerCode, string titleOwnerName,
            string contractHolderCode, string contractHolderName, string loanNumber, decimal improvedLandValue, decimal buildingValue, decimal landUseCode, decimal taxYear,
            decimal taxCodeArea, string taxCodeDesc, string useCodeShortDesc, decimal assessedValue, decimal rpSalesAmount, decimal ppSalesAmount,
            IEnumerable<LegalDocument> legalDocuments)
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
            ImprovedLandValue = improvedLandValue;
            LandUseCode = landUseCode;
            TaxYear = taxYear;
            TaxCodeArea = taxCodeArea;
            TaxCodeDesc = taxCodeDesc;
            AssessedValue = assessedValue;
            RPsalesAmount = rpSalesAmount;
            PPsalesAmount = ppSalesAmount;

            LegalDocuments = legalDocuments;
        }
    }

    public class LegalDocument
    {
        public int Id { get; }
        public decimal ParcelNumber { get; }
        public DateTime? LegalInstrumentDate { get; }
        public string LegalDocumentType { get; }
        public string PreviousOwnerSeller { get; }
        public decimal Volume { get; }
        public decimal Page { get; }
        public decimal AffidavitNumber { get; }
        public string AffidavitNumberExtension { get; }

        public LegalDocument(int id, decimal parcelNumber, DateTime? legalInstrumentDate, string legalDocumentType, string previousOwnerSeller, decimal volume,
            decimal page, decimal affidavitNumber, string affidavitNumberExtension)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            LegalInstrumentDate = legalInstrumentDate;
            LegalDocumentType = legalDocumentType;
            PreviousOwnerSeller = previousOwnerSeller;
            Volume = volume;
            Page = page;
            AffidavitNumber = affidavitNumber;
            AffidavitNumberExtension = affidavitNumberExtension;
        }
    }
}