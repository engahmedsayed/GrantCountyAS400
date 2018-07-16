using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class GeneralLedgerMapper
    {
        internal static GeneralLedger Map(AcctGeneralLedger generalLedger) => new GeneralLedger(string.Format("{0}-{1}-{2}-{3}-{4}", generalLedger.Fund, generalLedger.Department, generalLedger.Program, generalLedger.Project, generalLedger.Base), "", generalLedger.RecordType == "D" ? "detail" : "Summary", !string.IsNullOrWhiteSpace
            (generalLedger.Base) && generalLedger.Base.StartsWith('1') ? "Asset" : generalLedger.Base.StartsWith('2') ? "Liability" : generalLedger.Base.StartsWith('3') ? "Revenue" : "Expense", generalLedger.RecordStatus);
    }
}
