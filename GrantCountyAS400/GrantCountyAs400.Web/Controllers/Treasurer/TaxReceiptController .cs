using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt;
using GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Treasurer
{
    [Route("tax-receipt")]
    public class TaxReceiptController : Controller
    {
        private readonly ITaxReceiptRepository _taxReceiptRepository;

        public TaxReceiptController(ITaxReceiptRepository taxReceiptRepository)
        {
            _taxReceiptRepository = taxReceiptRepository;
        }

        [HttpGet]
        public IActionResult Index(TaxReceiptFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results =
                _taxReceiptRepository.GetAll(
                    filter.MinReceiptNumber, filter.MaxReceiptNumber, filter.MinAffidavitNumber, filter.MaxAffidavitNumber, filter.MinDate, filter.MaxDate, out int resultCount, pageNumber, AppSettings.PageSize)
                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<TaxReceipt, TaxReceiptViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{transactionNumber}")]
        public IActionResult Details(decimal transactionNumber)
        {
            var entity = _taxReceiptRepository.Details(transactionNumber);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<TaxReceiptDetailsViewModel>(entity);
            return View(viewmodel);
        }

        [HttpGet]
        [Route("affadavit")]
        public IActionResult AffadavitReceipts(TaxReceiptFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results =
                _taxReceiptRepository.GetAllAffadavitReceipts(
                    filter.MinReceiptNumber, filter.MaxReceiptNumber, filter.MinAffidavitNumber, filter.MaxAffidavitNumber, out int resultCount, pageNumber, 
                    AppSettings.PageSize)
                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<AffadavitReceipt, AffadavitReceiptViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("tax-payment")]
        public IActionResult TaxPaymentReceipts(TaxPaymentReceiptFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results =
                _taxReceiptRepository.GetAllTaxPaymentReceipts(
                    filter.ParcelNumber, filter.ParcelExtension, filter.TaxYear, out int resultCount, pageNumber, AppSettings.PageSize)
                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<TaxPaymentReceipt, TaxPaymentReceiptViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("general")]
        public IActionResult GeneralReceipts(GeneralReceiptFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results =
                _taxReceiptRepository.GetAllGeneralReceipts(filter.ReceiptNumber, out int resultCount, pageNumber, AppSettings.PageSize)
                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<GeneralReceipt, GeneralReceiptViewModel>(pagingInfo));
        }
    }
}