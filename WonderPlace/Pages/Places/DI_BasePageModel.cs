using WonderPlace.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WonderPlace.Models;

namespace WonderPlace.Pages.Places
{
    public class DI_BasePageModel : PageModel
    {
        protected WonderPlaceContext _context { get; }
        protected IAuthorizationService AuthorizationService { get; }
        protected UserManager<IdentityUser> UserManager { get; }

        public DI_BasePageModel(
            WonderPlaceContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager) : base()
        {
            _context = context;
            UserManager = userManager;
            AuthorizationService = authorizationService;
        }
    }
}