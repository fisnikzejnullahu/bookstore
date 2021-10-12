using System;

namespace BookStore.Models.Comments
{
    public class CommentHistory
    {
        public Guid Id { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }
        public string Message { get; set; }
        public DateTime EditedTime { get; set; }
    }
}
