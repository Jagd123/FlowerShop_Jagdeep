using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FlowerShop_Jagdeep.BussLayer;
using FlowerShop_Jagdeep.Data;

namespace FlowerShop_Jagdeep.Pages.Flower
{
    public class DeleteModel : PageModel
    {
        private readonly FlowerShop_Jagdeep.Data.ApplicationDbContext _context;

        public DeleteModel(FlowerShop_Jagdeep.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BussLayer.Flower Flower { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flower = await _context.Flower.FirstOrDefaultAsync(m => m.ID == id);

            if (Flower == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flower = await _context.Flower.FindAsync(id);

            if (Flower != null)
            {
                _context.Flower.Remove(Flower);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
