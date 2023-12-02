using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AraujoMaterialConstrucao.Pages
{
    public class EditModel : PageModel
    {
		private ITileService _tileService;
		public SelectList BrandOptionItems { get; set; }
		public EditModel(ITileService tileService)
		{
			_tileService = tileService;
		}

		[BindProperty]
		public Tile Tile { get; set; }

		public void OnGet(int id)
		{
			Tile = _tileService.GetItem(id);
			BrandOptionItems = new SelectList(_tileService.GetAllBrands(),
													nameof(Brand.BrandId),
												nameof(Brand.Description));
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_tileService.Edit(Tile);

			return RedirectToPage("/Index");
		}

		public IActionResult OnPostDelete()
		{

			_tileService.Delete(Tile.TileId);

            TempData["TempMenssageSuccess"] = true;

            return RedirectToPage("/Index");
		}
	}
}
