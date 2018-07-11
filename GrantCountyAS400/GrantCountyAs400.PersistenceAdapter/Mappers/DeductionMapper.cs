using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class DeductionMapper
    {
        internal static Deduction Map(AcctEmployeeMiscDeductions deduction) =>
            new Deduction(deduction.Id, (int)deduction.MiscYear.Value, deduction.EmployeeNumber.Value, deduction.MiscCode,
                deduction.MiscDeduction.Value, deduction.MiscBenefit.Value);
    }
}