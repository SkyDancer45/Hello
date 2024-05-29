using GameStore.Api.Dtos;
//using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<GameDto> games = [new(1, "COD", "Action", 50.0M, new DateOnly(2010, 09, 30)), new(2, "Witcher 3", "Fantasy", 52.0M, new DateOnly(2010, 09, 29))];
app.MapGet("games", () => games);

app.MapGet("/", () => "Hellosasadasdda World!");
app.MapPost("games", (CreateGameDto newGame) =>
{
    GameDto game = new GameDto(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
        );
    games.Add(game);
    return Results.Created();
});
app.MapPut("games/{id}", (int id, UpdateGameDto newGame) =>
{
    GameDto target = games.Find(game => game.Id == id);

});
Console.Write("Mooo");
app.Run();
