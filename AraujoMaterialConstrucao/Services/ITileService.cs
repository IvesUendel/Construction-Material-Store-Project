using AraujoMaterialConstrucao.Models;

namespace AraujoMaterialConstrucao.Services;

public interface ITileService
{
	IList<Tile> GetAll();
	Tile GetItem(int id);
	void Include(Tile tile);
}
