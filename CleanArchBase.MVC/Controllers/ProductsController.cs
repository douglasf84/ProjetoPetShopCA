using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchBase.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProdutoService _productService;

        public ProductsController(IProdutoService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllAsync();
            return View(result);
        }

        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price")] ProdutoViewModel product)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateAsync(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpGet()]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            var productVM = await _productService.GetByIdAsync(id);

            if (productVM == null) return NotFound();
            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([Bind("Id,Name,Description,Price")] ProdutoViewModel productVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _productService.UpdateAsync(productVM);
                }
                catch (Exception)
                {

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productVM);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var productVM = await _productService.GetByIdAsync(id);

            if (productVM == null) return NotFound();
            return View(productVM);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _productService.RemoveAsync(id);
                }
                catch (Exception)
                
                {

                    throw;
                }
            }

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) { return NotFound(); }

            var productVM = await _productService.GetByIdAsync(id);

            if (productVM == null) return NotFound();

            return View(productVM);
        }


    }
}
