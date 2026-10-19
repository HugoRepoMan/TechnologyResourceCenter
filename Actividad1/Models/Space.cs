namespace Actividad1.Models
{
    public class Space
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public decimal HourlyRate { get; set; }
        public bool IsAvailable { get; set; }

        //Determina la disponibilidad
        public string GetAvailabilityStatus()
        {
            return IsAvailable ? "Valido" : "No es valido";
        }

        //Calcula el costo estimado
        public decimal CalculateEstimatedCost(int hours)
        {
            //Valida que las horas esten en un rango valido
            if (hours <= 0 || hours > 12)
            {
                return 0; 
            }

            return HourlyRate * hours;
        }
    }
}
