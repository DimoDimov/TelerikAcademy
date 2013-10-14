using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class ApplicationUser : User
    {
        private int points;

        public ApplicationUser()
        {
            this.points = 10;
        }

        [Required, DefaultValue(10)]
        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }
    }
}
