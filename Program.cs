using Microsoft.EntityFrameworkCore;
using InventoryWarehouseManagement.Data;
using InventoryWarehouseManagement.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    if (!db.InventoryItems.Any())
    {
        db.InventoryItems.Add(new InventoryItem { Name = "Sample InventoryItem", Description = "Replace this seeded record with real inventory & warehouse management data.", Status = "Active", CreatedAt = DateTime.UtcNow });
        db.SaveChanges();
    }
}
if (!app.Environment.IsDevelopment()) { app.UseExceptionHandler("/Home/Error"); app.UseHsts(); }
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
