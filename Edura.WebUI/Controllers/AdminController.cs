using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Edura.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork unitOfWork;

        public AdminController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = unitOfWork.Categories.GetAll().ToList(),
                Products = unitOfWork.Products.GetAll().ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Categories.Add(entity);
                unitOfWork.SaveChanges();

                //ajax daki succes kısmı için
                return Ok(entity);
            }

            //ajax daki error kısmı için
            return BadRequest();
        }

        #region Kategori Düzenle Bölgesi

        [HttpGet]
        public IActionResult EditCategory(int id)
        {

            var entity = unitOfWork.Categories.GetAll()
                .Include(i => i.productCategories)
                .ThenInclude(i => i.Product)
                .Where(i => i.CategoryId == id)
                .Select(i => new AdminEditCategoryModel()
                {
                    CategoryId=i.CategoryId,
                    CategoryName=i.CategoryName,
                    Products=i.productCategories.Select(a=>new AdminEditCategoryModel.AdminEditCategoryProduct()
                    {
                        ProductId=a.ProductId,
                        ProductName=a.Product.ProductName,
                        Image=a.Product.Image,
                        isApproved=a.Product.isApproved,
                        isHome=a.Product.isHome,
                        isFeatured=a.Product.isFeatured
                    }).ToList()
                }).FirstOrDefault();

            return View(entity);
        }

        [HttpPost]
        public IActionResult EditCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Categories.Edit(entity);

                unitOfWork.SaveChanges();

                return RedirectToAction("CatalogList");
            }
            return View("Error");
        }

        #endregion

        #region Kategoriden ürün silme bölgesi

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCategory(int ProductId, int CategoryId)
        {
            if (ModelState.IsValid)
            {
                //silme
                unitOfWork.Categories.RemoveFromCategory(ProductId, CategoryId);
                unitOfWork.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        #endregion


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //resim yükleme bölümü
                if (file!=null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", file.FileName);

                    var path_tn = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products\\tn", file.FileName);

                    using (var stream=new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);

                        entity.Image = file.FileName;
                    }

                    using (var stream = new FileStream(path_tn, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                entity.DateAdded = DateTime.Now;
                unitOfWork.Products.Add(entity);

                unitOfWork.SaveChanges();

                return RedirectToAction("CatalogList");
            }

            return View(entity);
        }

        
    }
}