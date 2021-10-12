using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Comments;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Areas.Admin.Models
{
    public class CommentDetailsViewModel
    {
        public Comment Comment { get; set; }
        public IEnumerable<IdentityUser> OtherUsers { get; set; }

        public IEnumerable<SelectListItem> OtherUsersSelectList
        {
            get
            {
                return OtherUsers != null ? OtherUsers.Select(u => new SelectListItem { Text = u.Email, Value = u.Id }) : null;
            }
        }
    }
}
