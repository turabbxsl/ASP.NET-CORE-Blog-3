#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c15d168e67d214294d991331e00f1193c2427182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogAdd.cshtml", typeof(AspNetCore.Views_Blog_BlogAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15d168e67d214294d991331e00f1193c2427182", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(36, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/LayoutYeni.cshtml";

#line default
#line hidden
            BeginContext(133, 29, true);
            WriteLiteral("\r\n<h1>Yeni Blog Ekle</h1>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(231, 26, false);
#line 14 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Basligi"));

#line default
#line hidden
            EndContext();
            BeginContext(264, 66, false);
#line 15 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(332, 51, true);
            WriteLiteral("    <p style=\"color:red;font-size:14px;\">\r\n        ");
            EndContext();
            BeginContext(384, 43, false);
#line 17 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
   Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
            EndContext();
            BeginContext(427, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(446, 25, false);
#line 20 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Gorsel"));

#line default
#line hidden
            EndContext();
            BeginContext(478, 66, false);
#line 21 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(546, 51, true);
            WriteLiteral("    <p style=\"color:red;font-size:14px;\">\r\n        ");
            EndContext();
            BeginContext(598, 43, false);
#line 23 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
   Write(Html.ValidationMessageFor(x => x.BlogImage));

#line default
#line hidden
            EndContext();
            BeginContext(641, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(660, 31, false);
#line 26 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Kucuk Gorsel"));

#line default
#line hidden
            EndContext();
            BeginContext(698, 75, false);
#line 27 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(782, 24, false);
#line 29 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Kategoriya"));

#line default
#line hidden
            EndContext();
            BeginContext(813, 107, false);
#line 30 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID,(List<SelectListItem>)ViewBag.categories,new {@class="form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(929, 26, false);
#line 32 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Icerigi"));

#line default
#line hidden
            EndContext();
            BeginContext(962, 76, false);
#line 33 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 51, true);
            WriteLiteral("    <p style=\"color:red;font-size:14px;\">\r\n        ");
            EndContext();
            BeginContext(1092, 45, false);
#line 35 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
   Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(1151, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(1165, 57, true);
            WriteLiteral("    <button class=\"btn btn-info\">Yaziyi Kaydet</button>\r\n");
            EndContext();
#line 41 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Blog\BlogAdd.cshtml"
}

#line default
#line hidden
            BeginContext(1225, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
