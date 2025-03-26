

Este pequeño proyecto refleja la intención de mostrar mis habilidades en un entorno de .Net con la arquitectura de Modelo-Vista-Controlador.
Para hacerlo un poco ameno he escogido una mascota virtual o _Tamagotchi_ simple con atributos que se incrementan conforme se escogen las acciones pertinentes.

Pendiente:
Mejorar la interfaz gráfica
Añadir animaciones con Javascript
Diferentes ramas de desarrollo

# Puntos clave del proyecto:
- Tecnología ASP Net.
- Migraciones de base de datos SQLite (para uso local)
- MVC (Modelo Vista Controlador)
- Tests Unitarios con [xUnit](https://xunit.net/)
- html y css para mostrar la información

## Librerías usadas (y por qué)

### 1. xUnit
- Para las pruebas unitarias y garantizar que la lógica del código funcione correctamente.
### 2. Entity Framework Core
- Utilizado para interactuar con la base de datos SQLite mediante el ORM (Object-Relational Mapping). Facilita las operaciones de la base de datos, como insertar, actualizar y consultar las mascotas, sin tener que escribir SQL manualmente.
### 3. Microsoft.Extensions.DependencyInjection
- Esta librería permite gestionar la inyección de dependencias en la aplicación. Con ella he inyectado el DbContext en el controlador PetController para manejar las operaciones de la base de datos.
### 4. SQLite
- Base de datos local. Es ligera y se adapta bien a una aplicación pequeña como esta para almacenar el estado de la mascota (atributos como hambre, felicidad y energía).
