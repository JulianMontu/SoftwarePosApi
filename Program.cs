using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftWarePos.Models;

var builder = WebApplication.CreateBuilder(args);
var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
builder.Services.AddDbContext<dbposrcContext>(options =>
    {
        options.UseMySql(builder.Configuration.GetConnectionString("cnPos"),serverVersion);
    });
var app = builder.Build();

app.MapGet("/dbconexion", async ([FromServices] dbposrcContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos conectada: " + dbContext.Database.IsMySql());
});

//ConsultarProductos
app.MapGet("/api/productos", async ([FromServices] dbposrcContext dbContext) =>
{
     return Results.Ok(dbContext.TProductos);
});

app.MapGet("/api/cuentasp", async ([FromServices] dbposrcContext dbContext) =>
{
     return Results.Ok(dbContext.TCuentasProductos.FirstOrDefault());
});
//Consultar cuenta
app.MapGet("/api/cuentasp/{id}", async ([FromServices] dbposrcContext dbContext,[FromRoute] uint id) =>
{
    var cuentaActual = dbContext.TCuentasProductos.Find(id);
    if(cuentaActual != null)
    {
        return Results.Ok(cuentaActual);
    }
    return Results.NotFound();
});
//Crear cuenta
app.MapPost("/api/cuentasp",async ([FromServices] dbposrcContext dbContext,[FromBody] TCuentasProducto cuentas )=>
{
    await dbContext.AddAsync(cuentas);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});
app.Run();
