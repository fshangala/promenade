#pragma checksum "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b545821d0c8368f8f62b1889c86d674ca54ca50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_index), @"mvc.1.0.view", @"/Views/Food/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b545821d0c8368f8f62b1889c86d674ca54ca50", @"/Views/Food/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb1e267e764de1bdf2f14bb30fb26b31e5247c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
  
    ViewData["Title"] = ViewData["FoodName"];
    var foodName = ViewData["FoodName"];
    var category = ViewData["Category"];
    var foodPrice = ViewData["FoodPrice"];
    var foodImage = ViewData["FoodImage"];

    var foods = (IEnumerable<Food>)ViewData["foods"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-sm\">\n    <div class=\"row\">\n        <div class=\"col-sm-4\">\n            <center><img");
            BeginWriteAttribute("src", " src=\"", 378, "\"", 394, 1);
#nullable restore
#line 13 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
WriteAttributeValue("", 384, foodImage, 384, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-auto h-100\"></center>\n        </div>\n        <div class=\"col-sm-8\">\n            <div class=\"bg-white mb-2\">\n                <ul class=\"list-group\">\n                    <li class=\"list-group-item\">");
#nullable restore
#line 18 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
                                           Write(foodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li class=\"list-group-item\">");
#nullable restore
#line 19 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
                                           Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li class=\"list-group-item\">$");
#nullable restore
#line 20 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
                                            Write(foodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </div>
            <!--
            <div class=""row mb-2"">
                <div class=""col"">
                    <button class=""btn btn-success w-100"" data-toggle=""modal"" data-target=""#place-order"">Place Order</button>
                    
                    <div class=""modal fade"" id=""place-order"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modelTitleId"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-body"">
                                    Body
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    <button type=""button"" class=""btn btn-primary"">Save</button>
                                </div>
                            </");
            WriteLiteral(@"div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <button class=""btn btn-info w-100"">Add to Wish list</button>
                </div>
            </div>-->
        </div>
    </div>
    <div");
            BeginWriteAttribute("class", " class=\"", 2042, "\"", 2050, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        <h3 class=\"text-center bg-white p-2\"><b>Related Foods<b></h3>\n        <div class=\"row row-cols-xs-2 row-cols-sm-4\">\n");
#nullable restore
#line 51 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
          
            foreach(var food in foods)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col mb-2\">\n                    <div class=\"border border-secondary shadow\">\n                        <div class=\"bg-secondary text-center\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b545821d0c8368f8f62b1889c86d674ca54ca507552", async() => {
                WriteLiteral("\n                                <img");
                BeginWriteAttribute("src", " src=\"", 2541, "\"", 2558, 1);
#nullable restore
#line 58 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
WriteAttributeValue("", 2547, food.Image, 2547, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"h-100 w-auto\">\n                            ");
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
#line 57 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
                                                                          WriteLiteral(food.Id);

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
            WriteLiteral("\n                        </div>\n                        <ul class=\"list-group\">\n                            <li class=\"list-group-item\">");
#nullable restore
#line 62 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
                                                   Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                            <li class=\"list-group-item\">$");
#nullable restore
#line 63 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
                                                    Write(food.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        </ul>\n                    </div>\n                </div>\n");
#nullable restore
#line 67 "/home/fshangala/Desktop/Projects/Promenade/Views/Food/index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
