using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace AraujoMaterialConstrucao.Pages;

public class IndexModel : PageModel
{
    public IList<Tile> TilesList { get; private set; }
    public void OnGet()
    {
        var service = new TileService();

        TilesList = service.GetAll();
    }

}