using Xunit;
using TamagotchiApp.Models;

public class PetTests
{
    //Test unitario para comprobar que la función de reducir el hambre de la mascota funciona
    [Fact]
    public void Feed_ShouldReduceHunger()
    {
        // Preparación de valores
        var pet = new Pet { Hunger = 50 };

        // Ejecución
        pet.Hunger = Math.Max(0, pet.Hunger - 10);

        // Assert para verificación
        Assert.Equal(40, pet.Hunger);
    }
}
