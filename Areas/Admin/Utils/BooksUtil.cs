using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;
using BookStore.Models.Comments;

namespace BookStore.Areas.Admin.Utils
{
    public static class BooksUtil
    {
        public static CommentHistory LastEditedComment(Comment comment)
        {
            List<CommentHistory> history = comment.CommentHistory;
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
