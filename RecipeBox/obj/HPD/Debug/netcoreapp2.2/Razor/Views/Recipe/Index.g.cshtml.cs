#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25cf12bde3a0f8b525aee31b35fb7a402605a8e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Index), @"mvc.1.0.view", @"/Views/Recipe/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/Index.cshtml", typeof(AspNetCore.Views_Recipe_Index))]
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
#line 5 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25cf12bde3a0f8b525aee31b35fb7a402605a8e0", @"/Views/Recipe/Index.cshtml")]
    public class Views_Recipe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RecipeBox.Models.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(102, 18, true);
            WriteLiteral("\r\n<h2>Recipes for ");
            EndContext();
            BeginContext(121, 18, false);
#line 8 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(139, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(170, 8, true);
            WriteLiteral("  <ul>\r\n");
            EndContext();
#line 13 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
     foreach(Recipe recipe in Model)
    {

#line default
#line hidden
            BeginContext(223, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(235, 74, false);
#line 15 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
      Write(Html.ActionLink($"{recipe.Name}", "Details", new { id = recipe.RecipeId }));

#line default
#line hidden
            EndContext();
            BeginContext(309, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(322, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 18 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(343, 44, true);
            WriteLiteral("  <h3>No Recipes have been added yet!</h3>\r\n");
            EndContext();
#line 22 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(391, 9, true);
            WriteLiteral("<br>\r\n<p>");
            EndContext();
            BeginContext(401, 43, false);
#line 24 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipe\Index.cshtml"
Write(Html.ActionLink("Add new Recipe", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(444, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RecipeBox.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591