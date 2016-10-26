using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab1.Services;

namespace Lab1.Controllers
{
    public class CompanyController : Controller
    {
        private ICompanyData _companyData;

        public CompanyController(ICompanyData companyData)
        {
            _companyData = companyData;
        }
        public IActionResult Index()
        {
            return View(_companyData.GetAll());
        }
    }
}
