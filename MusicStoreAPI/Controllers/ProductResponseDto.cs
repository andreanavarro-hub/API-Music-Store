namespace MusicStoreAPI.Controllers;

public class ProductResponseDto
{
    public int Id { get; set; } = Random.Shared.Next();
    public string NameCD { get; set; } = String.Empty;
    public string Artist { get; set; } = String.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
