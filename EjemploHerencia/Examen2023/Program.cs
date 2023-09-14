using Context;
using Microsoft.EntityFrameworkCore;
using Repositorio;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(configure =>
{
    configure.ReturnHttpNotAcceptable = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRepositorioPersona, RepositorioPersona>();

builder.Services.AddDbContext<ContextoPersona>(options =>
          {
              options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
          });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});


var app = builder.Build();
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.MapControllers();
app.Run();