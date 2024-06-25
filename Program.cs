using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantPage.Data;
using Microsoft.AspNetCore.Identity;
using RestaurantPage.Models;
using Microsoft.AspNetCore.Builder;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RestaurantPageContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantPageContext") ?? throw new InvalidOperationException("Connection string 'RestaurantPageContext' not found.")));

builder.Services.AddDefaultIdentity<PageUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<RestaurantPageContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthentication();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Gallery",
    pattern: "{controller=Home}/{action=Gallery}/{id?}");
    

app.MapRazorPages();
app.Run();
