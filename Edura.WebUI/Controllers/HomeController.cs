using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Edura.WebUI.Entity;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IUnitOfWork uow; //bütün repositorilere ulaşmayı sağlar

        public HomeController(IProductRepository _repository, IUnitOfWork _uow)
        {
            repository = _repository;
            uow = _uow;
        }

        public IActionResult Index()
        {
            //return View(repository.GetAll());

            //yada

            //unit of work interfacesine göre gösterim
            return View(uow.Products.GetAll().Where(i=>i.isApproved && i.isHome).ToList());
        }


        public IActionResult Create()
        {
            var prd = new Product() { ProductName = "Yeni Ürün", Price = 1000 };

            uow.Products.Add(prd);

            uow.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
