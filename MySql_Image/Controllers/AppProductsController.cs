using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MySql_Image.Data;
using MySql_Image.Data.Entities;
using MySql_Image.Services;

namespace MySql_Image.Controllers
{
    public class AppProductsController : Controller
    {
        private readonly ProductImageDbContext _context;

        public AppProductsController(ProductImageDbContext context)
        {
            _context = context;
        }

        // GET: AppProducts?sortOrder=cost_desc
        [Authorize]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["AiPartNumberSortParm"] = String.IsNullOrEmpty(sortOrder) ? "num_desc" : "";
            ViewData["CostSortParm"] = sortOrder == "cost" ? "cost_desc" : "cost";
            ViewData["ManufactureNameSortParm"] = sortOrder == "manufact" ? "manufact_desc" : "manufact";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var products = from p in _context.Products select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductDescription.Contains(searchString)
                                       || s.ManufactureName.Contains(searchString) || s.AiPartNumber.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "num_desc":
                    products = products.OrderByDescending(s => s.AiPartNumber);
                    break;
                case "cost":
                    products = products.OrderBy(s => s.Cost);
                    break;
                case "cost_desc":
                    products = products.OrderByDescending(s => s.Cost);
                    break;
                case "manufact_desc":
                    products = products.OrderByDescending(s => s.ManufactureName);
                    break;
                case "manufact":
                    products = products.OrderBy(s => s.ManufactureName);
                    break;
                default:
                    products = products.OrderBy(s => s.AiPartNumber);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), page ?? 1, pageSize));
        }

        // GET: AppProducts/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: AppProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsDiscontinued,AssociatedCategoryId,AssociatedSnapshotTypeId,AssociatedGroupId,AssociatedScreenId,AssociatedImageId,AssociatedRecycleId,MerchantNumber,ProductDescription,AiPartNumber,ManufactureNumber,ManufactureName,MfgUrl,MfgManualUrl,AssociatedPrimaryVendorId,AssociatedSecondaryVendorId,AssociatedTertiaryVendorId,Retail,Cost,AdditionalCost,DefaultPriority,IsTaxable,IsRecycleFee,ItemsAssociated,IsExcludedDesAinumOverrwrite,CostVerificationBy")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: AppProducts/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: AppProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,IsDiscontinued,AssociatedCategoryId,AssociatedSnapshotTypeId,AssociatedGroupId,AssociatedScreenId,AssociatedImageId,AssociatedRecycleId,MerchantNumber,ProductDescription,AiPartNumber,ManufactureNumber,ManufactureName,MfgUrl,MfgManualUrl,AssociatedPrimaryVendorId,AssociatedSecondaryVendorId,AssociatedTertiaryVendorId,Retail,Cost,AdditionalCost,DefaultPriority,IsTaxable,IsRecycleFee,ItemsAssociated,IsExcludedDesAinumOverrwrite,CostVerificationBy")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
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
            return View(product);
        }

        // GET: AppProducts/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: AppProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(uint id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
