#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77742b2065e2589185a613950a3e3070b3d06e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
using RecipeBox.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77742b2065e2589185a613950a3e3070b3d06e45", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 40, true);
            WriteLiteral("\r\n<h2>Register a new user</h2>\r\n<hr />\r\n");
            EndContext();
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
  

#line default
#line hidden
            BeginContext(200, 32, false);
#line 13 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.LabelFor(user => user.Name));

#line default
#line hidden
            EndContext();
            BeginContext(237, 34, false);
#line 14 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(user => user.Name));

#line default
#line hidden
            EndContext();
            BeginContext(273, 8, true);
            WriteLiteral("  <br>\r\n");
            EndContext();
            BeginContext(284, 33, false);
#line 16 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(322, 34, false);
#line 17 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(358, 8, true);
            WriteLiteral("  <br>\r\n");
            EndContext();
            BeginContext(369, 35, false);
#line 19 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(409, 38, false);
#line 20 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(449, 8, true);
            WriteLiteral("  <br>\r\n");
            EndContext();
            BeginContext(460, 42, false);
#line 22 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(507, 45, false);
#line 23 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(554, 64, true);
            WriteLiteral("  <br>\r\n  <input type=\"submit\" value=\"Register\" class=\"btn\" />\r\n");
            EndContext();
#line 26 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Account\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
