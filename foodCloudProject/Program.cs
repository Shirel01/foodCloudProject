using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using foodCloudProject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<foodCloudProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("foodCloudProjectContext") ?? throw new InvalidOperationException("Connection string 'foodCloudProjectContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Recipes}/{action=Index}/{id?}");// controller

app.Run();
