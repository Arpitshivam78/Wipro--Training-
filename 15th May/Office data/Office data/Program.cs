using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Office_data.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Office_dataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Office_dataContext") ?? throw new InvalidOperationException("Connection string 'Office_dataContext' not found.")));

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
