using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models.CategorySubjects;
using BookStore.Models.Categories;

namespace BookStore.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorySubjectsRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategorySubjectsRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<CategorySubject> GetCategorySubjects([FromQuery] string categoryId)
        {
            if (categoryId != null)
            {
                return _context.CategorySubjects.Where(c => c.CategoryId.ToString() == categoryId);
            }
            return _context.CategorySubjects;
        }

        [HttpGet]
        [Route("otherSubjects")]
        public IEnumerable<CategorySubject> OtherSubjects([FromQuery] string categoryId)
        {
            if (categoryId != null)
            {
                return _context.CategorySubjects.Where(c => c.CategoryId.ToString() != categoryId);
            }
            return _context.CategorySubjects;
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorySubject([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categorySubject = await _context.CategorySubjects.FindAsync(id);
            if (categorySubject == null)
            {
                return NotFound();
            }

            _context.CategorySubjects.Remove(categorySubject);
            await _context.SaveChangesAsync();

            return Ok(categorySubject);
        }

        [HttpGet]
        [Route("categories")]
        public IEnumerable<Category> Categories()
        {
            return _context.Categories;
        }
    }
}