#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Admin\PartialSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309b6736be1097cd50758bfdb1a0a2e9ffdf1e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialSideBar), @"mvc.1.0.view", @"/Views/Admin/PartialSideBar.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309b6736be1097cd50758bfdb1a0a2e9ffdf1e8c", @"/Views/Admin/PartialSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f278c2e195091e15ef6b360e804c00589ff5a5c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""menu-inner py-1"">
    <!-- Dashboard -->
    <li class=""menu-item"">
        <a href=""/AdminsArea/Dashboard/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-home-circle""></i>
            <div data-i18n=""Analytics"">Dashboard</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/AdminsArea/A_Destination/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-ship""></i>
            <div data-i18n=""Analytics"">Rotalar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/AdminsArea/Comment/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-comment""></i>
            <div data-i18n=""Analytics"">Yorumlar</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/AdminsArea/User/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-face""></i>
            <div data-i18n=""Analytics"">Misafirler</div>
        </a>
    </li>
    <li class=""menu-ite");
            WriteLiteral(@"m"">
        <a href=""/AdminsArea/ContactUs/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-message-alt""></i>
            <div data-i18n=""Analytics"">Mesajlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Adminsarea/Guide/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-directions""></i>
            <div data-i18n=""Analytics"">Rehberlerimiz</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Excel/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-report""></i>
            <div data-i18n=""Analytics"">Raporlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Adminsarea/Mail/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-mail-send""></i>
            <div data-i18n=""Analytics"">Mail Gönder</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Adminsarea/Role/UserList"" class=""menu-link"">
            <i cl");
            WriteLiteral(@"ass=""menu-icon tf-icons bx bx-user""></i>
            <div data-i18n=""Analytics"">Kullanıcı List / Rol</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Adminsarea/SubAbout/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-abacus""></i>
            <div data-i18n=""Analytics"">Alt Hakkında</div>
        </a>
    </li> 
    <li class=""menu-item"">
        <a href=""/AdminsArea/ContactUs/RecycleBinList"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-bookmark""></i>
            <div data-i18n=""Analytics"">Çöp Kutusu Mesajları</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Adminsarea/Role/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-thermometer""></i>
            <div data-i18n=""Analytics"">Rol İşlemleri</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Login/LogOut/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-exit""></i>
          ");
            WriteLiteral("  <div data-i18n=\"Analytics\">Çıkış Yap</div>\r\n        </a>\r\n    </li>\r\n</ul>");
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