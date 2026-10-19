using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;
using Actividad1.Models;

namespace TechnologyResourceCenter.Controllers
{
    public class SpacesController : Controller
    {
        private static readonly List<Space> _spacesList = new()
        {
            new Space { Id = 1, Name = "Laboratorio de Computación", Location = "Edificio A, Piso 2", Capacity = 30, HourlyRate = 15.00m, IsAvailable = true },
            new Space { Id = 2, Name = "Sala Multimedia", Location = "Edificio B, Planta Baja", Capacity = 15, HourlyRate = 20.00m, IsAvailable = false },
            new Space { Id = 3, Name = "Sala de Streaming", Location = "Edificio B, Piso 1", Capacity = 4, HourlyRate = 10.00m, IsAvailable = true },
            new Space { Id = 4, Name = "Sala de Innovación", Location = "Edificio C, Piso 3", Capacity = 50, HourlyRate = 35.00m, IsAvailable = true },
            new Space { Id = 5, Name = "Laboratorio de Robótica", Location = "Edificio A, Sótano", Capacity = 20, HourlyRate = 25.00m, IsAvailable = false }
        };

        // Muestra todos los espacios
        public IActionResult Index()
        {
            return View(_spacesList);
        }

        //Muestra un espacio específico por su ID
        public IActionResult Details(int id)
        {
            Space? space = _spacesList.FirstOrDefault(s => s.Id == id);

            if (space is null)
                return NotFound();

            return View(space);
        }

        //Solo espacios disponibles
        public IActionResult Available()
        {
            //Busca únicamente los que tienen IsAvailable en 'true'
            var availableSpaces = _spacesList.Where(s => s.IsAvailable).ToList();
            return View(availableSpaces);
        }
    }
}