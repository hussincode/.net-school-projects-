using Hotel_Management_System.Models;
using Hotel_Management_System.Repo.RepoClass;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<HotelContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DB")));

            builder.Services.AddScoped<IUsers, UserRepo>();
            builder.Services.AddScoped<IRooms, RoomRepo>();
            builder.Services.AddScoped<IServiceTypes, ServiceTypesRepo>();
            builder.Services.AddScoped<IBookingRecords, BookingRecordRepo>();

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
