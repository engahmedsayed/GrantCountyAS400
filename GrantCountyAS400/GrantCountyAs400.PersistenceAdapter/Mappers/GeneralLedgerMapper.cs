using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class GeneralLedgerMapper
    {
        internal static GeneralLedger Map(AcctGeneralLedger generalLedger, AcctChartOfAccounts acctChartOfAccountsView)
            => new GeneralLedger($"{generalLedger.Fund}-" +
                $"{generalLedger.Department.Trim().Substring(0,3) + "-" + generalLedger.Department.Trim().Substring((generalLedger.Department.Trim().Length/2),generalLedger.Department.Trim().Length/2)}" +
                $"-{generalLedger.Program}-{GetProjectAndBaseFormatted(generalLedger.Project,generalLedger.Base)}", 
                acctChartOfAccountsView?.AcctDescription,generalLedger.RecordType == "D" ? "Detail" : "Summary", !string.IsNullOrWhiteSpace
                (generalLedger.Base) && generalLedger.Base.StartsWith('1') ? "Asset" : generalLedger.Base.StartsWith('2')
                ? "Liability" : generalLedger.Base.StartsWith('3') ? "Revenue" : "Expense", 
                generalLedger.RecordStatus,generalLedger.Base,generalLedger.Fund,generalLedger.Department,generalLedger.Program,
                generalLedger.Project,generalLedger.FiscalYear);

        internal static GeneralLedgerDetailItem Map(AcctGlperiodAmounts pa) =>
                                                                                new GeneralLedgerDetailItem(pa.Month, pa.Year,
                                                                                pa.Budget, pa.Encumbrance, pa.PendingEncumbrance, pa.Action,pa.Fund,pa.Department,pa.Program,pa.Project,pa.Base);

        internal static GeneralLedgerMonthDetail Map(AcctGltransactions glt) => new GeneralLedgerMonthDetail(glt.Jenumber, glt.Line,
                                                                                (int)glt.Month, (int)glt.Year, glt.TransactionDate,
                                                                                glt.Status.Trim().ToUpper() == "P" ? "Posted"
                                                                                : glt.Status.Trim().ToUpper() == "N" ? "Non Post" : "",
                                                                                glt.Source, glt.Notation1, glt.Kind.Trim().ToUpper() == "B" ? "Beg" :
                                                                                glt.Kind.Trim().ToUpper() == "E" ? "Enc" :
                                                                                glt.Kind.Trim().ToUpper() == "G" ? "Actv" : "",
                                                                                glt.Amount,glt.Base);

        private static string GetProjectAndBaseFormatted(string project,string @base)
        {
            if(project.StartsWith("3") || project.StartsWith("5"))
            {
                return project + "." + @base.Substring(0, 2) + "." + @base.Substring(2, 2) + "." + @base.Substring(4, 2);
            }
            return project + "." + @base.Substring(0, 2);
        }
    }
}
