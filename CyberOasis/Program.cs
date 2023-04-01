using Microsoft.EntityFrameworkCore;
using CyberOasis.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using CyberOasis.Interfaces;
using CyberOasis.Services;

namespace CyberOasis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CyberOasisContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CyberOasisContext") ?? throw new InvalidOperationException("Connection string 'CyberOasisContext' not found.")));

            builder.Services.AddControllersWithViews();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                            .AddCookie(option =>
                            {
                                option.LoginPath = "/Login/Index";
                                option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                            });

            /* Adding CyberOasis Services */
            //builder.Services.AddSingleton<IUserService, UserService>();
            //builder.Services.AddSingleton<ILoginService, LoginService>();

            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}