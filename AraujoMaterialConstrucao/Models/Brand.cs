namespace AraujoMaterialConstrucao.Models;

public class Brand
{
    public int BrandId { get; set; }
    public string Description { get; set; }
    public ICollection<Tile> Tiles { get; set; }
}
