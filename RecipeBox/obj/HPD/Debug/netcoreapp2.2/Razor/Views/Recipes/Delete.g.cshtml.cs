#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "704c88eee5ba7a3e78cbdb5e564d4ec4d082d1b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Delete), @"mvc.1.0.view", @"/Views/Recipes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Delete.cshtml", typeof(AspNetCore.Views_Recipes_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704c88eee5ba7a3e78cbdb5e564d4ec4d082d1b3", @"/Views/Recipes/Delete.cshtml")]
    public class Views_Recipes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 59, true);
            WriteLiteral("\r\n<h2>Are you sure you want to delete this Recipe?</h2>\r\n\r\n");
            EndContext();
            BeginContext(124, 45, false);
#line 9 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml"
Write(Html.ActionLink("I changed my mind", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(169, 14, true);
            WriteLiteral("\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(184, 40, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(224, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(228, 36, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(264, 15, true);
            WriteLiteral("</h3>\r\n<hr />\r\n");
            EndContext();
#line 13 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(309, 53, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" class=\"btn\"/>\r\n");
            EndContext();
#line 16 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
