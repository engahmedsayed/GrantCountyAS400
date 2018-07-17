using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.AccountingVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("personnel")]
    public class PersonnelController : Controller
    {
        private readonly IPersonnelRepository _personnelRepository;
        private readonly IDeductionRepository _deductionRepository;

        public PersonnelController(IPersonnelRepository personnelRepository, IDeductionRepository deductionRepository)
        {
            _personnelRepository = personnelRepository;
            _deductionRepository = deductionRepository;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, AccountingFilterVm filter = default(AccountingFilterVm))
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _personnelRepository
                                .GetAllWithContracts(filter.FirstName, filter.LastName, filter.SSN, out resultCount, pageNumber, AppSettings.PageSize)
                                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<Personnel, PersonnelViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id, PersonnelDetailsFilterViewModel filter)
        {
            var entity = _personnelRepository.Details(id, filter.DeductionCode, filter.FromYear, filter.ToYear);
            if (entity == null)
                return NotFound();

            ViewBag.FilterViewModel = filter;
            ViewBag.DeductionCodes = _deductionRepository.GetAllCodes().Select(deductionCode => new SelectListItem()
            {
                Value = deductionCode,
                Text = deductionCode
            });

            var viewmodel = AutoMapper.Mapper.Map<PersonnelWithContractFullDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}