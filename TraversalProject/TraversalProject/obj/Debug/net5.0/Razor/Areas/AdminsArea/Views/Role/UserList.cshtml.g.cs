#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Role\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1f1e4cbb1efa81fd4d8d6187e2faa6d44e01d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminsArea_Views_Role_UserList), @"mvc.1.0.view", @"/Areas/AdminsArea/Views/Role/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1f1e4cbb1efa81fd4d8d6187e2faa6d44e01d8a", @"/Areas/AdminsArea/Views/Role/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e351ef1cd32c7e48a494c3599e7c439888248f", @"/Areas/AdminsArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminsArea_Views_Role_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Role\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcı Listesi</h1>

<p>Burası İlgili Tüm Admin ve Misafirler Listelenip ve Rol Atamaları Yapılabileceği Sayfadır.</p>

<table class=""table table-bordered"">
    <tr>
        <th>Kullanıcı Adı</th>
        <th>Role Ata</th>
       
    </tr>
");
#nullable restore
#line 17 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Role\UserList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Role\UserList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 488, "\"", 531, 2);
            WriteAttributeValue("", 495, "/AdminsArea/Role/AssignRole/", 495, 28, true);
#nullable restore
#line 21 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Role\UserList.cshtml"
WriteAttributeValue("", 523, item.Id, 523, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Rol Ata</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Role\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
