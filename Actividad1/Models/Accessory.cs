namespace Actividad1.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

   
        // Devuelve un texto descriptivo del stock actual
        public string GetInventoryStatus()
        {
            if (Quantity == 0) return "OUT OF STOCK";
            if (Quantity < 5) return "LOW STOCK";
            return "IN STOCK";
        }

        //Calcula el costo total si un usuario quiere comprar múltiples unidades
        public decimal CalculateBulkCost(int requestedQuantity)
        {
            // La cantidad solicitada debe ser válida y no superar el stock
            if (requestedQuantity <= 0 || requestedQuantity > Quantity)
            {
                return 0;
            }
            return Price * requestedQuantity;
        }
    }
}
