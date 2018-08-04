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
                        in _context.AcctChartOfAccounts
                        on new {
                            key1 = accountGeneralLedger.Project.Trim() + "." + accountGeneralLedger.Base.Trim().Substring(0, 2),
                            key2 = accountGeneralLedger.FiscalYear.Value }
                        equals new { key1 = accChartOfAccountView.AcctNumber.Trim(), key2 = accChartOfAccountView.FiscalYear }
                        into joinResult from accountChartOfAccountsResult in joinResult.DefaultIfEmpty()
                        where (accountGeneralLedger.Fund == fund || string.IsNullOrWhiteSpace(fund)) 
                        && (accountGeneralLedger.Department == department || string.IsNullOrWhiteSpace(department))
                        && (accountGeneralLedger.Program == program || string.IsNullOrWhiteSpace(program))
                        &&(accountGeneralLedger.Project == project || string.IsNullOrWhiteSpace(project))
                        &&(accountGeneralLedger.Base == @base || string.IsNullOrWhiteSpace(@base))
                        //&& accountChartOfAccountsResult!=null? accountChartOfAccountsResult.AcctCategory == "BASEELEM":1==1
                        //&& accountChartOfAccountsResult!=null? accountChartOfAccountsResult.FiscalYear == fiscalYear  : 1==1
                        //&& (string.Concat(accountGeneralLedger.Base.Trim(), "0")) ==
                        //    string.Concat(accChartOfAccount.AcctNumber.Replace(".", "").Trim(), "0")
                        orderby accountGeneralLedger.Id
                        select new { accountGeneralLedger, accountChartOfAccountsResult };

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .Select(t => GeneralLedgerMapper.Map(t.accountGeneralLedger, t.accountChartOfAccountsResult))
                                      .ToList();
            }
            else
            {
                results = query.Select(t=> GeneralLedgerMapper.Map(t.accountGeneralLedger, t.accountChartOfAccountsResult)).ToList();
                resultCount = results.Count();
            }
            return results;

        }

        public GeneralLedgerDetail GetAllDetails(string fund,string department,string program,string project,string @base, int fiscalYear, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            GeneralLedgerDetail results = null;
            var query = (from pa
                        in _context.AcctGlperiodAmounts
                        where pa.FiscalYear == fiscalYear && pa.Base == @base &&  pa.Fund == fund && pa.Department == department
                        && pa.Program == program && pa.Project == project 
                        orderby pa.Year
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

        public IEnumerable<GeneralLedgerMonthDetail> GetMonthDetails(int month, int fiscalYear, string fund, string department, string program, string project,string @base, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<GeneralLedgerMonthDetail> results = new List<GeneralLedgerMonthDetail>();
            var query = _context.AcctGltransactions.Where(t => t.FiscalYear == fiscalYear && t.Fund == fund && t.Month == month && 
                                                               t.Year == fiscalYear && t.Department == department && t.Project == project &&
                                                               t.Program == program && t.Base == @base)
                                                             .OrderBy(t=>t.Year).ThenBy(t=>month).ThenBy(t=>t.Jenumber);
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize).Select(t => GeneralLedgerMapper.Map(t)).ToList();
            }
            else
            {
                results = query.Select(t => GeneralLedgerMapper.Map(t)).ToList();
                resultCount = results.Count();
            }
            return results;
        }
    }
}
