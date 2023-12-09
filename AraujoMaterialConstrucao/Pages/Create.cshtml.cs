using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;

namespace AraujoMaterialConstrucao.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private ITileService _tileService;
		public SelectList BrandOptionItems { get; set; }
		public void OnGet()
		{
			BrandOptionItems = new SelectList(_tileService.GetAllBrands(),
			                                        nameof(Brand.BrandId),
			                                    nameof(Brand.Description));
		}
		public CreateModel(ITileService tileService)
        {
            _tileService = tileService;
        }
        [BindProperty]
        public Tile Tile { get; set; }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid) 
            {
                return Page();
            }

            _tileService.Include(Tile);

            return RedirectToPage("/Index");
        }
    }
}
