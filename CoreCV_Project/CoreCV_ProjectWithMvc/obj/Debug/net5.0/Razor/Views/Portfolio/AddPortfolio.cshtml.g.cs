#pragma checksum "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee3a0a62ec1f5fc9817c8dba5dc82997971e10e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
#line 1 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\_ViewImports.cshtml"
using CoreCV_ProjectWithMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\_ViewImports.cshtml"
using CoreCV_ProjectWithMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
using CoreCV_Project.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3a0a62ec1f5fc9817c8dba5dc82997971e10e7", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa8ddf4aa2bcd5a9b0ad0a204bbd6457fcc95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Proje Ekleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Küçük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Büyük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl2, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje URL"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Bitirme Yüzdesi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Value, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Ücreti"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 32 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Resmi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Platform, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 36 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\AddPortfolio.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
