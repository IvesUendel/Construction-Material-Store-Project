using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AraujoMaterialConstrucao.Pages;

	public class DetailsModel : PageModel
{
	public Tile Tile { get; private set; }
	public void OnGet(int id)
    {
        var service = new TileService();
        Tile = service.GetItem(id);
    }
}
