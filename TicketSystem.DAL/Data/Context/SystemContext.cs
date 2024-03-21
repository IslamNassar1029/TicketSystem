using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Enums;
using TicketSystem.DAL.Data.Models;

namespace TicketSystem.DAL.Data.Context;

public class SystemContext:DbContext
{
    public DbSet<Ticket> Tickets=> Set<Ticket>();
    public DbSet<Department> Departments=> Set<Department>();

    public SystemContext(DbContextOptions options):base(options) 
    { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var departments = new List<Department>()
            {
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Finance" },
                new Department { Id = 4, Name = "Marketing" },
                new Department { Id = 5, Name = "Operations" }
            };

         var tickets = new List<Ticket>()
            {
                new Ticket { Id = 1, Email = "user1@example.com", CreatedDate = DateTime.Now.AddDays(-15), IsClosed = false, Severity = Severity.Low, DepartmentId = 3 },
                new Ticket { Id = 2, Email = "user2@example.com", CreatedDate = DateTime.Now.AddDays(-10), IsClosed = true, Severity = Severity.Medium, DepartmentId = 2 },
                new Ticket { Id = 3, Email = "user3@example.com", CreatedDate = DateTime.Now.AddDays(-16), IsClosed = false, Severity = Severity.High, DepartmentId = 1 },
                new Ticket { Id = 4, Email = "user4@example.com", CreatedDate = DateTime.Now.AddDays(-11), IsClosed = false, Severity = Severity.High, DepartmentId = 3 },
                new Ticket { Id = 5, Email = "user5@example.com", CreatedDate = DateTime.Now.AddDays(-14), IsClosed = true, Severity = Severity.Low, DepartmentId = 2 },
                new Ticket { Id = 6, Email = "user6@example.com", CreatedDate = DateTime.Now.AddDays(-7), IsClosed = true, Severity = Severity.Medium, DepartmentId = 1 },
                new Ticket { Id = 7, Email = "user7@example.com", CreatedDate = DateTime.Now.AddDays(-4), IsClosed = true, Severity = Severity.Low, DepartmentId = 5 },
                new Ticket { Id = 8, Email = "user8@example.com", CreatedDate = DateTime.Now.AddDays(-12), IsClosed = false, Severity = Severity.Medium, DepartmentId = 2 },
                new Ticket { Id = 9, Email = "user9@example.com", CreatedDate = DateTime.Now.AddDays(-13), IsClosed = false, Severity = Severity.Medium, DepartmentId = 4 },
                new Ticket { Id = 10, Email = "user10@example.com", CreatedDate = DateTime.Now.AddDays(-9), IsClosed = true, Severity = Severity.High, DepartmentId = 3 }
            };

        var developers = new List<Developer>()
            {
                new Developer { Id = 1, Name = "Islam" },
                new Developer { Id = 2, Name = "Amin" },
                new Developer { Id = 3, Name = "Rahaf" },
                new Developer { Id = 4, Name = "Ali" },
                new Developer { Id = 5, Name = "Nassar" }
            };

        modelBuilder.Entity<Department>().HasData(departments);
        modelBuilder.Entity<Ticket>().HasData(tickets);
        modelBuilder.Entity<Developer>().HasData(developers);
    }

}
