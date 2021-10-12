using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.CategorySubjects;
using BookStore.Models.Comments;
using BookStore.Models.OrdersBooks;
using BookStore.Models.Rates;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookStore.Models.Books
{
    public class Book
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        [Required]
        [Range(0, 10000)]
        public double Price { get; set; }
        public string Isbn { get; set; }
        public bool Active { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        [Required]
        public Guid CategorySubjectId { get; set; }
        public CategorySubject CategorySubject { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Rate> Rates { get; set; }
        public List<OrderBook> OrderBook { get; set; }
    }
}
