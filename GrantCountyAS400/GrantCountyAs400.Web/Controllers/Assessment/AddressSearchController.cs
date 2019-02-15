using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.AddressSearch;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("address-search")]
    [Authorize]
    public class AddressSearchController : Controller
    {

        private readonly IAddressSearchRepository _addressSearchRepository;
        public AddressSearchController(IAddressSearchRepository addressSearchRepository)
        {
            _addressSearchRepository = addressSearchRepository;
        }
        public IActionResult Index(AddressSearchFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _addressSearchRepository.GetAll(filter.ParcelNumber, filter.HouseNumber, filter.StreetName,
                                                          out int resultCount, pageNumber, AppSettings.PageSize)
                                                       .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<AddressSearch, AddressSearchViewModel>(pagingInfo));
        }
    }
}