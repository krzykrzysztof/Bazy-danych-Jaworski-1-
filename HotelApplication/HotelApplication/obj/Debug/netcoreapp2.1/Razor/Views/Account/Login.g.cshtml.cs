#pragma checksum "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b655a0d44595a525a867e62eb88df44a168f5742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\_ViewImports.cshtml"
using HotelApplication;

#line default
#line hidden
#line 2 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\_ViewImports.cshtml"
using HotelApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b655a0d44595a525a867e62eb88df44a168f5742", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 24, true);
            WriteLiteral("\r\n<h2>Logowanie</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
 using (Html.BeginForm("Login", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(282, 23, false);
#line 12 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(307, 44, true);
            WriteLiteral("    <h4>Utwórz nowe konto</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(356, 58, false);
#line 15 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(418, 136, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label class=\"col-md-2 control-label\">Email</label>\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(555, 62, false);
#line 20 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(617, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(649, 136, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label class=\"col-md-2 control-label\">Hasło</label>\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(786, 66, false);
#line 27 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(852, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(884, 184, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Zaloguj\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 36 "C:\Dev\Git\Bazy-danych-Jaworski-1-\HotelApplication\HotelApplication\Views\Account\Login.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591