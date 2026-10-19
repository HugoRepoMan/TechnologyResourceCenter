using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;
using Actividad1.Models;

namespace Actividad1.Controllers
{
    public class EquipmentController : Controller
    {
        private static readonly List<Equipment> _equipmentList = new()
        {
            new Equipment { Id = 1, Name = "Latitude 5550", Category = "Computación", Brand = "Dell", DailyRate = 25.00m, Stock = 4, IsOperational = true },
            new Equipment { Id = 2, Name = "MacBook Pro M3", Category = "Computación", Brand = "Apple", DailyRate = 45.00m, Stock = 1, IsOperational = true },
            new Equipment { Id = 3, Name = "EcoTank 4800", Category = "Impresión", Brand = "Epson", DailyRate = 15.00m, Stock = 0, IsOperational = true },
            new Equipment { Id = 4, Name = "Catalyst 9200", Category = "Redes", Brand = "Cisco", DailyRate = 35.00m, Stock = 5, IsOperational = false },
            new Equipment { Id = 5, Name = "Alpha a7 III", Category = "Fotografía", Brand = "Sony", DailyRate = 40.00m, Stock = 2, IsOperational = true },
            new Equipment { Id = 6, Name = "iPad Pro 12.9", Category = "Tableta", Brand = "Apple", DailyRate = 30.00m, Stock = 3, IsOperational = true },
            new Equipment { Id = 7, Name = "Galaxy Tab S9", Category = "Tableta", Brand = "Samsung", DailyRate = 25.00m, Stock = 1, IsOperational = true },
            new Equipment { Id = 8, Name = "ThinkPad T14", Category = "Computación", Brand = "Lenovo", DailyRate = 22.00m, Stock = 8, IsOperational = true },
            new Equipment { Id = 9, Name = "UniFi 6 Lite", Category = "Redes", Brand = "Ubiquiti", DailyRate = 10.00m, Stock = 12, IsOperational = true },
            new Equipment { Id = 10, Name = "Micrófono SM7B", Category = "Audio", Brand = "Shure", DailyRate = 18.00m, Stock = 0, IsOperational = true },
            new Equipment { Id = 11, Name = "Wireless GO II", Category = "Audio", Brand = "Rode", DailyRate = 20.00m, Stock = 2, IsOperational = true },
            new Equipment { Id = 12, Name = "UltraSharp 27", Category = "Monitor", Brand = "Dell", DailyRate = 15.00m, Stock = 6, IsOperational = true },
            new Equipment { Id = 13, Name = "Cámara EOS R5", Category = "Fotografía", Brand = "Canon", DailyRate = 50.00m, Stock = 1, IsOperational = true },
            new Equipment { Id = 14, Name = "Cámara web Brio 4K", Category = "Video", Brand = "Logitech", DailyRate = 12.00m, Stock = 4, IsOperational = false },
            new Equipment { Id = 15, Name = "Nighthawk AX12", Category = "Redes", Brand = "Netgear", DailyRate = 15.00m, Stock = 3, IsOperational = true },
            new Equipment { Id = 16, Name = "Tableta Cintiq 16", Category = "Dibujo", Brand = "Wacom", DailyRate = 28.00m, Stock = 2, IsOperational = true },
            new Equipment { Id = 17, Name = "Proyector TK850i", Category = "Monitor", Brand = "BenQ", DailyRate = 35.00m, Stock = 0, IsOperational = false },
            new Equipment { Id = 18, Name = "ROG Zephyrus G14", Category = "Computación", Brand = "Asus", DailyRate = 40.00m, Stock = 1, IsOperational = true },
            new Equipment { Id = 19, Name = "WH-1000XM5", Category = "Audio", Brand = "Sony", DailyRate = 15.00m, Stock = 5, IsOperational = true },
            new Equipment { Id = 20, Name = "PowerEdge R740", Category = "Servidor", Brand = "Dell", DailyRate = 100.00m, Stock = 1, IsOperational = true }
        };

        //Mostrar todos los equipos
        public IActionResult Index()
        {
            return View(_equipmentList);
        }
        //Mostrar a detalle un equipo en especifico
        public IActionResult Details(int id)
        {
            // Valida que el objeto solicitado exista
            Equipment? equipment = _equipmentList.FirstOrDefault(e => e.Id == id);
            if (equipment is null)
            {
                return NotFound(); // Retorna error 404 
            }
            return View(equipment);
        }
        //Muestra solo equipos disponibles para rentar 
        public IActionResult Available()
        {
            // Se filtra usando LINQ, buscando solo los que estan operativos y tengan stock
            var availableEquipment = _equipmentList
                .Where(e => e.IsOperational && e.Stock > 0)
                .ToList();

            return View(availableEquipment);
        }
    }
}
