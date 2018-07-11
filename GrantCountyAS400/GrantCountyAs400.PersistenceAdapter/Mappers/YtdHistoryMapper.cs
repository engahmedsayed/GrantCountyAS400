using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class YtdHistoryMapper
    {
        internal static YtdHistory Map(AcctEmployeeYtdhistory record) =>
            new YtdHistory(record.Id, (int)record.Year.Value, record.Group.Value, record.Name, record.Number, record.Fund.Value, record.Department.Value,
                record.YearlyGrossPay.Value, record.YearlyGrossPayDeferred.Value, record.YearlyNonTaxable.Value, record.YearlyTaxable.Value,
                record.YearlyFicaGross.Value, record.YearlyFederalWithholding.Value, record.YearlyStatWithholding.Value, record.YearlyFica.Value,
                record.YearlyFicaBenefit.Value, record.YearlyMedicalGross.Value, record.YearlyMedical.Value, record.YearlyMedicalBenefit.Value,
                record.YearlyTaxableBenefit.Value, record.YearlyNetPay.Value, record.YearlyTotalPay.Value, record.YearlyRetirementGross.Value,
                record.YearlyRetirement.Value, record.YearlyRetirementBenefitEmployee.Value, record.YearlyRetirementBenefitEmployer.Value);
    }
}