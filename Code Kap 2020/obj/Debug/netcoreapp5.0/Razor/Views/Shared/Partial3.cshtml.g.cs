#pragma checksum "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Partial3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916a17495c9ed5d29d6cd282d40b1198083f1552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial3), @"mvc.1.0.view", @"/Views/Shared/Partial3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial3.cshtml", typeof(AspNetCore.Views_Shared_Partial3))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916a17495c9ed5d29d6cd282d40b1198083f1552", @"/Views/Shared/Partial3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4bb8ec5520e2198214437d15e8d2ed2ece507", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 972, true);
            WriteLiteral(@"

<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkimizda</h3>
                <p>Blog, genellikle güncelden eskiye doğru sıralanmış yazı ve yorumların yayınlandığı, web tabanlı bir yayını belirtir. Çoğunlukla her gönderinin sonunda yazarın adı ve gönderi zamanı belirtilir. Yayıncının seçimine göre okuyucular yazılara yorum yapılabilir. Yorumlar, blog kültürünün çok önemli bir dinamiğidir; bu sayede yazar ve okuyucular arasında iletişim sağlanır. Bunun dışında, geri izleme (trackback) mekanizmasıyla, belirli bir yazı hakkında yazılan diğer yazıların belirlenebilmesi de mümkündür..</p>
                <div class=""read"">
                    <a href=""/About/Index/"" class=""btn btn-primary read-m"">Devamini Oku</a>
                </div>
            </div>
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">

                ");
            EndContext();
            BeginContext(973, 44, false);
#line 15 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Partial3.cshtml"
           Write(await Component.InvokeAsync("BlogLast3Post"));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 211, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <!-- subscribe -->\r\n            <div class=\"col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left\">\r\n                <h2>Mail Bultenine Abone Olun</h2>\r\n                ");
            EndContext();
            BeginContext(1229, 66, false);
#line 21 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Partial3.cshtml"
           Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 1525, true);
            WriteLiteral(@"
            </div>
        </div>
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
                                <span>Google+</span>
                 ");
            WriteLiteral(@"           </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-pinterest-p""></i>
                                <span>Pinterest</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
            EndContext();
            BeginContext(2821, 17, false);
#line 59 "C:\Users\HP\source\repos\Code Kap 2020\Code Kap 2020\Views\Shared\Partial3.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2838, 221, true);
            WriteLiteral(" Weblog. All Rights Reserved | Design by\r\n                    <a href=\"http://w3layouts.com/\">Turabbl</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>");
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
