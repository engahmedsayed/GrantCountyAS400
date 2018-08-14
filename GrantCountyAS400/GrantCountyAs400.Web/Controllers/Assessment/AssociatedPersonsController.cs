using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("associated-person")]
    public class AssociatedPersonsController : Controller
    {

        private readonly IAssociatedPersonRepository _associatedPersonRepository;

        public AssociatedPersonsController(IAssociatedPersonRepository associatedPersonRepository)
        {
            _associatedPersonRepository = associatedPersonRepository;
        }

        [HttpGet]
        public IActionResult Index(AssociatedPersonFilterViewModel filter, int pageNumber = 1)
      {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _associatedPersonRepository.GetAssociatedPersonMain(filter.ParcelNumber, filter.NameCode
                                                                            , out resultCount, pageNumber).ToList();
            ViewBag.FilterViewModel = filter;
            if (results != null)
            {
                pagingInfo.Total = resultCount;
                return View(results.ToMappedPagedList<AssociatedPersonMain, AssociatedPersonMainViewModel>(pagingInfo));
            }
            return View();
        }

        //[HttpGet]
        //public IActionResult Details(AssociatedPersonFilterViewModel filter)
        //{
        //    var result = _associatedPersonRepository.GetAssociatedPerson(filter.ParcelNumber, filter.NameCode);
        //    ViewBag.FilterViewModel = filter;
        //    if (result != null)
        //    {
        //        var outputResult = AutoMapper.Mapper.Map<AssociatedPersonViewModel>(result);
        //        return View(outputResult);
        //    }
        //    return View(new AssociatedPersonViewModel());
        //}

        [HttpGet]
        [Route("ItemDetail/{nameCode}/{parcelNumber}")]
        public IActionResult ItemDetail(string nameCode, decimal parcelNumber)
        {
            var entity = _associatedPersonRepository.GetAssociatedPerson(parcelNumber, nameCode);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<AssociatedPersonViewModel>(entity);
            ViewBag.FilterViewModel = new AssociatedPersonFilterViewModel() { ParcelNumber = parcelNumber, NameCode = nameCode };
            return View(viewmodel);
        }

        [HttpGet]
        [Route("Details/{parcelNumber}/{nameCode?}")]
        public IActionResult Details(decimal parcelNumber, string nameCode)
        {
            var entity = _associatedPersonRepository.GetAssociatedPerson(parcelNumber,nameCode);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<AssociatedPersonViewModel>(entity);
            ViewBag.FilterViewModel = new AssociatedPersonFilterViewModel() { ParcelNumber = parcelNumber, NameCode = nameCode };
            return View(viewmodel);
        }
    }
}