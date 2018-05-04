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
    public class AppController : Controller
    {
        private readonly IMailService _mail;
        private readonly ProductImageDbContext _context;

        public AppController(ProductImageDbContext context, IMailService mail)
        {
            //email

            _mail = mail;
            _context = context;
        }

        // GET: App
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //TODO: working BUT account saw this as juck mail! Make async it is blocking the page
            //_mail.SendMessage("fox.geoffrey@gmail.com", "Test from Audio Impact App", "This only a test message!");
            return View(await _context.ProductImages.ToListAsync());
        }

        // GET: App/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productImage = await _context.ProductImages
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productImage == null)
            {
                return NotFound();
            }

            return View(productImage);
        }

        // GET: App/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: App/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateUpdated,FileName,ImageThumb,ImageFull")] ProductImage productImage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productImage);
        }

        // GET: App/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productImage = await _context.ProductImages.SingleOrDefaultAsync(m => m.Id == id);
            if (productImage == null)
            {
                return NotFound();
            }
            return View(productImage);
        }

        // POST: App/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,DateUpdated,FileName,ImageThumb,ImageFull")] ProductImage productImage)
        {
            if (id != productImage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductImageExists(productImage.Id))
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
            return View(productImage);
        }

        // GET: App/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productImage = await _context.ProductImages
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productImage == null)
            {
                return NotFound();
            }

            return View(productImage);
        }

        // POST: App/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var productImage = await _context.ProductImages.SingleOrDefaultAsync(m => m.Id == id);
            _context.ProductImages.Remove(productImage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductImageExists(uint id)
        {
            return _context.ProductImages.Any(e => e.Id == id);
        }
    }
}
