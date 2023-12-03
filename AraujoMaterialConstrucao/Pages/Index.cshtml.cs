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
        TilesList = _tileService.GetAll();
    }

}