using AraujoMaterialConstrucao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AraujoMaterialConstrucao.Pages
{
    public class InsertModel : PageModel
    {
        [BindProperty]
        public Tile Tile { get; set; }

        public IActionResult OnPost() 
        {
            return RedirectToPage("/Index");
        }
    }
}
