#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e590aa41f4ebd3bfa88ea19d65a5218d3e340f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogListByWriter.cshtml", typeof(AspNetCore.Views_Blog_BlogListByWriter))]
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
#line 2 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e590aa41f4ebd3bfa88ea19d65a5218d3e340f86", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/LayoutYeni.cshtml";

#line default
#line hidden
            BeginContext(154, 275, true);
            WriteLiteral(@"
<h1>Yazarin Bloglari</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Title</th>
        <th>Olusturma Tarihi</th>
        <th>Kategoriya</th>
        <th>Durum</th>
        <th>Sil</th>
        <th>Duzenle</th>
    </tr>
");
            EndContext();
#line 22 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
            BeginContext(467, 26, true);
            WriteLiteral("\t\t <tr>\r\n             <th>");
            EndContext();
            BeginContext(494, 11, false);
#line 25 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
            Write(item.BlogID);

#line default
#line hidden
            EndContext();
            BeginContext(505, 24, true);
            WriteLiteral("</th>\r\n             <td>");
            EndContext();
            BeginContext(530, 14, false);
#line 26 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
            Write(item.BlogTitle);

#line default
#line hidden
            EndContext();
            BeginContext(544, 24, true);
            WriteLiteral("</td>\r\n             <td>");
            EndContext();
            BeginContext(570, 55, false);
#line 27 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
             Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(626, 24, true);
            WriteLiteral("</td>\r\n             <td>");
            EndContext();
            BeginContext(651, 26, false);
#line 28 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
            Write(item.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(677, 26, true);
            WriteLiteral("</td>\r\n             <td>\r\n");
            EndContext();
#line 30 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
              if (item.BlogStatus == true)
             {

#line default
#line hidden
            BeginContext(763, 59, true);
            WriteLiteral("                 <p style=\"color:lightseagreen\">Aktif</p>\r\n");
            EndContext();
#line 33 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
             }
             else
             {

#line default
#line hidden
            BeginContext(873, 52, true);
            WriteLiteral("             <p style=\"color:indianred\">Passiv</p>\r\n");
            EndContext();
#line 37 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
             }

#line default
#line hidden
            BeginContext(941, 39, true);
            WriteLiteral("             </td>\r\n             <td><a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 980, "\"", 1017, 2);
            WriteAttributeValue("", 988, "/Blog/DeleteBlog/", 988, 17, true);
#line 39 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1005, item.BlogID, 1005, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1018, 57, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n             <td><a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 1075, "\"", 1110, 2);
            WriteAttributeValue("", 1083, "/Blog/EditBlog/", 1083, 15, true);
#line 40 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1098, item.BlogID, 1098, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1111, 59, true);
            WriteLiteral(" class=\"btn btn-warning\">Duzenle</a></td>\r\n         </tr>\r\n");
            EndContext();
#line 42 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogListByWriter.cshtml"
	}

#line default
#line hidden
            BeginContext(1174, 85, true);
            WriteLiteral("</table>\r\n\r\n<a href =\"/Blog/BlogAdd/\" class=\"btn btn-primary\">Yeni Blog Yarat</a>\r\n\r\n");
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