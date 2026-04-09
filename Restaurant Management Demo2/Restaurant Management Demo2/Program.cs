using Microsoft.EntityFrameworkCore;
using Restaurant_Management_Demo2.Models;
using Restaurant_Management_Demo2.Models.Repo.RepoClas;
using Restaurant_Management_Demo2.Models.Repo.RepoInterface;

namespace Restaurant_Management_Demo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<RestaurantManagementContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<ICategory,  CategoryRepo>();
            builder.Services.AddScoped<IMenuItem, MenuItemRepo>();
            builder.Services.AddScoped<IOrder, OrderRepo>();
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
