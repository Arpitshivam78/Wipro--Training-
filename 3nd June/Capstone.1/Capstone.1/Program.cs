using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Capstone._1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Capstone_1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Capstone_1Context") ?? throw new InvalidOperationException("Connection string 'Capstone_1Context' not found.")));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
