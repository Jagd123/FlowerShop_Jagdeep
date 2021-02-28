using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FlowerShop_Jagdeep.BussLayer;
using FlowerShop_Jagdeep.Data;

namespace FlowerShop_Jagdeep.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly FlowerShop_Jagdeep.Data.ApplicationDbContext _context;

        public IndexModel(FlowerShop_Jagdeep.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BussLayer.Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
