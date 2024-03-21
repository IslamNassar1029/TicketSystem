using Microsoft.EntityFrameworkCore;
using TicketSystem.BL.Helpers;
using TicketSystem.BL.Managers.Departments;
using TicketSystem.BL.Managers.Tickets;
using TicketSystem.DAL;
using TicketSystem.DAL.Data.Context;
using TicketSystem.DAL.Repositories.Departments;
using TicketSystem.DAL.Repositories.Tickets;
using TicketSystem.MVC.Models.AppConfigration;

namespace TicketSystem.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //
            builder.Services.Configure<DataConfigration>(
                builder.Configuration.GetSection(DataConfigration.KeySection)
                );
            builder.Services.AddSingleton<IUtilities,Utilities>();
            //

            var connectionString = builder.Configuration.GetConnectionString("TicketsSystemDb");

            builder.Services.AddDbContext<SystemContext>(
                options=>options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IDepartmentRepository,DepartmentRepository>();
            builder.Services.AddScoped<ITicketRepository, TicketRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<ITicketManager, TicketManager>();
            builder.Services.AddScoped<IDepartmentManager, DepartmentManager>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
