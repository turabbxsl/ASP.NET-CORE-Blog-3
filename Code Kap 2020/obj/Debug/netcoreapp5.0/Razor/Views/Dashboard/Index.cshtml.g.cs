#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77f10247572c58ae6bbbb06f01aa67092619efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\_ViewImports.cshtml"
using Code_Kap_2020;

#line default
#line hidden
#line 2 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\_ViewImports.cshtml"
using Code_Kap_2020.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77f10247572c58ae6bbbb06f01aa67092619efa", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/LayoutYeni.cshtml";

#line default
#line hidden
            BeginContext(93, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(132, 2452, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77f10247572c58ae6bbbb06f01aa67092619efa4896", async() => {
                BeginContext(138, 473, true);
                WriteLiteral(@"

    <div class=""page-header"">
        <h3 class=""page-title"">
            <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                <i class=""mdi mdi-home""></i>
            </span> Dashboard
        </h3>
    </div>

    <div class=""row"">
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-danger card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                EndContext();
                BeginContext(611, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f77f10247572c58ae6bbbb06f01aa67092619efa5766", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(713, 222, true);
                WriteLiteral("\r\n                    <h4 class=\"font-weight-normal mb-3\">\r\n                        Toplam Blog Sayi <i class=\"mdi mdi-chart-line mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
                EndContext();
                BeginContext(936, 10, false);
#line 28 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.v1);

#line default
#line hidden
                EndContext();
                BeginContext(946, 317, true);
                WriteLiteral(@"</h2>
                    <h6 class=""card-text"">TURABBL</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-info card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                EndContext();
                BeginContext(1263, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f77f10247572c58ae6bbbb06f01aa67092619efa8110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1365, 226, true);
                WriteLiteral("\r\n                    <h4 class=\"font-weight-normal mb-3\">\r\n                        Sizin Blog Sayi<i class=\"mdi mdi-bookmark-outline mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
                EndContext();
                BeginContext(1592, 10, false);
#line 40 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.v2);

#line default
#line hidden
                EndContext();
                BeginContext(1602, 320, true);
                WriteLiteral(@"</h2>
                    <h6 class=""card-text"">TURABBL</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-success card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                EndContext();
                BeginContext(1922, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f77f10247572c58ae6bbbb06f01aa67092619efa10464", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2024, 224, true);
                WriteLiteral("\r\n                    <h4 class=\"font-weight-normal mb-3\">\r\n                        Toplam Kategoriya Sayi<i class=\"mdi mdi-diamond mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
                EndContext();
                BeginContext(2249, 10, false);
#line 52 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.v3);

#line default
#line hidden
                EndContext();
                BeginContext(2259, 141, true);
                WriteLiteral("</h2>\r\n                    <h6 class=\"card-text\">TURABBL</h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(2401, 48, false);
#line 59 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
                EndContext();
                BeginContext(2449, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2458, 53, false);
#line 61 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("WriterAboutOnDashboard"));

#line default
#line hidden
                EndContext();
                BeginContext(2511, 9, true);
                WriteLiteral("\r\n \r\n    ");
                EndContext();
                BeginContext(2521, 52, false);
#line 63 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("CategoryListDashboard"));

#line default
#line hidden
                EndContext();
                BeginContext(2573, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2584, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591