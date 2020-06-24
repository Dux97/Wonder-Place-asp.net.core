using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WonderPlace.Authorization;
using WonderPlace.Models;

namespace WonderPlace.Pages.Places
{
    public class DeleteModel : DI_BasePageModel
    {
        //private readonly WonderPlace.Models.WonderPlaceContext _context;

        //public DeleteModel(WonderPlace.Models.WonderPlaceContext context)
        //{
        //    _context = context;
        //}

        public DeleteModel(
            WonderPlaceContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager)
            : base(context, authorizationService, userManager)
        {
        }


        [BindProperty]
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

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                         User, Place,
                                         PlaceOperations.Delete);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Place = await _context.Place.FindAsync(id);
            var place = await _context
          .Place.AsNoTracking()
          .FirstOrDefaultAsync(m => m.ID == id);

            if (Place == null)
            {
                return NotFound();
                
            }
            _context.Place.Remove(Place);
            await _context.SaveChangesAsync();
            return RedirectToPage("./AllPlace");
        }
    }
}
