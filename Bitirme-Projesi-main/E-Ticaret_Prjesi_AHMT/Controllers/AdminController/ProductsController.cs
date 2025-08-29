using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL.Concrate.EfCore.Context;
using Entity;
using WebUI.Services;
using BLL.Abstract;

namespace E_Ticaret_Prjesi_AHMT.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService service;
        private readonly ICategoryService Cat;
        private readonly IColorService Col;
        private readonly IGenderService Gen;

        public ProductsController(IProductService datacontext1,ICategoryService categoryService,IColorService colorService, IGenderService genderService)
        {
            service = datacontext1;
            Cat = categoryService;
            Col = colorService;
            Gen = genderService;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var dataContext = service.GetProuctsWithCategoryGenderColorAsync();
            return View(await dataContext);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await service.GetProuctsWithCategoryGenderColorAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public async Task<IActionResult> Create()
        {
            var Categorys = await Cat.GetAllAsync();
            var Colors = await Col.GetAllAsync();
            var Genders = await Gen.GetAllAsync();

            ViewData["CategoryId"] = new SelectList(Categorys , "Id", "CategoryName");
            ViewData["ColorId"] = new SelectList(Colors, "Id", "ColorName");
            ViewData["GenderId"] = new SelectList(Genders, "Id", "GenderName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,Stock,Url,ColorId,CategoryId,Size,GenderId")] Product product , IFormFile form  )
        {
            if (ModelState.IsValid)
            {
                if (form != null)
                {
                    product.Url = await ImageOperations.UploadImageAsync(form);
                }
                await service.CreateAsync(product);
                await service.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            var Categorys = await Cat.GetAllAsync();
            var Colors = await Col.GetAllAsync();
            var Genders = await Gen.GetAllAsync();


            ViewData["CategoryId"] = new SelectList(Categorys, "Id", "CategoryName", product.CategoryId);
            ViewData["ColorId"] = new SelectList(Colors, "Id", "ColorName", product.ColorId);
            ViewData["GenderId"] = new SelectList(Genders, "Id", "GenderName", product.GenderId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var Categorys = await Cat.GetAllAsync();
            var Colors = await Col.GetAllAsync();
            var Genders = await Gen.GetAllAsync();

            ViewData["CategoryId"] = new SelectList(Categorys, "Id", "CategoryName", product.CategoryId);
            ViewData["ColorId"] = new SelectList(Colors, "Id", "ColorName", product.ColorId);
            ViewData["GenderId"] = new SelectList(Genders, "Id", "GenderName", product.GenderId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,Stock,Url,ColorId,CategoryId,Size,GenderId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await service.UpdateAsync(product);
                    await service.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var Categorys = await Cat.GetAllAsync();
            var Colors = await Col.GetAllAsync();
            var Genders = await Gen.GetAllAsync();


            ViewData["CategoryId"] = new SelectList(Categorys, "Id", "CategoryName", product.CategoryId);
            ViewData["ColorId"] = new SelectList(Colors, "Id", "ColorName", product.ColorId);
            ViewData["GenderId"] = new SelectList(Genders, "Id", "GenderName", product.GenderId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = service.GetProuctsWithCategoryGenderColorAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await service.DeleteByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            var Cat = service.GetAllAsync(e => e.Id == id);

            if (Cat == null)
            {
                return false;
            }

            return true;
        }
    }
}
