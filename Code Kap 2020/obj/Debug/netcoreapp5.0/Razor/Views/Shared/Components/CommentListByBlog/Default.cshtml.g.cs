#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\CommentListByBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d714826704b1a559198b77d156382a78d99ff0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentListByBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentListByBlog/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CommentListByBlog/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CommentListByBlog_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d714826704b1a559198b77d156382a78d99ff0ca", @"/Views/Shared/Components/CommentListByBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CommentListByBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/web/images/t1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 73, true);
            WriteLiteral("\r\n<div class=\"comment-top\">\r\n    <h4>Yorumlar</h4>\r\n    <br />\r\n\r\n    <p>");
            EndContext();
            BeginContext(126, 11, false);
#line 8 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\CommentListByBlog\Default.cshtml"
  Write(ViewBag.tit);

#line default
#line hidden
            EndContext();
            BeginContext(137, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\CommentListByBlog\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(186, 41, true);
            WriteLiteral("        <div class=\"media\">\r\n            ");
            EndContext();
            BeginContext(227, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d714826704b1a559198b77d156382a78d99ff0ca5472", async() => {
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
            BeginContext(298, 73, true);
            WriteLiteral("\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\">");
            EndContext();
            BeginContext(372, 20, false);
#line 15 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\CommentListByBlog\Default.cshtml"
                            Write(item.CommentUsername);

#line default
#line hidden
            EndContext();
            BeginContext(392, 50, true);
            WriteLiteral("</h5>\r\n\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(443, 19, false);
#line 18 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\CommentListByBlog\Default.cshtml"
               Write(item.CommentContent);

#line default
#line hidden
            EndContext();
            BeginContext(462, 78, true);
            WriteLiteral("\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 24 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\CommentListByBlog\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(547, 14, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
