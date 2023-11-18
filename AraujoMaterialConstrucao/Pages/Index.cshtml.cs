using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace AraujoMaterialConstrucao.Pages;

public class IndexModel : PageModel
{
    private ITileService _tileService;
    public IndexModel(ITileService tileService)
    { 
        _tileService = tileService;
    }
    public IList<Tile> TilesList { get; private set; }
    public void OnGet()
    {
        //var service = new TileService();

        TilesList = _tileService.GetAll();
    }

}