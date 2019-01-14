using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("building-permits")]
    [Authorize]
    public class BuildingPermitsController : Controller
    {
        private readonly IBuildingPermitsRepository _buildingPermitsRepository;
        public BuildingPermitsController(IBuildingPermitsRepository buildingPermitsRepository)
        {
            _buildingPermitsRepository = buildingPermitsRepository;
        }
        public IActionResult Index(BuildingPermitsFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _buildingPermitsRepository.GetBuldingPermitsMain(filter.ParcelNumber,out resultCount, pageNumber).ToList();
            ViewBag.FilterViewModel = filter;
            if (results != null)
            {
                pagingInfo.Total = resultCount;
                results = results.OrderBy(t => t.ParcelNumber).ToList();
                return View(results.ToMappedPagedList<BuildingPermitsMain, BuildingPermitsMainViewModel>(pagingInfo));
            }
            return View();
        }

        [HttpGet]
        [Route("HistoricValues",Name = "HistoricValues")]
        public IActionResult HistoricValues(HistoricValuesFilterViewModel filter,int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            if(filter.ParcelNumber == 0)
            {
                return View();
            }
            var results = _buildingPermitsRepository.GetHistoricValues(filter.ParcelNumber, filter.TaxPayerCode, out resultCount, pageNumber);
            ViewBag.FilterViewModel = filter;
            if (results != null)
            {
                pagingInfo.Total = resultCount;
                return View(results.Items.ToMappedPagedList<HistoricValuesItems, HistoricValuesViewModel>(pagingInfo));
            }
            return View();
        }

        [HttpGet]
        [Route("Details/{parcelNumber}/{ownerCode?}")]
        public IActionResult Details(decimal parcelNumber, string ownerCode)
        {
            var entity = _buildingPermitsRepository.GetParcelBuildingPermits(parcelNumber, ownerCode);
            if (entity == null)
                return NotFound();

            //var viewmodel = AutoMapper.Mapper.Map<AssociatedPersonViewModel>(entity);
            //ViewBag.FilterViewModel = new AssociatedPersonFilterViewModel() { ParcelNumber = parcelNumber, NameCode = ownerCode };
            BuildingPermitsViewModel result = new BuildingPermitsViewModel()
            {
                BuildingValue = entity.BuildingValue,
                FirstDescription = entity.FirstDescription,
                FourthDescription = entity.FourthDescription,
                LandAv = entity.LandAv, 
                LandUse  = entity.LandUse,
                Owner = entity.Owner,
                ParcelNumber = entity.ParcelNumber,
                SecondDescription = entity.SecondDescription,
                TaxPayer = entity.TaxPayer,
                ThirdDescription = entity.ThirdDescription,
                TotalAcre = entity.TotalAcre
            };
            List<BuildingPermitsLineValueViewModel> lineValues = new List<BuildingPermitsLineValueViewModel>();
            foreach (var item in entity.LineValues)
            {
                lineValues.Add(new BuildingPermitsLineValueViewModel
                {
                    Comment = item.Comment,
                    EstimatedValue = item.EstimatedValue,
                    JurisdictionCode = item.JurisdictionCode,
                    NewOrDemo = item.NewOrDemo,
                    PercentComplete = item.PercentComplete,
                    PermitAddenDum = item.PermitAddenDum,
                    PermitIssueDate = item.PermitIssueDate,
                    PermitNumber = item.PermitNumber.HasValue ? (int?)item.PermitNumber : null,
                    PermitYear= item.PermitYear.HasValue?(int?)item.PermitYear:null
                });
            }
            result.LineValues = lineValues.OrderByDescending(t=>t.PermitIssueDate).ToList();
            return View(result);
        }
    }
}