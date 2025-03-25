using Microsoft.AspNetCore.Mvc;
using TamagotchiApp.Data;
using TamagotchiApp.Models;

public class PetController : Controller
{
    private readonly AppDbContext _context;

    public PetController(AppDbContext context)
    {
        _context = context;
    }

    // Acción principal que muestra el estado del Tamagotchi
    public IActionResult Index()
    {
        var pet = _context.Pets.FirstOrDefault();
        if (pet == null)
        {
            pet = new Pet
            {
                Name = "Tamagotchi",
                Hunger = 50,
                Happiness = 70,
                Energy = 80,
                LastUpdated = DateTime.Now
            };

            _context.Pets.Add(pet);
            _context.SaveChanges();  // 🔥 Guarda la mascota en la base de datos
        }
        else
        {
            // 👀 Si el nombre es nulo o está vacío, le asignamos uno
            if (string.IsNullOrEmpty(pet.Name))
            {
                pet.Name = "nom test";
                _context.SaveChanges();
            }

            Console.WriteLine($"Mascota actual: ID = {pet.Id}, Nombre = {pet.Name}");
        }

        return View(pet);  // Pasar el objeto Pet a la vista
    }



    // Acción de Feed (alimentar al Tamagotchi)
    [HttpPost]
    public IActionResult Feed()
    {
        var pet = _context.Pets.FirstOrDefault();
        if (pet != null)
        {
            Console.WriteLine($"Antes: Hambre = {pet.Hunger}");  // 👀 Debug antes de actualizar

            pet.Hunger = Math.Max(0, pet.Hunger - 10);  // Reducir hambre
            pet.LastUpdated = DateTime.Now;
            _context.SaveChanges();

            Console.WriteLine($"Después: Hambre = {pet.Hunger}"); // 👀 Debug después de actualizar
        }

        return RedirectToAction("Index");
    }


    // Acciones para Play y Sleep pueden estar definidas de manera similar:
    [HttpPost]
    public IActionResult Play()
    {
        var pet = _context.Pets.FirstOrDefault();
        if (pet != null)
        {
            pet.Happiness = Math.Min(100, pet.Happiness + 10);  // Aumentar la felicidad
            pet.LastUpdated = DateTime.Now;
            _context.SaveChanges();
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Sleep()
    {
        var pet = _context.Pets.FirstOrDefault();
        if (pet != null)
        {
            pet.Energy = Math.Min(100, pet.Energy + 20);  // Aumentar la energía
            pet.LastUpdated = DateTime.Now;
            _context.SaveChanges();
        }

        return RedirectToAction("Index");
    }
}
