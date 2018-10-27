using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class YtdHistoryMapper
    {
        internal static YtdHistory Map(AcctEmployeeYtdhistory record) =>
            new YtdHistory(
                record.Id, (int)record.Year.Value, record.Group, record.Name, record.Number, record.Ssnumber, record.Count, record.Fund, record.Department,
                record.RetirementNumber, record.RetirementFlag, record.RetirementCode, record.PayCode, record.PayStatus, record.BondType, record.BondPurchase,
                record.BondCurrent, record.Embondcnt, record.Rate, record.Emsftabl, record.Saif, record.Filled, record.Percent, record.Longevity, record.FicaExempt,
                record.FicaCode, record.EmpJobCode, record.Table, record.Grade, record.Step, record.BargainingUnit, record.MeritFlag, record.Type, record.Flsa,
                record.YearlyGrossPay, record.YearlyGrossPayDeferred, record.YearlyNonTaxable, record.YearlyTaxable, record.YearlyFicaGross,
                record.YearlyFederalWithholding, record.YearlyStatWithholding, record.YearlyFica, record.YearlyFicaBenefit, record.YearlyMedicalGross,
                record.YearlyMedical, record.YearlyMedicalBenefit, record.YearlyTaxableBenefit, record.YearlyNetPay, record.YearlyTotalPay, record.YearlyRetirementGross,
                record.YearlyRetirement, record.YearlyRetirementBenefitEmployee, record.YearlyRetirementBenefitEmployer);
    }
}