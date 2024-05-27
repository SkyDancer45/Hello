using GameStore.Api.Dtos;
//using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<GameDto> games = [new(1, "COD", "Action", 50.0M, new DateOnly(2010, 09, 30))];
app.MapGet("games", () => games[0].Name);

app.MapGet("/", () => "Hellosasadasdda World!");
Console.Write("Mooo");
app.Run();
