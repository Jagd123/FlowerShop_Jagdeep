using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FlowerShop_Jagdeep.BussLayer;
using FlowerShop_Jagdeep.Data;

namespace FlowerShop_Jagdeep.Pages.Customer
{
    public class DetailsModel : PageModel
    {
        private readonly FlowerShop_Jagdeep.Data.ApplicationDbContext _context;

        public DetailsModel(FlowerShop_Jagdeep.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public BussLayer.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer
                .Include(c => c.Employee)
                .Include(c => c.Flower).FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
