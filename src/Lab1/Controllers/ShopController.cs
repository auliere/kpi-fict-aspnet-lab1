using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab1.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab1.Controllers
{
    public class ShopController : Controller
    {
        private IShopData _shopData;

        public ShopController(IShopData shopData)
        {
            _shopData = shopData;
        }

        public IActionResult Index()
        {
            return View(_shopData.GetAll());
        }
    }
}
