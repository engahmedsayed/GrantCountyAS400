using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Accounting;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("personnel")]
    public class PersonnelController : Controller
    {
        private readonly IPersonnelRepository _personnelRepository;
        public PersonnelController(IPersonnelRepository personnelRepository)
        {
            _personnelRepository= personnelRepository;
        }

        public IActionResult Index()
        {
            var results = _personnelRepository.GetAllWithContracts()
                                              .ToList();
            return View(results);
        }
    }
}