using FIFA.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


    builder.Services.AddDbContext<FIFA.API.Data.DataContext>(x => x.UseSqlServer("name=DefaultConnection"));
// Se hace esta inyección de servicio del SQL Server

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); app.UseCors(x => x
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true)
.AllowCredentials());

// Los Cors se usan para que todo el mundo no pueda consumir mi API, solo quien yo diga
// eso incluye metodos, encabezados, credenciales, respuestas.


app.MapControllers();



app.Run();
