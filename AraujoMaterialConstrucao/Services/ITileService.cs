using AraujoMaterialConstrucao.Models;

namespace AraujoMaterialConstrucao.Services;

public interface ITileService
{
	IList<Tile> GetAll();
	Tile GetItem(int id);
	void Include(Tile tile);
	void Edit(Tile tile);
	void Delete(int id);
	IList<Brand> GetAllBrands();
}
