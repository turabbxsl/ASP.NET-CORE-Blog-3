#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c304655f3378442ec88961f5d4ad064d79702a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/BlogLast3Post/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default))]
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
#line 1 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c304655f3378442ec88961f5d4ad064d79702a63", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 52, true);
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>son Postlar</h3>\r\n");
            EndContext();
#line 7 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(143, 114, true);
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 257, "\"", 294, 2);
            WriteAttributeValue("", 264, "/Blog/BlogReadAll/", 264, 18, true);
#line 12 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 282, item.BlogID, 282, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(295, 27, true);
            WriteLiteral(">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 322, "\"", 343, 1);
#line 13 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 328, item.BlogImage, 328, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(344, 31, true);
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 375, "\"", 381, 0);
            EndWriteAttribute();
            BeginContext(382, 145, true);
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 527, "\"", 564, 2);
            WriteAttributeValue("", 534, "/Blog/BlogReadAll/", 534, 18, true);
#line 20 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 552, item.BlogID, 552, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(565, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(568, 81, false);
#line 20 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                         Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
            EndContext();
            BeginContext(649, 155, true);
            WriteLiteral(" ... </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
            EndContext();
            BeginContext(806, 54, false);
#line 24 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(861, 93, true);
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(961, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
