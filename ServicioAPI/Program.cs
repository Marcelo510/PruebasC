using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new() { Title = "ServicioAPI", Version = "v1" });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=WeatherForecast}/{action=Get}/{id?}");
    //app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServicioAPI v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
////app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=WeatherForecast}/{action=Get}/{id?}");

app.Run();
