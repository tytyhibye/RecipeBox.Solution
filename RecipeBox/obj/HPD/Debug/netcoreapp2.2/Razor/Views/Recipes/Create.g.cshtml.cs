#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0531b54fb0a991502387d7fb818e611ed58aed64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Create), @"mvc.1.0.view", @"/Views/Recipes/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Create.cshtml", typeof(AspNetCore.Views_Recipes_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0531b54fb0a991502387d7fb818e611ed58aed64", @"/Views/Recipes/Create.cshtml")]
    public class Views_Recipes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 32, true);
            WriteLiteral("\r\n<h4>Add a new Recipe:</h4>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(131, 34, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(172, 36, false);
#line 12 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(210, 10, true);
            WriteLiteral("    <br>\r\n");
            EndContext();
            BeginContext(225, 41, false);
#line 14 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(273, 43, false);
#line 15 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(318, 10, true);
            WriteLiteral("    <br>\r\n");
            EndContext();
            BeginContext(333, 42, false);
#line 17 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.Instructions));

#line default
#line hidden
            EndContext();
            BeginContext(382, 66, false);
#line 18 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.Instructions, new { type ="list" }));

#line default
#line hidden
            EndContext();
            BeginContext(450, 10, true);
            WriteLiteral("    <br>\r\n");
            EndContext();
            BeginContext(465, 32, false);
#line 20 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.Label("Add Tag to recipe:"));

#line default
#line hidden
            EndContext();
            BeginContext(504, 26, false);
#line 21 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
            EndContext();
            BeginContext(532, 74, true);
            WriteLiteral("    <br>\r\n    <input type=\"submit\" value=\"Add new Recipe\" class=\"btn\" />\r\n");
            EndContext();
#line 24 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Create.cshtml"
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