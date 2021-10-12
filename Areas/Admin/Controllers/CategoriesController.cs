using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models.Categories;
using Microsoft.AspNetCore.Http;
using BookStore.Areas.Admin.Utils;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriesController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Categories.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _dbContext.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category, IFormFile thumbnailFile)
        {
            if (ModelState.IsValid)
            {
                category.Id = Guid.NewGuid();

                if (thumbnailFile != null)
                {
                    var fileNameAsync = ImagesUtil.CreateImageFile(thumbnailFile);
                    category.Thumbnail = fileNameAsync.Result;
                }

                _dbContext.Add(category);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _dbContext.Categories
                .Where(c => c.Id == id)
                .Include(c => c.Subjects)
                .FirstOrDefaultAsync();

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Category category, IFormFile thumbnailFile)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (thumbnailFile != null)
                    {
                        var fileNameAsync = ImagesUtil.CreateImageFile(thumbnailFile);
                        category.Thumbnail = fileNameAsync.Result;
                    }
                    else
                    {
                        category.Thumbnail = category.Thumbnail;
                    }

                    _dbContext.Update(category);
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View(nameof(Details), category);
            }
            return View(nameof(Details), category);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _dbContext.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(Guid id)
        {
            return _dbContext.Categories.Any(e => e.Id == id);
        }
    }
}
