#pragma checksum "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\ServiceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31778986cfb77c1b693602f6916ae52fecb03bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
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
#line 1 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\ServiceList\Default.cshtml"
using CoreCV_Project.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31778986cfb77c1b693602f6916ae52fecb03bb9", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa8ddf4aa2bcd5a9b0ad0a204bbd6457fcc95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""section px-3 px-lg-4 pt-5"" id=""services"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Hizmetlerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Sizlere aşağıdaki hizmetleri sunmaktayım.</p>
        </div>

        <div class=""row py-3"">
");
#nullable restore
#line 15 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\ServiceList\Default.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 text-center\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n                    <img class=\"mb-2\"");
            BeginWriteAttribute("src", " src=\"", 659, "\"", 679, 1);
#nullable restore
#line 18 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\ServiceList\Default.cshtml"
WriteAttributeValue("", 665, item.ImageUrl, 665, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"web design\" />\r\n                    <div class=\"h5\">");
#nullable restore
#line 19 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\ServiceList\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 21 "D:\Kurslar\ASP.NET_MVC_CORE\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\ServiceList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
