using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Suciu_Denisa_Camelia_proiect.Data;
using Suciu_Denisa_Camelia_proiect.Models;

namespace Suciu_Denisa_Camelia_proiect.Pages.Suppliers
{
    public class CreateModel : PageModel
    {
        private readonly Suciu_Denisa_Camelia_proiect.Data.Suciu_Denisa_Camelia_proiectContext _context;

        public CreateModel(Suciu_Denisa_Camelia_proiect.Data.Suciu_Denisa_Camelia_proiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Supplier Supplier { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Suppliers.Add(Supplier);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
