#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa7ba278c01259b172b5c67d8f4dbb4a0baba7d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Delete), @"mvc.1.0.view", @"/Views/Tags/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Delete.cshtml", typeof(AspNetCore.Views_Tags_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7ba278c01259b172b5c67d8f4dbb4a0baba7d7", @"/Views/Tags/Delete.cshtml")]
    public class Views_Tags_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Tag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 56, true);
            WriteLiteral("\r\n<h2>Are you sure you want to delete this tag?</h2>\r\n\r\n");
            EndContext();
            BeginContext(118, 45, false);
#line 9 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml"
Write(Html.ActionLink("I changed my mind", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(163, 14, true);
            WriteLiteral("\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(178, 40, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(218, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(222, 36, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(258, 15, true);
            WriteLiteral("</h3>\r\n<hr />\r\n");
            EndContext();
#line 13 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(303, 53, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" class=\"btn\"/>\r\n");
            EndContext();
#line 16 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Tag> Html { get; private set; }
    }
}
#pragma warning restore 1591
