namespace GameStore.Api.Dtos;

public record class UpdateGameDto
{
  public string Name { get; init; }
  public string Genre { get; init; }
  public decimal Price { get; init; }
  public DateOnly ReleaseDate { get; init; }


}

