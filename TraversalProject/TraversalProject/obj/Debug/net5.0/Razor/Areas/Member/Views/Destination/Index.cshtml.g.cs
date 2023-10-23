#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2fb50d4bbb85142892142e9f469555701f2149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2fb50d4bbb85142892142e9f469555701f2149", @"/Areas/Member/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9108bca35cd76bb621b63eaa31acd78cf5f75c15", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberNewLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Aktif Tur Rotaları</h4>
                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                <div class=""heading-elements"">
                    <ul class=""list-inline mb-0"">
                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                        <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""card-content collapse show"">
                <div class=""card-body"">
                    <p class=""card-text"">
                       Alanında uzman rehberlerimiz ile Balkanlar'dan Orta Asya'y");
            WriteLiteral(@"a , Amekerika'dan  Rusya'ya , Doğu Anadolu'nun dört bir yanına
                        en uygun fiyatlarala sunduğumuz tur listemize ve tur detaylarına aşağıdaki tablodan erişebilirsiniz.
                    </p>

                    <div class=""table-responsive"">

                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Şehir</th>
                                    <th>Süre</th>
                                    <th>Kapasite</th>
                                    <th>Fiyat</th>
                                    <th>Detaylar</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 46 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 49 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 52 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.Capasity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2509, "\"", 2567, 2);
            WriteAttributeValue("", 2516, "/Destination/DestinationDetails/", 2516, 32, true);
#nullable restore
#line 54 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
WriteAttributeValue("", 2548, item.DestinationId, 2548, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591