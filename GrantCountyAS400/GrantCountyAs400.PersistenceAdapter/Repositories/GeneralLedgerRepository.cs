using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class GeneralLedgerRepository : IGeneralLedgerRepository
    {
        private readonly GrantCountyDbContext _context;

        public GeneralLedgerRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<GeneralLedger> GetAll( int fiscalYear, string fund, string department, string program,string project,string @base, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<GeneralLedger> results = new List<GeneralLedger>();
            //IQueryable<AcctGeneralLedger> query = _context.AcctGeneralLedger.Where(t => t.FiscalYear == fiscalYear);
            var query = from accountGeneralLedger
                        in _context.AcctGeneralLedger
                        join accChartOfAccountView
                        in _context.AccountChartOfAccountsView
                        on accountGeneralLedger.Base.Trim() equals accChartOfAccountView.AccountNumberFixed
                        where (accountGeneralLedger.Fund == fund || string.IsNullOrWhiteSpace(fund)) 
                        && (accountGeneralLedger.Department == department || string.IsNullOrWhiteSpace(department))
                        && (accountGeneralLedger.Program == program || string.IsNullOrWhiteSpace(program))
                        &&(accountGeneralLedger.Project == project || string.IsNullOrWhiteSpace(project))
                        &&(accountGeneralLedger.Base == @base || string.IsNullOrWhiteSpace(@base))
                        && accChartOfAccountView.AcctCategory == "BASEELEM"
                        && accChartOfAccountView.FiscalYear == fiscalYear 
                        //&& (string.Concat(accountGeneralLedger.Base.Trim(), "0")) ==
                        //    string.Concat(accChartOfAccount.AcctNumber.Replace(".", "").Trim(), "0")
                        orderby accountGeneralLedger.Id
                        select new { accountGeneralLedger, accChartOfAccountView };

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .Select(t => GeneralLedgerMapper.Map(t.accountGeneralLedger, t.accChartOfAccountView))
                                      .ToList();
            }
            else
            {
                results = query.Select(t=> GeneralLedgerMapper.Map(t.accountGeneralLedger, t.accChartOfAccountView)).ToList();
                resultCount = results.Count();
            }
            return results;

        }

        public GeneralLedgerDetail GetAll(int fiscalYear, string accountNumber, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            GeneralLedgerDetail results = null;
            var query = (from accChartOfAccountView
                        in _context.AccountChartOfAccountsView
                        join pa
                        in _context.AcctGlperiodAmounts
                        on accChartOfAccountView.AccountNumberFixed equals pa.Base
                        where pa.FiscalYear == fiscalYear && pa.Base == accountNumber
                        orderby pa.Month
                        select GeneralLedgerMapper.Map(pa)).Distinct();
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results =new GeneralLedgerDetail(query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToList(),"","");
            }
            else
            {
                results =new GeneralLedgerDetail(query.ToList(),"","");
                resultCount = results.GeneralLedgers.Count();
            }
            return results;

        }
    }
}
