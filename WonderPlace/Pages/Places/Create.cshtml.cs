using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WonderPlace.Models;
using WonderPlace.Data;
using WonderPlace.Authorization;

namespace WonderPlace.Pages.Places
{
    public class CreateModel : DI_BasePageModel
    {

        public CreateModel(
    WonderPlaceContext _context,
    IAuthorizationService authorizationService,
    UserManager<IdentityUser> userManager)
    : base(_context, authorizationService, userManager)
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Place Place { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Place.Userid = UserManager.GetUserId(User);

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                          User, Place,
                                                          PlaceOperations.Create);

            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            _context.Place.Add(Place);
            await _context.SaveChangesAsync();

            return RedirectToPage("./AllPlace");
        }
    }
}