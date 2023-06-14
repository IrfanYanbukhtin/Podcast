using Microsoft.EntityFrameworkCore;
using Podcast.DAL;
using System;

namespace Podcast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSession(option =>
            {
                option.Cookie.Name = "MySession";
                option.IdleTimeout = TimeSpan.FromMinutes(5);
            });      

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(builder =>
            {
                builder.UseSqlServer(connectionString);
            });

            var app = builder.Build();


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "areas",
                        pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

            app.Run();
        }
    }
}