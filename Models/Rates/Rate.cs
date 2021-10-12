using System;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.Books;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Models.Rates
{
    public class Rate
    {
        public Guid Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [Required]
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        [Range(0, 5)]
        public byte Value { get;set; } 
    }
}
