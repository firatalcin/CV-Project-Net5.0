#pragma checksum "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0268567a14e7c3d648a38e625480223edac8ca0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\_ViewImports.cshtml"
using CoreCV_ProjectWithMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\_ViewImports.cshtml"
using CoreCV_ProjectWithMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
using CoreCV_Project.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0268567a14e7c3d648a38e625480223edac8ca0e", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa8ddf4aa2bcd5a9b0ad0a204bbd6457fcc95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Hizmet Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"">Düzenle</th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 23 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
                   Write(item.ServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"budget\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td><a");
            BeginWriteAttribute("href", " href= \"", 981, "\"", 1027, 2);
            WriteAttributeValue("", 989, "/Service/DeleteService/", 989, 23, true);
#nullable restore
#line 30 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
WriteAttributeValue("", 1012, item.ServiceId, 1012, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href= \"", 1092, "\"", 1136, 2);
            WriteAttributeValue("", 1100, "/Service/EditService/", 1100, 21, true);
#nullable restore
#line 31 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
WriteAttributeValue("", 1121, item.ServiceId, 1121, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Service/AddService/\" class=\"btn btn-success\">Yeni Hizmet Ekle</a>\r\n</div>\r\n\r\n");
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
