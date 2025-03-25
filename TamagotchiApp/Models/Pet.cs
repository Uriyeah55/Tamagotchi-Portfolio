using System;

namespace TamagotchiApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hunger { get; set; } = 100;
        public int Happiness { get; set; } = 100;
        public int Energy { get; set; } = 100;
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
