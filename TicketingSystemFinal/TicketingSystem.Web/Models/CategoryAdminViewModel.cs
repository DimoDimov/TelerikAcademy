using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TicketingSystem.Models;

namespace TicketingSystem.Web.Models
{
    public class CategoryAdminViewModel
    {
        public static Expression<Func<Category, CategoryAdminViewModel>> FromCategory
        {
            get
            {
                return category => new CategoryAdminViewModel
                {
                    Id = category.Id,
                    Name = category.Name
                };
            }
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, MinLength(6), MaxLength(20), ShouldNotContainBug, ShouldNotContainEmail]
        public string Name { get; set; }
    }
}