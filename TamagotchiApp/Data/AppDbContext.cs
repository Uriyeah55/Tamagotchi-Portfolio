using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TamagotchiApp.Models;

namespace TamagotchiApp.Data
{
    //Simulación de base de datos real
    public class AppDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
