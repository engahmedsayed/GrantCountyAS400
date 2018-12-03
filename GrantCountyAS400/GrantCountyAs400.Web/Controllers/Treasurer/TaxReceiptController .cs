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
        private readonly ITaxReceiptRepository  _taxReceiptRepository;

        public TaxReceiptController(ITaxReceiptRepository taxReceiptRepository)
        {
            _taxReceiptRepository = taxReceiptRepository;
        }
        
        [HttpGet]
        [Route("{transactionNumber}")]
        public IActionResult Details(decimal transactionNumber)
        {
            var entity = _taxReceiptRepository.Get(transactionNumber);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<TaxReceiptViewModel>(entity);
            return View(viewmodel);
        }
    }
}