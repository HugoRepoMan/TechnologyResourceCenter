using System.Security.Cryptography.X509Certificates;

namespace Actividad1.Models
{
    public class Equipment
    {
        //Define los productos 
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal DailyRate { get; set; }
        public int Stock { get; set; }
        public bool IsOperational { get; set; }

        //Determina el estado del producto 
        public string GetStatus() 
        {
            if (!IsOperational)
            {
                return "Fuera de servicio";
            }
            else if (Stock == 0)
            {
                return "No valido";
            }
            else if (Stock == 1) {
                return "Ultima unidad";
            } else {
                return "Disponible";
            }
        }
        //Calcula el costo del alquiler
        public decimal CalculateEstimatedCost(int days)
        {
            //Valida que los dias de alquiler sean mayores a 0
            if (days <= 0) return 0;

            return DailyRate * days;
        }
    }
}
