using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Accounting
{
   public interface IGeneralLedgerRepository
    {
        IEnumerable<GeneralLedger> GetAll(out int resultCount, int pageNumber = 1, int pageSize = 50,int fiscalYear = 2008, string fund = "", string department = "", string program = "");
    }
}
