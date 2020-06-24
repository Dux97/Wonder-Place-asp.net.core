using WonderPlace.Authorization;
using WonderPlace.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using WonderPlace.Data;


namespace WonderPlace.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider/*, string testUserPw*/)
        {
            using (var context = new WonderPlaceContext(
                serviceProvider.GetRequiredService<
                   DbContextOptions<WonderPlaceContext>>()))
            {
                //For sample purposes seed both with the same password.
                //Password is set with the following:
                // dotnet user-secrets set SeedUserPW<pw>
                // The admin user can do anything

                //        var adminID = await EnsureUser(serviceProvider, testUserPw, "admin@contoso.com");
                //        await EnsureRole(serviceProvider, adminID, Constants.ContactAdministratorsRole);

                //        // allowed user can create and edit contacts that they create
                //        var managerID = await EnsureUser(serviceProvider, testUserPw, "manager@contoso.com");
                //        await EnsureRole(serviceProvider, managerID, Constants.ContactManagersRole);

                //        SeedDB(context, adminID);
                //    }
                //}

                //private static async Task<string> EnsureUser(IServiceProvider serviceProvider,
                //                                            string testUserPw, string UserName)
                //{
                //    var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

                //    var user = await userManager.FindByNameAsync(UserName);
                //    if (user == null)
                //    {
                //        user = new IdentityUser { UserName = UserName };
                //        await userManager.CreateAsync(user, testUserPw);
                //    }

                //    return user.Id;
                //}

                //private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider,
                //                                                              string uid, string role)
                //{
                //    IdentityResult IR = null;
                //    var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

                //    if (roleManager == null)
                //    {
                //        throw new Exception("roleManager null");
                //    }

                //    if (!await roleManager.RoleExistsAsync(role))
                //    {
                //        IR = await roleManager.CreateAsync(new IdentityRole(role));
                //    }

                //    var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

                //    var user = await userManager.FindByIdAsync(uid);

                //    if (user == null)
                //    {
                //        throw new Exception("The testUserPw password was probably not strong enough!");
                //    }

                //    IR = await userManager.AddToRoleAsync(user, role);

                //    return IR;
                //}
                //public static void SeedDB(WonderPlaceContext context, string adminID)
                //{

                if (context.Place.Any())
                {
                    return;
                }

                context.Place.AddRange(
                    new Place
                    {
                        Kraj = "Gwatemala",
                        Opis = "W sercu gwatemalskiej dżungli leży Tikal, najważniejsze ruiny Majów. Wpisane na listę światowego dziedzictwa UNESCO miasto składa się z 6 częściowo odrestaurowanych piramid i setek malowniczych, kamiennych ruin.",
                        Miejsce = "Tikal",
                        Zdjecie = "https://cache-graphicslib.viator.com/graphicslib/page-images/742x525/116000_B_Guatemala_Tikal_shutterstock_000021688951.jpg",
                        Kontynent = "Ameryka Południowa",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    },

                    new Place
                    {
                        Kraj = "Peru ",
                        Opis = "Zostało zbudowane przez Inków ok. XV wieku na wysokości ponad 2,4 tys. m n.p.m i jest jedną z najbardziej niezwykłych osad na całym świecie.",
                        Miejsce = "Machu Picchu",
                        Zdjecie = "https://lonelyplanetwp.imgix.net/2018/01/Machu_Picchu-694dbac6b0e5.jpg?crop=entropy&fit=crop&h=421&sharp=10&vib=20&w=748",
                        Kontynent = "Ameryka Południowa",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    },


                    new Place
                    {
                        Kraj = "Włochy",
                        Opis = "Amfiteatr w Rzymie, wzniesiony w latach 70-72 do 80 n.e. przez Wespazjana i Tytusa – cesarzy z dynastii Flawiuszów.Jest to duża, eliptyczna budowla o długości 188 m i szerokości 156 m, obwodzie 524 m, wysokości 48,5 m, z pojemną widownią, która mogła pomieścić od 45 do 50 tysięcy widzów",
                        Miejsce = "Koloseum",
                        Zdjecie = "https://gfx.radiozet.pl/var/radiozet/storage/images/media/images/koloseum-w-rzymie/578023-1-pol-PL/Koloseum-w-Rzymie.jpg",
                        Kontynent = "Europa",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    },

                    new Place
                    {
                        Kraj = "Chiny",
                        Opis = "Tradycyjnie przyjmuje się, że Wielki Mur rozciągał się od Shanhaiguan (nad zatoką Liaodong) do Jiayuguan w górach Nan Shan na długości ok. 2400 km. Nazywany jest też „Murem 10 000 Li” (10 000 nie powinno być tutaj traktowane dosłownie i oznacza raczej „nieskończoną długość” muru).",
                        Miejsce = "Wielki Mur Chiński",
                        Zdjecie = "https://www.tajemnice-swiata.pl/wp-content/uploads/2017/06/51190859_l-678x381.jpg",
                        Kontynent = "Azja",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    },

                    new Place
                    {
                        Kraj = "USA",
                        Opis = "Park narodowy położony w Stanach Zjednoczonych, na terenie stanów Wyoming, Montana i Idaho. Park narodowy Yellowstone jest najstarszym parkiem narodowym na świecie. Na terenie parku znajdują się słynne gejzery, gorące źródła, wulkany błotne, fumarole i wodospad",
                        Miejsce = "Park Narodowy Yellowstone",
                        Zdjecie = "https://i.wpimg.pl/O/644x428/i.wp.pl/a/f/jpeg/33430/morning_glory_pool_usa800_zhiqin_zhu_shutterstock.jpeg",
                        Kontynent = "Ameryka Północna",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    },

                    new Place
                    {
                        Kraj = "Egipt",
                        Opis = "Historyczne budowle obejmujące dwie największe piramidy zbudowane w starożytnym Egipcie (piramidę Cheopsa i piramidę Chefrena) oraz mniejszą piramidę Mykerinosa i towarzyszące im obiekty.",
                        Miejsce = "Piramidy w Gizie",
                        Zdjecie = "http://tajemnicepiramid.eu/wp-content/uploads/2015/05/kompleks-piramid-w-gizie-1.jpg",
                        Kontynent = "Afryka",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    },

                    new Place
                    {
                        Kraj = "Sydney",
                        Opis = "Budynek w stylu nowoczesnego ekspresjonizmu, położony na przylądku Bennelong Point w Sydney.",
                        Miejsce = "Sydney Opera House",
                        Zdjecie = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Sydney_Opera_House_Sails.jpg/240px-Sydney_Opera_House_Sails.jpg",
                        Kontynent = "Australia",
                        Status = PlaceStatus.Approved,
                        //Userid = adminID
                    }

                   );
                context.SaveChanges();
            }
        }
    }
}


    
