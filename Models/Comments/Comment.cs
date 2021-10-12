using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.Books;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Models.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }

        // User that created this comment
        public string CreatedByUserId { get; set; }
        public IdentityUser CreatedByUser { get; set; }
        [Required]
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public List<CommentHistory> CommentHistory { get; set; }
    }
}
