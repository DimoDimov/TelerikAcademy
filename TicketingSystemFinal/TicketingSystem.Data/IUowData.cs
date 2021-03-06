﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Data
{
    public interface IUowData
    {
        IRepository<Ticket> Tickets { get; }

        IRepository<Category> Categories { get; }

        IRepository<Comment> Comments { get; }

        IRepository<ApplicationUser> Users { get; }

        int SaveChanges();
    }
}
