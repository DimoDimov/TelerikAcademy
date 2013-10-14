using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TicketingSystem.Models;

namespace TicketingSystem.Web.Models
{
    public class CommentViewModel
    {
        public static Expression<Func<Comment, CommentViewModel>> FromComment
        {
            get
            {
                return comment => new CommentViewModel
                {
                    AuthorName = comment.User.UserName,
                    Content = comment.Content
                };
            }
        }

        public string AuthorName { get; set; }

        [ShouldNotContainEmailAttribute(ErrorMessage = "Comment content should not contain email attribute")]
        public string Content { get; set; }
    }
}