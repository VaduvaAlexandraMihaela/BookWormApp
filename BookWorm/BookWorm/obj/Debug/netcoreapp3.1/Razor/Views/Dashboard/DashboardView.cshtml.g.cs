#pragma checksum "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6630f68e5f6ab84b455c77b2dcadb143a82795b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_DashboardView), @"mvc.1.0.view", @"/Views/Dashboard/DashboardView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6630f68e5f6ab84b455c77b2dcadb143a82795b5", @"/Views/Dashboard/DashboardView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965a3e22dfbcf8f9295cc57377c5cfd9b5c6750c", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_DashboardView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
  
    ViewData["Title"] = "DashboardView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"site-section\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-8 single-content\">\r\n");
#nullable restore
#line 10 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                     foreach (var item in Model.Reviews)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 class=\"mb-4\">\r\n                            ");
#nullable restore
#line 13 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                       Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h1>\r\n                        <div class=\"post-meta d-flex mb-5\">\r\n                            <div class=\"vcard\">\r\n                                <span class=\"d-block\">>");
#nullable restore
#line 17 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                                                  Write(Html.DisplayFor(model => item.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <p>");
#nullable restore
#line 21 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                      Write(Html.DisplayFor(model => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 23 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                         foreach (var item1 in Model.Comments)
                        {
                            if (item1.Review == item)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""pt-5"">
                                    <ul class=""comment-list"">
                                        <li class=""comment"">
                                            <div class=""comment-body"">
                                                <h3>");
#nullable restore
#line 31 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                                               Write(Html.DisplayFor(model => item1.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                <p>");
#nullable restore
#line 32 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                                              Write(Html.DisplayFor(model => item1.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                            </div>\r\n                                        </li>\r\n\r\n\r\n\r\n\r\n                                    </ul>\r\n\r\n\r\n\r\n\r\n                                </div>\r\n");
#nullable restore
#line 46 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                            }
                           
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"section-title\">\r\n                            <h2 class=\"mb-5\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6630f68e5f6ab84b455c77b2dcadb143a82795b57240", async() => {
                WriteLiteral("Leave a comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n                        </div>\r\n");
#nullable restore
#line 52 "D:\Facultate\WAD Proiect\BookWorm\BookWorm\Views\Dashboard\DashboardView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
