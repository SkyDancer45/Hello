using GameStore.Api.Dtos;
//using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<GameDto> games = [new(1, "COD", "Action", 50.0M, new DateOnly(2010, 09, 30)), new(2, "Witcher 3", "Fantasy", 52.0M, new DateOnly(2010, 09, 29))];
app.MapGet("games", () => games[0].Name);

// app.MapGet("/", () => "Hellosasadasdda World!");
Console.Write("Mooo");
//GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id));
app.MapPost("games",(CreateGameDtos newGame)=>{

});
app.Run();
