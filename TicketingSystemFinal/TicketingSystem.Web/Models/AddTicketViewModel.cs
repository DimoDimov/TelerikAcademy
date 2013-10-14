using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TicketingSystem.Models;

namespace TicketingSystem.Web.Models
{
    public class AddTicketViewModel
    {
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public int CategoryId { get; set; }

        [Required, MinLength(6), MaxLength(50), ShouldNotContainBug(ErrorMessage = "Title should be between 6 and 50 characters and must not contain the word \"bug\"")]
        public string Title { get; set; }

        [DefaultValue(1)]
        public Priority? Priority { get; set; }

        [MaxLength(500)]
        public string ScreenShotUrl { get; set; }

        [MinLength(6), MaxLength(1000), ShouldNotContainEmail(ErrorMessage="Description must be at between 6 and 1000 charachters and should not contain e-mail")]
        [UIHint("MultilineText")]
        public string Description { get; set; }
    }
}