﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TicketingSystem.Models;

namespace TicketingSystem.Web.Models
{
    public class CommentSubmitViewModel
    {
        public int TicketId { get; set; }

        public string AuthorId { get; set; }

        [Required, MinLength(6), MaxLength(1000), ShouldNotContainEmail]
        public string Content { get; set; }
    }
}