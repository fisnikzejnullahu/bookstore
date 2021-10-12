using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.CategorySubjects;

namespace BookStore.Models.Categories
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<CategorySubject> Subjects { get;set; }
        public string Thumbnail { get; set; }
    }
}
