using Microsoft.EntityFrameworkCore;
using InventoryWarehouseManagement.Models;

namespace InventoryWarehouseManagement.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();
 public DbSet<Supplier> Suppliers => Set<Supplier>();
 public DbSet<StockMovement> StockMovements => Set<StockMovement>();
}
