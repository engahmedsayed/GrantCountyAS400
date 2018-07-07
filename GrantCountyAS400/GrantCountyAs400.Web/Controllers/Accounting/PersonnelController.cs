using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.AccountingVM;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("personnel")]
    public class PersonnelController : Controller
    {
        private readonly IPersonnelRepository _personnelRepository;
        public PersonnelController(IPersonnelRepository personnelRepository)
        {
            _personnelRepository = personnelRepository;
        }

        public async Task<IActionResult> Index(AccountingFilterVm filter, int page = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = page };
            var results = _personnelRepository.GetAllWithContracts(filter.FirstName, filter.LastName, filter.SSN, out resultCount, page, AppSettings.PageSize)
                                              .ToList().OrderBy(t => t.Id);
            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            var onePageOfPersonnnel = results.ToManualPagedList(pagingInfo);
            return View(onePageOfPersonnnel);
        }
    }
}