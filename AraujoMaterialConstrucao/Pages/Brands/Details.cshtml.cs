using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AraujoMaterialConstrucao.Data;
using AraujoMaterialConstrucao.Models;

namespace AraujoMaterialConstrucao.Pages.Brands
{
    public class DetailsModel : PageModel
    {
        private readonly AraujoMaterialConstrucao.Data.MaterialConstructionDbContext _context;

        public DetailsModel(AraujoMaterialConstrucao.Data.MaterialConstructionDbContext context)
        {
            _context = context;
        }

      public Brand Brand { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Brand == null)
            {
                return NotFound();
            }

            var brand = await _context.Brand.FirstOrDefaultAsync(m => m.BrandId == id);
            if (brand == null)
            {
                return NotFound();
            }
            else 
            {
                Brand = brand;
            }
            return Page();
        }
    }
}
