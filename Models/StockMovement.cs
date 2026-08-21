using System.ComponentModel.DataAnnotations;
namespace InventoryWarehouseManagement.Models;
public class StockMovement
{
 public int Id {get;set;}
 [Required, StringLength(140)] public string Reference {get;set;} = string.Empty;
 [Required, StringLength(120)] public string MovementType {get;set;} = string.Empty;
 public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
}
