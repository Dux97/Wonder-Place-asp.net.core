using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WonderPlace.Authorization;
using WonderPlace.Models;

namespace WonderPlace.Pages.Places
{
    public class EditModel : DI_BasePageModel
    {
        //private readonly WonderPlace.Models.WonderPlaceContext _context;

        //public EditModel(WonderPlace.Models.WonderPlaceContext context)
        //{
        //    _context = context;
        //}

        public EditModel(
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
                                          PlaceOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var place = await _context
    .Place.AsNoTracking()
    .FirstOrDefaultAsync(m => m.ID == id);

            if (place == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                     User, Place,
                                                     PlaceOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            Place.Userid = place.Userid;

            _context.Attach(Place).State = EntityState.Modified;

            if (place.Status == PlaceStatus.Approved)
            {
                // If the contact is updated after approval, 
                // and the user cannot approve,
                // set the status back to submitted so the update can be
                // checked and approved.
                var canApprove = await AuthorizationService.AuthorizeAsync(User,
                                        place,
                                        PlaceOperations.Approve);

                if (!canApprove.Succeeded)
                {
                    place.Status = PlaceStatus.Submitted;
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool PlaceExists(int id)
        {
            return _context.Place.Any(e => e.ID == id);
        }
    }
}
