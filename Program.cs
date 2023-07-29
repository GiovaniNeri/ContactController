using ContactController.DBContext;
using ContactController.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ContactController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
            builder.Services.AddControllersWithViews();
            var provider = builder.Services.BuildServiceProvider();
            var configuration =provider.GetRequiredService<IConfiguration>();
            builder.Services.AddDbContext<ContactContext>(item => item.UseSqlServer(configuration.GetConnectionString("Database")));
            var app = builder.Build();

            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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