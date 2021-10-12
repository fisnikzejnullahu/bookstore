using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Comments;

namespace BookStore.Models.Books
{
    public class BookPostViewModel
    {
        public Book Book { get; set; }
        public Comment InEditComment { get; set; }

        public CommentHistory LastEditedComment(List<CommentHistory> history)
        {
            CommentHistory lastOne = null;

            history.ForEach(h =>
            {
                if (lastOne == null || h.EditedTime > lastOne.EditedTime)
                {
                    lastOne = h;
                }
            });
            return lastOne;
        }
    }
}
