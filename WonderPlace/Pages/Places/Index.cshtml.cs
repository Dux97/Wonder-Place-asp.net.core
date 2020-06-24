using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WonderPlace.Models;

namespace WonderPlace.Pages.Places
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly WonderPlace.Models.WonderPlaceContext _context;

        public IndexModel(WonderPlace.Models.WonderPlaceContext context)
        {
            _context = context;
        }

        public IList<Place> Place { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            var places = from m in _context.Place
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                places = places.Where(s => s.Kontynent.Contains(searchString));
            }

            Place = await places.ToListAsync();
        }
    }
    
}
