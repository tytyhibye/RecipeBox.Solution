#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06a9f24fc71508545d2e3e2343870eb16a9c66e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_AddTag), @"mvc.1.0.view", @"/Views/Recipes/AddTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/AddTag.cshtml", typeof(AspNetCore.Views_Recipes_AddTag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a9f24fc71508545d2e3e2343870eb16a9c66e", @"/Views/Recipes/AddTag.cshtml")]
    public class Views_Recipes_AddTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 54, true);
            WriteLiteral("\r\n<h2>Add a tag</h2>\r\n\r\n<h4>Add a tag to this recipe: ");
            EndContext();
            BeginContext(119, 36, false);
#line 9 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(155, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(197, 39, false);
#line 13 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.HiddenFor(model => model.RecipeId));

#line default
#line hidden
            EndContext();
            BeginContext(243, 24, false);
#line 15 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.Label("Select Tag"));

#line default
#line hidden
            EndContext();
            BeginContext(272, 26, false);
#line 16 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
            EndContext();
            BeginContext(302, 52, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" class=\"btn\" />\r\n");
            EndContext();
#line 19 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
}

#line default
#line hidden
            BeginContext(357, 9, true);
            WriteLiteral("<br>\r\n<p>");
            EndContext();
            BeginContext(367, 40, false);
#line 21 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(407, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
