using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.CategorySubjects
{
    public class SubjectViewModel
    {
        public CategorySubject Subject { get; set; }
        public List<CategorySubject> Subjects { get; set; }
    }
}
