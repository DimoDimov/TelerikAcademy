using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        private ICollection<Comment> comments;

        public Ticket()
        {
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public int CategoryId { get; set; }

        [ShouldNotContainEmail]
        public virtual Category Category { get; set; }

        [Required, MinLength(6), MaxLength(50), ShouldNotContainBug(ErrorMessage = "Title should be between 6 and 50 characters and must not contain the word \"bug\"")]
        public string Title { get; set; }

        public Priority? Priority { get; set; }

        [MaxLength(500)]
        public string ScreenShotUrl { get; set; }

        [ShouldNotContainEmail(ErrorMessage="Description must be at between 6 and 1000 charachters and should not contain e-mail")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
