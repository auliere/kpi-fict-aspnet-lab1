using Microsoft.AspNetCore.Mvc;
using Lab1.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab1.Controllers
{
    public class ContractItemController : Controller
    {
        private IContractItemData _contractItemData;

        public ContractItemController(IContractItemData contractItemData)
        {
            _contractItemData = contractItemData;
        }

        public IActionResult Index()
        {
            return View(_contractItemData.GetAll());
        }
    }
}
