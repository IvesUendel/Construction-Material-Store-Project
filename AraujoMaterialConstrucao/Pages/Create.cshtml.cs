using AraujoMaterialConstrucao.Models;
using AraujoMaterialConstrucao.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AraujoMaterialConstrucao.Pages
{
    public class InsertModel : PageModel
    {
        private ITileService _tileService;
        public InsertModel(ITileService tileService)
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
