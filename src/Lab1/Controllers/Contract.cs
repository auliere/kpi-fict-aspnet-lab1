using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab1.Services;

namespace Lab1.Controllers
{
    public class Contract : Controller
    {
        private IContractData _contractData;

        public Contract(IContractData contractData)
        {
            _contractData = contractData;
        }
               
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_contractData.GetAll());
            }
            return View(_contractData.GetAll().Where(contract => contract.ShopID == id));
        }
        
    }
}
