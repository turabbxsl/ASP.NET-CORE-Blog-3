#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e323f182eedd17446c8f923bcd243fb138d3047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/BlogListDashboard/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e323f182eedd17446c8f923bcd243fb138d3047", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 701, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Bloglar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Baslik </th>
                                <th>Kategoriya </th>
                                <th> Tarix</th>
                                <th> Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>

");
            EndContext();
#line 23 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(832, 124, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 956, "\"", 977, 1);
#line 27 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 962, item.BlogImage, 962, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(978, 153, true);
            WriteLiteral(" class=\"mr-2\" alt=\"image\">\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1132, 14, false);
#line 30 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1146, 171, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">");
            EndContext();
            BeginContext(1318, 26, false);
#line 33 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 94, true);
            WriteLiteral("</label>\r\n                                    </td>\r\n                                    <td> ");
            EndContext();
            BeginContext(1440, 54, false);
#line 35 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                     Write(((DateTime)item.BlogCreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 114, true);
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n                                        <a class=\"btn btn-dark\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1609, "\"", 1646, 2);
            WriteAttributeValue("", 1616, "/Blog/BlogReadAll/", 1616, 18, true);
#line 38 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1634, item.BlogID, 1634, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1647, 99, true);
            WriteLiteral(">Detaylar</a>\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Components\BlogListDashboard\Default.cshtml"

                            }

#line default
#line hidden
            BeginContext(1779, 150, true);
            WriteLiteral("\r\n\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
