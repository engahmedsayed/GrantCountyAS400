using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Accounting.Repository
{
   public interface IGeneralLedgerRepository
    {
        IEnumerable<GeneralLedger> GetAll(int fiscalYear, string fund, string department, string program, string project, string @base, out int resultCount, int pageNumber = 1, int pageSize = 50);

        GeneralLedgerDetail GetAll(int fiscalYear, string accountNumber,out int resultCount,int pageNumber=1,int pageSize=50);

        IEnumerable<GeneralLedgerMonthDetail> GetMonthDetails(int month, int fiscalYear, string fund, string department, string program, string project, out int resultCount, int pageNumber = 1, int pageSize = 50);


    }
}
