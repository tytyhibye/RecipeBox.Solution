#pragma checksum "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0989fa0029cef70f65fe24185827136bcc1d1c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Details), @"mvc.1.0.view", @"/Views/Recipes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Details.cshtml", typeof(AspNetCore.Views_Recipes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0989fa0029cef70f65fe24185827136bcc1d1c2", @"/Views/Recipes/Details.cshtml")]
    public class Views_Recipes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 39, true);
            WriteLiteral("\r\n<h2>Recipe Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(104, 40, false);
#line 9 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(144, 11, true);
            WriteLiteral(": </h3><h4>");
            EndContext();
            BeginContext(156, 36, false);
#line 9 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(192, 10, true);
            WriteLiteral("<h3>\r\n<h3>");
            EndContext();
            BeginContext(203, 47, false);
#line 10 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(250, 11, true);
            WriteLiteral(": </h3><h4>");
            EndContext();
            BeginContext(262, 43, false);
#line 10 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(305, 11, true);
            WriteLiteral("</h4>\r\n<h3>");
            EndContext();
            BeginContext(317, 48, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Instructions));

#line default
#line hidden
            EndContext();
            BeginContext(365, 11, true);
            WriteLiteral(": </h3><h4>");
            EndContext();
            BeginContext(377, 44, false);
#line 11 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.Instructions));

#line default
#line hidden
            EndContext();
            BeginContext(421, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 12 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
 if(@Model.Tags.Count == 0)
{

#line default
#line hidden
            BeginContext(460, 47, true);
            WriteLiteral("  <p>This recipe doesn\'t contain any tags</p>\r\n");
            EndContext();
#line 15 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(519, 18, true);
            WriteLiteral("  <h3>Tags:</h3>\r\n");
            EndContext();
#line 19 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
   foreach(var join in Model.Tags)
  {

#line default
#line hidden
            BeginContext(578, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(586, 13, false);
#line 21 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
  Write(join.Tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(599, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
     if (User.Identity.IsAuthenticated && ViewBag.IsCurrentUser)
    {
      

#line default
#line hidden
#line 24 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
       using (Html.BeginForm("DeleteTag", "Recipes")) //("Recipes" == "RecipesContoller")
      {

#line default
#line hidden
            BeginContext(778, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(790, 40, false);
#line 26 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
      Write(Html.Hidden("joinId", @join.RecipeTagId));

#line default
#line hidden
            EndContext();
            BeginContext(830, 60, true);
            WriteLiteral(" <input type=\"submit\" value=\"Remove Tag\" class=\"btn\"/></p>\r\n");
            EndContext();
#line 27 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
      }

#line default
#line hidden
#line 27 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
       
    }

#line default
#line hidden
#line 28 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
     
  }

#line default
#line hidden
#line 29 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
   
}

#line default
#line hidden
            BeginContext(914, 8, true);
            WriteLiteral("<hr />\r\n");
            EndContext();
#line 32 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
 if (User.Identity.IsAuthenticated && ViewBag.IsCurrentUser)
{

#line default
#line hidden
            BeginContext(987, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(993, 67, false);
#line 34 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
Write(Html.ActionLink("Edit Recipe", "Edit", new { id = Model.RecipeId }));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 6, true);
            WriteLiteral(" |\r\n  ");
            EndContext();
            BeginContext(1067, 71, false);
#line 35 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
Write(Html.ActionLink("Delete Recipe", "Delete", new { id = Model.RecipeId }));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 6, true);
            WriteLiteral(" |\r\n  ");
            EndContext();
            BeginContext(1145, 65, false);
#line 36 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
Write(Html.ActionLink("Add Tag", "AddTag", new { id = Model.RecipeId }));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 7, true);
            WriteLiteral("</p> \r\n");
            EndContext();
#line 37 "C:\Users\conno_000\Desktop\C#\RecipeBox.Solution\RecipeBox\Views\Recipes\Details.cshtml"
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
