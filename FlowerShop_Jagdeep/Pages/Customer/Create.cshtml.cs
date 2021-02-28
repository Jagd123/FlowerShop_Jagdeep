using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FlowerShop_Jagdeep.BussLayer;
using FlowerShop_Jagdeep.Data;

namespace FlowerShop_Jagdeep.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly FlowerShop_Jagdeep.Data.ApplicationDbContext _context;

        public CreateModel(FlowerShop_Jagdeep.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EmployeeID"] = new SelectList(_context.Employee, "ID", "Name");
        ViewData["FlowerID"] = new SelectList(_context.Flower, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public BussLayer.Customer Customer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
