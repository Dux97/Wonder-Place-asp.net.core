#pragma checksum "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6060ae935366864be999b3a0c050ef3fda8ff05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WonderPlace.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(WonderPlace.Pages.Pages_Contact), null)]
namespace WonderPlace.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\_ViewImports.cshtml"
using WonderPlace;

#line default
#line hidden
#line 3 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\_ViewImports.cshtml"
using WonderPlace.Data;

#line default
#line hidden
#line 6 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\_ViewImports.cshtml"
using WonderPlace.Authorization;

#line default
#line hidden
#line 7 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 8 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\_ViewImports.cshtml"
using WonderPlace.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6060ae935366864be999b3a0c050ef3fda8ff05", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc838e91883f50f18533beeb46593e0a2bbc6da6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(71, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(76, 17, false);
#line 6 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(93, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(105, 13, false);
#line 7 "C:\Users\Damian\Desktop\Studia\informatyka\semetr4\ciekawe miejsca www\WonderPlace\WonderPlace\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(118, 265, true);
            WriteLiteral(@"</h3>

<address>
    Prószkowska<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
</address>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591