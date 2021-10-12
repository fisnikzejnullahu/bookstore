using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.CategorySubjects;

namespace BookStore.Models.Categories
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }
        public List<CategorySubject> SubjectList { get; set; }
    }
}
