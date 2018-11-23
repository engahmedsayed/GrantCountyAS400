using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer
{
    internal static class TaxReceivableMapper
    {
        internal static TaxReceivable Map(TreasPropertyMasterInfoView treasurerProperty)
            => new TaxReceivable(
                treasurerProperty.Id, treasurerProperty.ParcelNumber, treasurerProperty.ParentParcelNumber, treasurerProperty.TaxpayerCode, treasurerProperty.TitleOwnerCode,
                treasurerProperty.TaxCodeArea, treasurerProperty.LandUseCode, treasurerProperty.TaxpayerName.Trim(), treasurerProperty.TitleOwnerName.Trim());

        internal static TaxReceivableDetails Map(
            TreasPropertyMasterInfoView taxReceivable,
            IEnumerable<PropertyTaxReceivable> propertyTaxReceivables)
                => new TaxReceivableDetails(
                    taxReceivable.Id, taxReceivable.ParcelNumber, taxReceivable.TaxCodeArea, taxReceivable.TaxpayerCode, taxReceivable.TaxpayerName.Trim(),
                    propertyTaxReceivables);

        internal static SpecialAssessmentTaxReceivable Map(TreasspecialAssessmentsTaxReceivableMaster specialTaxReceivable)
            => new SpecialAssessmentTaxReceivable(specialTaxReceivable.AssessmentAmount, specialTaxReceivable.PenaltyAmount, specialTaxReceivable.InterestPaid);

        internal static PropertyTaxReceivable Map(
            TreasallPropertyTaxReceivableMaster propertyTaxReceivable,
            IEnumerable<TreasspecialAssessmentsTaxReceivableMaster> specialAssessmentTaxReceivables,
            IEnumerable<PropertyTaxReceivableTransaction> transactions)
                => new PropertyTaxReceivable(
                    propertyTaxReceivable.ParcelExtension, (int)propertyTaxReceivable.TaxYear.Value, propertyTaxReceivable.TaxAmount,
                    specialAssessmentTaxReceivables.Select(Map), transactions);

        internal static SpecialAssessmentTransaction Map(TreasspecialAssessmentsTransactions specialTransaction)
            => new SpecialAssessmentTransaction(specialTransaction.AssessmentPaid, specialTransaction.PenaltyPaid, specialTransaction.InterestPaid);

        internal static PropertyTaxReceivableTransaction Map(
            TreasallPropertyTaxReceivableTransactions propertyTransaction,
            IEnumerable<TreasspecialAssessmentsTransactions> specialTransactions)
                => new PropertyTaxReceivableTransaction(
                    propertyTransaction.ParcelExtension, propertyTransaction.TaxAmount, propertyTransaction.TaxYear.Value, propertyTransaction.TranDate,
                    propertyTransaction.ReceiptTranNumber, propertyTransaction.ChgReasonCd, propertyTransaction.TranTypeCd, propertyTransaction.InterestPaid,
                    propertyTransaction.LPamount, specialTransactions.Select(Map));
    }
}