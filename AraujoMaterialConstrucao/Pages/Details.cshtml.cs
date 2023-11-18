using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AraujoMaterialConstrucao.Pages;

	public class DetailsModel : PageModel
{
    private ITileService _tileService;
    public DetailsModel(ITileService tileService)
    {
        _tileService = tileService;
    }
	public Tile Tile { get; private set; }
	public IActionResult OnGet(int id)
    {
        Tile = _tileService.GetItem(id);

        if(Tile == null)
        {
            return NotFound();
        }
        return Page();
    }
}
