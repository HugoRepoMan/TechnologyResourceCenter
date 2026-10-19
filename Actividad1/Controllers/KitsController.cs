using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;
using Actividad1.Models;

namespace TechnologyResourceCenter.Controllers
{
    public class KitsController : Controller
    {
        // Lista estática con los 10 Kits requeridos
        private static readonly List<Kit> _kitsList = new()
        {
            new Kit { Id = 1, Name = "Kit de Inicio Arduino", Category = "Electrónica", Level = "PRINCIPIANTE", DailyRate = 8.00m, Quantity = 15, IsOperational = true },
            new Kit { Id = 2, Name = "Kit Básico de Electrónica", Category = "Electrónica", Level = "PRINCIPIANTE", DailyRate = 5.00m, Quantity = 10, IsOperational = true },
            new Kit { Id = 3, Name = "Kit de Podcast", Category = "Audio", Level = "PRINCIPIANTE", DailyRate = 12.00m, Quantity = 6, IsOperational = true },
            new Kit { Id = 4, Name = "Kit de Fotografía", Category = "Multimedia", Level = "PRINCIPIANTE", DailyRate = 18.00m, Quantity = 0, IsOperational = true },
            new Kit { Id = 5, Name = "Kit IoT", Category = "Internet de las Cosas", Level = "INTERMEDIO", DailyRate = 15.00m, Quantity = 8, IsOperational = true },
            new Kit { Id = 6, Name = "Kit de Robótica", Category = "Robótica", Level = "INTERMEDIO", DailyRate = 20.00m, Quantity = 5, IsOperational = true },
            new Kit { Id = 7, Name = "Kit de Streaming", Category = "Multimedia", Level = "INTERMEDIO", DailyRate = 10.00m, Quantity = 4, IsOperational = false },
            new Kit { Id = 8, Name = "Kit de Inteligencia Artificial", Category = "IA", Level = "AVANZADO", DailyRate = 35.00m, Quantity = 2, IsOperational = true },
            new Kit { Id = 9, Name = "Kit de Redes Avanzadas", Category = "Redes", Level = "AVANZADO", DailyRate = 25.00m, Quantity = 3, IsOperational = true },
            new Kit { Id = 10, Name = "Kit de Realidad Virtual", Category = "RV", Level = "AVANZADO", DailyRate = 40.00m, Quantity = 1, IsOperational = true }
        };

        //Mostrar todos los kits
        public IActionResult Index()
        {
            return View(_kitsList);
        }

        //Mostrar detalle de un kit específico
        public IActionResult Details(int id)
        {
            Kit? kit = _kitsList.FirstOrDefault(k => k.Id == id);

            if (kit is null)
                return NotFound();

            return View(kit);
        }

        //Agrupar por nivel
        public IActionResult ByLevel()
        {
            //Ordenar la lista por nivel alfabéticamente 
            var kitsOrderedByLevel = _kitsList.OrderBy(k => k.Level).ToList();
            return View(kitsOrderedByLevel);
        }
    }
}