using Microsoft.EntityFrameworkCore;
using RedeHotel.Lib.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RedeHotelContext>(
conn =>
conn.UseNpgsql(builder.Configuration.GetConnectionString("RedeHotel").UseCamelCaseNamingConvention()));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
