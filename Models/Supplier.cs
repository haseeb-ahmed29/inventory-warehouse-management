using System.ComponentModel.DataAnnotations;
namespace InventoryWarehouseManagement.Models;
public class Supplier
{
 public int Id {get;set;}
 [Required, StringLength(140)] public string SupplierName {get;set;} = string.Empty;
 [Required, StringLength(120)] public string ContactEmail {get;set;} = string.Empty;
 public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
}
