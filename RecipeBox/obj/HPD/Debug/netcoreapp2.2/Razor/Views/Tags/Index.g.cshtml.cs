#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717a180d434ae7579ab18e7b39b8bc56de459f79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Index), @"mvc.1.0.view", @"/Views/Tags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Index.cshtml", typeof(AspNetCore.Views_Tags_Index))]
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
#line 5 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717a180d434ae7579ab18e7b39b8bc56de459f79", @"/Views/Tags/Index.cshtml")]
    public class Views_Tags_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecipeBox.Models.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 49, true);
            WriteLiteral("<hr />\r\n<h2>Current List of Tags</h2>\r\n<hr />\r\n\r\n");
            EndContext();
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
 foreach(Tag tag in Model)
{

#line default
#line hidden
            BeginContext(174, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(180, 65, false);
#line 13 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
Write(Html.ActionLink($"{tag.Name}", "Details", new { id = tag.TagId }));

#line default
#line hidden
            EndContext();
            BeginContext(245, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
}

#line default
#line hidden
            BeginContext(254, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 17 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(286, 41, true);
            WriteLiteral("  <h3>No tags have been added yet!</h3>\r\n");
            EndContext();
#line 20 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Tags\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(331, 115, true);
            WriteLiteral("<br>\r\n<form action=\"/Tags/Create\" method=\"get\">\r\n  <input type=\"submit\" value=\"Add new Tag\" class=\"btn\">\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecipeBox.Models.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
