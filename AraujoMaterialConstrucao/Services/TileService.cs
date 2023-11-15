using AraujoMaterialConstrucao.Models;

namespace AraujoMaterialConstrucao.Services;

public class TileService
{
	public IList<Tile> GetAll()
	{
		return new List<Tile>()
		{
			new Tile
			{
				TileId = 1,
				Name = "Archaic Tile",
				Description = "Relive the past with our ancient tile model. Intricate patterns and a rich palette bring historical elegance to any space.",
				ImageUri = "/images/piso-1.jpg",
				RegistrationDate = DateTime.Now,
				ExpressDelivery = true,
				Price = 14.99,
			},
			new Tile
			{
				TileId = 2,
				Name = "Brick Tile",
				Description = "Discover timeless charm with our brick-patterned tile. A blend of rusticity and elegance to transform your spaces.",
				ImageUri = "/images/piso-2.jpg",
				RegistrationDate = DateTime.Now,
				ExpressDelivery = true,
				Price = 23.99,
			},
			new Tile
			{
				TileId = 3,
				Name = "White Brick Tile",
				Description = "Elegance in every detail. The white brick-patterned tile offers sophistication and brightness, transforming your spaces with a modern touch.",
				ImageUri = "/images/piso-3.jpg",
				RegistrationDate = DateTime.Now,
				ExpressDelivery = true,
				Price = 27.99,
			},
			new Tile
			{
				TileId = 4,
				Name = "Black and White Tile",
				Description = "Modern in black and white. The tile features a bold design, blending contemporary elegance with white details for a distinctive touch.",
				ImageUri = "/images/piso-4.jpg",
				RegistrationDate = DateTime.Now,
				ExpressDelivery = true,
				Price = 19.99,
			},
		};
	}

	public Tile GetItem(int id)
	{
		return GetAll().SingleOrDefault(item => item.TileId == id);
		
	}
}
