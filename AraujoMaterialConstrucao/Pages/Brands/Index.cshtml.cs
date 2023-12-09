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
    public class IndexModel : PageModel
    {
        private readonly AraujoMaterialConstrucao.Data.MaterialConstructionDbContext _context;

        public IndexModel(AraujoMaterialConstrucao.Data.MaterialConstructionDbContext context)
        {
            _context = context;
        }

        public IList<Brand> Brand { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Brand != null)
            {
                Brand = await _context.Brand.ToListAsync();
            }
        }
    }
}
