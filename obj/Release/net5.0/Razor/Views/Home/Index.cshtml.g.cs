#pragma checksum "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b36338bc43e125a5d6f458f636493f67b479c9f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/home/fshangala/Desktop/Projects/Promenade/Views/_ViewImports.cshtml"
using Promenade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/fshangala/Desktop/Projects/Promenade/Views/_ViewImports.cshtml"
using Promenade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b36338bc43e125a5d6f458f636493f67b479c9f1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb1e267e764de1bdf2f14bb30fb26b31e5247c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home";
    var categories = (IEnumerable<Category>)ViewData["categories"];
    var settings = (IEnumerable<Details>)ViewData["settings"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-sm"">
    <div class=""jumbotron text-center shadow border-top border-secondary"">
        <h2 class=""text-info""><b>Promenade Restaurant</b></h2>
    </div>
    <div class=""shadow bg-white p-2 text-center"">
        <h2>About Us</h2>
        ");
#nullable restore
#line 13 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
   Write(Html.Raw(settings.First(c => c.Name == "Description").Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row row-cols-2 row-cols-sm-4\">\r\n");
#nullable restore
#line 16 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
      
        foreach(var category in categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col my-2\">\r\n                <div class=\"border border-secondary shadow\">\r\n                    <div class=\"bg-white text-center position-relative\">\r\n                        <center><img");
            BeginWriteAttribute("src", " src=\"", 836, "\"", 857, 1);
#nullable restore
#line 22 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
WriteAttributeValue("", 842, category.Image, 842, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 858, "\"", 866, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"100\"></center>\r\n                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b36338bc43e125a5d6f458f636493f67b479c9f15428", async() => {
#nullable restore
#line 23 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
                                                                                                   Write(category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
                                                                              WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"shadow bg-white p-2\">\r\n        <h2>Contact Us</h2>\r\n        ");
#nullable restore
#line 32 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
   Write(Html.Raw(settings.First(c => c.Name == "Description").Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <table class=\"table\">\r\n");
#nullable restore
#line 34 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
         foreach(var setting in settings)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
             if(setting.Type == "Contact")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 39 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
                   Write(setting.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 40 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
                   Write(setting.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/home/fshangala/Desktop/Projects/Promenade/Views/Home/Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591