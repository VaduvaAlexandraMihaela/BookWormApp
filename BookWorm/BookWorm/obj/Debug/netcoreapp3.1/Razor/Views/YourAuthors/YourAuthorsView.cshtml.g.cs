#pragma checksum "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ae2eeb6b972a17e4a1a253b5d07e44eeabe7d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourAuthors_YourAuthorsView), @"mvc.1.0.view", @"/Views/YourAuthors/YourAuthorsView.cshtml")]
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
#line 1 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\_ViewImports.cshtml"
using BookWorm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\_ViewImports.cshtml"
using BookWorm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ae2eeb6b972a17e4a1a253b5d07e44eeabe7d2", @"/Views/YourAuthors/YourAuthorsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965a3e22dfbcf8f9295cc57377c5cfd9b5c6750c", @"/Views/_ViewImports.cshtml")]
    public class Views_YourAuthors_YourAuthorsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YourAuthorsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAuthor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
  
    ViewData["Title"] = "YourAuthorsView";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""site-section"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-8"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""section-title"">
                            <h2>Your authors</h2>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 18 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                 foreach (var item in Model.Authors)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""post-entry-2 d-flex bg-light"">
                                <div class=""contents"">
                                    <h2><a>");
#nullable restore
#line 24 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                                      Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                </div>\r\n                                <div class=\"contents\">\r\n                                    <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ae2eeb6b972a17e4a1a253b5d07e44eeabe7d25011", async() => {
                WriteLiteral("Delete Author");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                                                                       WriteLiteral(item.Id);

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
            WriteLiteral("</h2>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 34 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"section-title\">\r\n                    <label for=\"fname\"><a");
            BeginWriteAttribute("href", " href=\'", 1309, "\'", 1354, 1);
#nullable restore
#line 38 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
WriteAttributeValue("", 1316, Url.Action("AddAuthor","YourAuthors"), 1316, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add Author</a></label>
                    <div class=""col-lg-6"">

                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""section-title"">
                    <h2>Your reviews</h2>
                </div>
");
#nullable restore
#line 48 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                 foreach (var item1 in Model.Reviews)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"trend-entry d-flex\">\r\n                        <div class=\"trend-contents\">\r\n                            <h2><a>");
#nullable restore
#line 52 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                              Write(Html.DisplayFor(model => item1.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <div class=\"post-meta\">\r\n                                <span class=\"d-block\">");
#nullable restore
#line 54 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                                                 Write(Html.DisplayFor(model => item1.Author.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 58 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 2232, "\'", 2276, 1);
#nullable restore
#line 61 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
WriteAttributeValue("", 2239, Url.Action("AllReviews","YourBooks"), 2239, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""more"">See All Reviews</a>
                </p>

            </div>
        </div>
    </div>
</div>

<div class=""site-section bg-light"">
    <div class=""container"">
        <div class=""row"">

            <div class=""section-title"">
                <h2 class=""mb-5""><a");
            BeginWriteAttribute("href", " href=\'", 2565, "\'", 2608, 1);
#nullable restore
#line 74 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\YourAuthors\YourAuthorsView.cshtml"
WriteAttributeValue("", 2572, Url.Action("AddReview","Dashboard"), 2572, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Write review</a></h2>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YourAuthorsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591