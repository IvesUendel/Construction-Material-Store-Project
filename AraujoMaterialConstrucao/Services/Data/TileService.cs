using AraujoMaterialConstrucao.Data;
using AraujoMaterialConstrucao.Models;

namespace AraujoMaterialConstrucao.Services.Data;

public class TileService : ITileService
{
    private MaterialConstructionDbContext _context;

    public TileService(MaterialConstructionDbContext context) 
    { 
        _context = context;
    }

    public void Delete(int id)
    {
        var tileFound = GetItem(id);
        _context.Tile.Remove(tileFound);
        _context.SaveChanges();
    }

    public void Edit(Tile tile)
    {
        var tileFound = GetItem(tile.TileId);
        tileFound.Name = tile.Name;
        tileFound.Description = tile.Description;
        tileFound.Price = tile.Price;
        tileFound.ExpressDelivery = tile.ExpressDelivery;
        tileFound.RegistrationDate = tile.RegistrationDate;
        tileFound.ImageUri = tile.ImageUri;

        _context.SaveChanges();
    }

    public IList<Tile> GetAll()
    {
        return _context.Tile.ToList();
    }

    public Tile GetItem(int id)
    {
        return _context.Tile.SingleOrDefault(item => item.TileId == id);
    }

    public void Include(Tile tile)
    {
        _context.Tile.Add(tile);
        _context.SaveChanges();
    }
}
