using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Suciu_Denisa_Camelia_proiect.Data;
using Suciu_Denisa_Camelia_proiect.Models;

namespace Suciu_Denisa_Camelia_proiect.Pages.Suppliers
{
    public class DetailsModel : PageModel
    {
        private readonly Suciu_Denisa_Camelia_proiect.Data.Suciu_Denisa_Camelia_proiectContext _context;

        public DetailsModel(Suciu_Denisa_Camelia_proiect.Data.Suciu_Denisa_Camelia_proiectContext context)
        {
            _context = context;
        }

      public Supplier Supplier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await _context.Suppliers.FirstOrDefaultAsync(m => m.ID == id);
            if (supplier == null)
            {
                return NotFound();
            }
            else 
            {
                Supplier = supplier;
            }
            return Page();
        }
    }
}
