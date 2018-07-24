using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class GeneralLedgerMapper
    {
        internal static GeneralLedger Map(AcctGeneralLedger generalLedger, AccountChartOfAccountsView acctChartOfAccountsView)
            => new GeneralLedger($"{generalLedger.Department}-{generalLedger.Fund}-{generalLedger.Program}-{generalLedger.Project}-{generalLedger.Base}", acctChartOfAccountsView.AcctDescription,
                generalLedger.RecordType == "D" ? "Detail" : "Summary", !string.IsNullOrWhiteSpace
                (generalLedger.Base) && generalLedger.Base.StartsWith('1') ? "Asset" : generalLedger.Base.StartsWith('2')
                ? "Liability" : generalLedger.Base.StartsWith('3') ? "Revenue" : "Expense", generalLedger.RecordStatus,generalLedger.Base);

        internal static GeneralLedgerDetailItem Map(AcctGlperiodAmounts pa) =>
                                                                                new GeneralLedgerDetailItem(pa.Month, pa.Year,
                                                                                pa.Budget, pa.Encumbrance, pa.PendingEncumbrance, pa.Action,pa.Fund,pa.Department,pa.Program,pa.Project);

        internal static GeneralLedgerMonthDetail Map(AcctGltransactions glt) => new GeneralLedgerMonthDetail(glt.Jenumber, glt.Line,
                                                                                (int)glt.Month, (int)glt.Year, glt.TransactionDate,
                                                                                glt.Status.Trim().ToUpper() == "P" ? "Posted"
                                                                                : glt.Status.Trim().ToUpper() == "N" ? "Non Post" : "",
                                                                                glt.Source, glt.Notation1, glt.Kind.Trim().ToUpper() == "B" ? "Beg" :
                                                                                glt.Kind.Trim().ToUpper() == "E" ? "Enc" :
                                                                                glt.Kind.Trim().ToUpper() == "G" ? "Actv" : "",
                                                                                glt.Amount);
    }
}
