namespace Actividad1.Models
{
    public class Kit
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty; 
        public decimal DailyRate { get; set; }
        public int Quantity { get; set; }
        public bool IsOperational { get; set; }

        //Determina el estado actual combinando Cantidad y Condición Operativa
        public string GetState()
        {
            if (!IsOperational) return "NEEDS REPAIR";
            if (Quantity == 0) return "OUT OF STOCK";
            if (Quantity <= 2) return "LOW STOCK";
            return "AVAILABLE";
        }

        //Calcula el costo estimado de alquiler
        public decimal CalculateEstimatedCost(int days)
        {
            // Los días solicitados deben ser mayores a cero
            if (days <= 0) return 0;
            return DailyRate * days;
        }
    }
}
