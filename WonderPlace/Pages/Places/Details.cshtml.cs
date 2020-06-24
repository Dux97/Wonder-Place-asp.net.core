using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WonderPlace.Models;

namespace WonderPlace.Pages.Places
{
    public class DetailsModel : PageModel
    {
        private readonly WonderPlace.Models.WonderPlaceContext _context;

        public DetailsModel(WonderPlace.Models.WonderPlaceContext context)
        {
            _context = context;
        }

        public Place Place { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Place = await _context.Place.FirstOrDefaultAsync(m => m.ID == id);

            if (Place == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
