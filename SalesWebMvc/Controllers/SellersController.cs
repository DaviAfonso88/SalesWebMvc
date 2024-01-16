using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
<<<<<<< HEAD
using SalesWebMvc.Models.ViewModels;
=======
>>>>>>> b8207c59af711d1a87ea07c88b08cf678950afc7
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
<<<<<<< HEAD
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
=======
            return View();
>>>>>>> b8207c59af711d1a87ea07c88b08cf678950afc7
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
