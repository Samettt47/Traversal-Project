#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75543217a20df6b305e8d327eda1733eac477f05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminsArea_Views_DestinationCQRS_Index), @"mvc.1.0.view", @"/Areas/AdminsArea/Views/DestinationCQRS/Index.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.Areas.AdminsArea.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.DestinationResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.GuideResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75543217a20df6b305e8d327eda1733eac477f05", @"/Areas/AdminsArea/Views/DestinationCQRS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e351ef1cd32c7e48a494c3599e7c439888248f", @"/Areas/AdminsArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminsArea_Views_DestinationCQRS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllDestinationQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/_AdminLayout.cshtml";
        int count = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h2>CQRS Tur Rota Listesi</h2>
    <br />
    <br>

    <table class=""table table-striped"">
        <tr>
            <th>#</th>
            <th>Şehir</th>
            <th>Gün-Gece</th>
            <th>Fiyat</th>
            <th>Kapasite</th> 
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
");
#nullable restore
#line 22 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
         foreach (var item in Model)
        {
            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
               Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
               Write(item.daynight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
               Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
               Write(item.capacisty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 816, "\"", 877, 2);
            WriteAttributeValue("", 823, "/AdminsArea/DestinationCQRS/DeleteDestination/", 823, 46, true);
#nullable restore
#line 31 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 869, item.Id, 869, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 946, "\"", 1004, 2);
            WriteAttributeValue("", 953, "/AdminsArea/DestinationCQRS/GetDestination/", 953, 43, true);
#nullable restore
#line 32 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 996, item.Id, 996, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\DestinationCQRS\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n    <a href=\"/AdminsArea/DestinationCQRS/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllDestinationQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591