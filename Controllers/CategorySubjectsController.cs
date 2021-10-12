using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models.CategorySubjects;

namespace BookStore.Controllers
{
    public class CategorySubjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategorySubjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CategorySubjects
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CategorySubjects.Include(c => c.Category);
            return View(await applicationDbContext.ToListAsync());
        }




        public async Task<IActionResult> Details(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var books = await _context.Books.Where(b => b.Active).ToListAsync();

            var subject = await _context.CategorySubjects
                .Where(s => s.Id == Id)
                .FirstOrDefaultAsync();

            if (subject == null)
            {
                return NotFound();
            }

            var otherSubjects = await _context.CategorySubjects
                .Where(s => s.Id != Id)
                .Include(s => s.Books)
                .ToListAsync();

            var vm = new SubjectViewModel
            {
                Subject = subject,
                Subjects = otherSubjects
            };
            return View(vm);
        }
    }
}
