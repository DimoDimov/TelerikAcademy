using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketingSystem.Models;
using TicketingSystem.Web.Models;
using Microsoft.AspNet.Identity;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace TicketingSystem.Web.Controllers
{
    public class TicketsController : BaseController
    {
        public ActionResult Details(int id)
        {
            var ticketDetailsModel = this.Data.Tickets.All().
                Where(t => t.Id == id).
                Select(ticket => new TicketDetailedViewModel
                {
                    Id = ticket.Id,
                    Title = ticket.Title,
                    AuthorName = ticket.Author.UserName,
                    CategoryName = ticket.Category.Name,
                    Priority = ticket.Priority,
                    ScreenShotUrl = ticket.ScreenShotUrl,
                    Description = ticket.Description,
                    Comments = ticket.Comments.Select
                    (c => new CommentViewModel { AuthorName = c.User.UserName, Content = c.Content }).ToList(),
                }
            ).FirstOrDefault();

            return View(ticketDetailsModel);
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Comment(CommentSubmitViewModel comment)
        {
            if (comment != null && ModelState.IsValid)
            {
                var currentTicket = this.Data.Tickets.GetById(comment.TicketId);
                var newComment = new Comment()
                {
                    Content = comment.Content,
                    Ticket = currentTicket,
                    UserId = comment.AuthorId
                };

                currentTicket.Comments.Add(newComment);
                this.Data.SaveChanges();

                var commentViewModel = new CommentViewModel()
                {
                    AuthorName = User.Identity.GetUserName(),
                    Content = comment.Content
                };

                //returns the new commentViewModel which would be added to the list
                return PartialView("_CommentPartial", commentViewModel);
            }

            ModelState.AddModelError("Content", "Content should be atleast 6 and less than 1000 characters long");
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest,
                ModelState.Values.First().ToString());
        }

        [Authorize]
        public ActionResult AddTicket()
        {
            ViewBag.CategoryId = new SelectList(this.Data.Categories.All(), "Id", "Name");
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddTicket(Ticket ticket)
        {
            string authorId = User.Identity.GetUserId();
            var author = this.Data.Users.All().FirstOrDefault(u => u.Id == authorId);
            ticket.Author = author;
            ticket.AuthorId = authorId;
            author.Points += 1;

            if (ticket.Priority==null)
            {
                ticket.Priority = Priority.Medium;
            }

            if (ModelState.IsValid)
            {
                this.Data.Tickets.Add(ticket);
                this.Data.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.CategoryId = new SelectList(this.Data.Categories.All(), "Id", "Name", ticket.CategoryId);
            return View(ticket);
        }

        [Authorize]
        public ActionResult List()
        {
            return View();
        }

        [Authorize]
        public IQueryable<TicketListViewModel> GetAllTickets()
        {
            var ticketModels = new List<TicketListViewModel>();
            foreach (var ticket in this.Data.Tickets.All())
            {
                var ticketModel = new TicketListViewModel()
                {
                    Id = ticket.Id,
                    Title = ticket.Title,
                    AuthorName = ticket.Author.UserName,
                    CategoryName = ticket.Category.Name,
                    Priority = ticket.Priority.ToString()
                };

                ticketModels.Add(ticketModel);
            }

            return ticketModels.AsQueryable<TicketListViewModel>();
        }

        [Authorize]
        public ActionResult Search([DataSourceRequest] DataSourceRequest request, CategorySearchViewModel model)
        {
            var tickets = this.GetAllTickets();
            int categoryId = int.Parse(model.CategorySearch);
            if (categoryId != 0)
            {
                var selectedCategory = this.Data.Categories.GetById(categoryId);
                tickets = tickets.Where(ticket => ticket.CategoryName.ToLower() == selectedCategory.Name.ToLower());
            }

            return View(tickets);
        }

        [Authorize]
        public JsonResult GetTicketCategories()
        {
            var ticketCategories = this.Data.Tickets.All().
                Select(c => new { CategoryName = c.Category.Name, Id = c.CategoryId }).Distinct().ToList();
            ticketCategories.Insert(0, new { CategoryName = "Select category", Id = 0 });

            return Json(ticketCategories, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        public JsonResult ReadTickets([DataSourceRequest] DataSourceRequest request)
        {
            var tickets = this.GetAllTickets();
            return Json(tickets.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        

      
    }
}