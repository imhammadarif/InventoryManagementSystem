namespace InventoryManagement.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensures Name is initialized
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
