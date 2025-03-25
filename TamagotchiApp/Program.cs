using Microsoft.EntityFrameworkCore;
using TamagotchiApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar Entity Framework con SQLite o SQL Server (según lo que uses)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=tamagotchi.db")); // O Usa SQL Server si lo prefieres

// Agregar servicios de MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pet}/{action=Index}/{id?}");

app.Run();
