namespace GameStore.Api.Dtos;

public record class CreateGameDtos
{
    int Id;
    string Name;
    string Genre;
    decimal Price;
    DateOnly ReleaseDate;

}
