using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WonderPlace.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using WonderPlace.Authorization;

namespace WonderPlace.Pages.Places
{
    [Authorize]
    public class AllPlaceModel : DI_BasePageModel
    {


        //private readonly WonderPlace.Models.WonderPlaceContext _context;

        //public AllPlaceModel(WonderPlace.Models.WonderPlaceContext context)
        //{
        //    _context = context;
        //}

        public AllPlaceModel(
 WonderPlaceContext context,
 IAuthorizationService authorizationService,
 UserManager<IdentityUser> userManager)
 : base(context, authorizationService, userManager)
        {
        }

        public IList<Place> Place { get;set; }
        [BindProperty(SupportsGet = true)]
        public string searchString { get; set; }
        public SelectList Kontynents { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PlaceKontynent { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> KontynentQuery = from m in _context.Place
                                            orderby m.Kontynent
                                            select m.Kontynent;
             
        var places = from m in _context.Place
                         select m;

            var isAuthorized = User.IsInRole(Constants.ContactManagersRole) ||
                          User.IsInRole(Constants.ContactAdministratorsRole);

            var currentUserId = UserManager.GetUserId(User);

            if (!isAuthorized)
            {
               places = places.Where(c => c.Status == PlaceStatus.Approved
                                            || c.Userid == currentUserId);
            }


            if (!string.IsNullOrEmpty(searchString))
            {
                places = places.Where(s => s.Miejsce.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(PlaceKontynent))
            {
                places = places.Where(x => x.Kontynent == PlaceKontynent);
            }

            Kontynents = new SelectList(await KontynentQuery.Distinct().ToListAsync());
            Place = await places.ToListAsync();
        }
    }
}
