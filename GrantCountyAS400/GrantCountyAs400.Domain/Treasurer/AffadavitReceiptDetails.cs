using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Treasurer
{
    public class AffadavitReceiptDetails
    {
        public int Id { get; }
        public int TransactionYear { get; }
        public decimal ReceiptNumber { get; }
        public decimal? TotalPaid { get; }
        public decimal? AffadavitNumber { get; }
        public DateTime? AffidavitDate { get; }
        public decimal? ParcelNumber { get; }
        public string LegalDocumentType { get; }
        public DateTime? DocumentDate { get; }
        public decimal? TaxCodeArea { get; }
        public string TaxStatus { get; }

        public DateTime? ReceiptDate { get; }
        public string TaxCodeDesc { get; }

        public IEnumerable<AffadavitReceiptParcel> AffadavitReceiptParcels { get; }

        public AffadavitReceiptDetails(
            int id, int transactionYear, decimal receiptNumber, decimal? totalPaid, decimal? affadavitNumber, DateTime? affidavitDate, decimal? parcelNumber,
            string legalDocumentType, DateTime? documentDate, decimal? taxCodeArea, string taxStatus, DateTime? receiptDate, string taxCodeDesc)
        {
            Id = id;
            TransactionYear = transactionYear;
            ReceiptNumber = receiptNumber;
            TotalPaid = totalPaid;
            AffadavitNumber = affadavitNumber;
            AffidavitDate = affidavitDate;
            ParcelNumber = parcelNumber;
            LegalDocumentType = legalDocumentType;
            DocumentDate = documentDate;
            TaxCodeArea = taxCodeArea;
            TaxStatus = taxStatus;
            ReceiptDate = receiptDate;
            TaxCodeDesc = taxCodeDesc;
        }

        public AffadavitReceiptDetails(
            int id, int transactionYear, decimal receiptNumber, decimal? totalPaid, decimal? affadavitNumber, DateTime? affidavitDate, decimal? parcelNumber,
            string legalDocumentType, DateTime? documentDate, decimal? taxCodeArea, string taxStatus, DateTime? receiptDate, string taxCodeDesc,
            IEnumerable<AffadavitReceiptParcel> affadavitReceiptParcels)
            : this(id, transactionYear, receiptNumber, totalPaid, affadavitNumber, affidavitDate, parcelNumber, legalDocumentType, documentDate, taxCodeArea, taxStatus,
                  receiptDate, taxCodeDesc)
        {
            AffadavitReceiptParcels = affadavitReceiptParcels;
        }
    }

    public class AffadavitReceiptParcel
    {
        public int Id { get; }
        public decimal? ParcelNumber { get; }
        public decimal? AffadavitNumber { get; }
        public string NewOwnerBuyer { get; }
        public string PreviousOwnerSeller { get; }
        public decimal? TaxAmount { get; }
        public decimal? TotalPaid { get; }
        public decimal? StateTaxPaid { get; }
        public decimal? AssessedValue { get; }
        public decimal? PPvalue { get; }
        public decimal? GiftDebt { get; }
        public decimal? LocalTaxPaid { get; }
        public decimal? StatePenalty { get; }
        public decimal? LocalPenalty { get; }
        public decimal? LocalInterest { get; }
        public decimal? TechnicalFee { get; }
        public decimal? SubsidizedFee { get; }

        public decimal? UnimprovedLandValue { get; }
        public decimal? ImprovedLandValue { get; }
        public decimal? BuildingValue { get; }

        public string AddressLine1 { get; }
        public string City { get; }

        public string LegalDescription { get; }

        public AffadavitReceiptParcel(
            int id, decimal? parcelNumber, decimal? affadavitNumber, string newOwnerBuyer, string previousOwnerSeller, decimal? taxAmount, decimal? totalPaid,
            decimal? stateTaxPaid, decimal? assessedValue, decimal? pPvalue, decimal? giftDebt, decimal? localTaxPaid, decimal? statePenalty, decimal? localPenalty,
            decimal? localInterest, decimal? technicalFee, decimal? subsidizedFee, decimal? unimprovedLandValue, decimal? improvedLandValue, decimal? buildingValue,
            string addressLine1, string city, string legalDescription)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            AffadavitNumber = affadavitNumber;
            NewOwnerBuyer = newOwnerBuyer;
            PreviousOwnerSeller = previousOwnerSeller;
            TaxAmount = taxAmount;
            TotalPaid = totalPaid;
            StateTaxPaid = stateTaxPaid;
            AssessedValue = assessedValue;
            PPvalue = pPvalue;
            GiftDebt = giftDebt;
            LocalTaxPaid = localTaxPaid;
            StatePenalty = statePenalty;
            LocalPenalty = localPenalty;
            LocalInterest = localInterest;
            TechnicalFee = technicalFee;
            SubsidizedFee = subsidizedFee;
            UnimprovedLandValue = unimprovedLandValue;
            ImprovedLandValue = improvedLandValue;
            BuildingValue = buildingValue;
            AddressLine1 = addressLine1;
            City = city;
            LegalDescription = legalDescription;
        }
    }
}