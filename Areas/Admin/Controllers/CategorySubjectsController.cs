using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models.CategorySubjects;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategorySubjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategorySubjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CategorySubjects.Include(c => c.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorySubject = await _context.CategorySubjects
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorySubject == null)
            {
                return NotFound();
            }

            return View(categorySubject);
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Name")] CategorySubject categorySubject)
        {
            if (ModelState.IsValid)
            {
                categorySubject.Id = Guid.NewGuid();
                _context.Add(categorySubject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", categorySubject.CategoryId);
            return View(categorySubject);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorySubject = await _context.CategorySubjects.FindAsync(id);
            if (categorySubject == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", categorySubject.CategoryId);
            return View(categorySubject);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CategoryId,Name")] CategorySubject categorySubject)
        {
            if (id != categorySubject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categorySubject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategorySubjectExists(categorySubject.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", categorySubject.CategoryId);
            return View(categorySubject);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorySubject = await _context.CategorySubjects
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorySubject == null)
            {
                return NotFound();
            }

            return View(categorySubject);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var categorySubject = await _context.CategorySubjects.FindAsync(id);
            _context.CategorySubjects.Remove(categorySubject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategorySubjectExists(Guid id)
        {
            return _context.CategorySubjects.Any(e => e.Id == id);
        }
    }
}
