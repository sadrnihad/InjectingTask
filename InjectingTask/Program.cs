using Microsoft.EntityFrameworkCore;
using MVCProniaApp.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=PustoDb;Trusted_Connection=true;Encrypt=false");
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();