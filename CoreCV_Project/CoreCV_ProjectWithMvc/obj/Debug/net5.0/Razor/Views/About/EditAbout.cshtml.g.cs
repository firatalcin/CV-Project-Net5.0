#pragma checksum "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38548ac227ed30a9b0fd1bfd4b916a6c45a55d65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_EditAbout), @"mvc.1.0.view", @"/Views/About/EditAbout.cshtml")]
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
#line 1 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
using CoreCV_Project.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38548ac227ed30a9b0fd1bfd4b916a6c45a55d65", @"/Views/About/EditAbout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa8ddf4aa2bcd5a9b0ad0a204bbd6457fcc95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_EditAbout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
  
    ViewData["Title"] = "EditAbout";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Hakkımda Düzenleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
 using (Html.BeginForm("EditAbout", "About", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.HiddenFor(x => x.AboutId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextAreaFor(x => x.Description, 10,2, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Yaş"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextBoxFor(x => x.Age, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Mail"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextBoxFor(x => x.Mail, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Telefon"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextBoxFor(x => x.Phone, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 35 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Adres"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextBoxFor(x => x.Address, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 39 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.Label("Resim Yolu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />   \r\n    <button class=\"btn btn-info\">Güncelle</button>\r\n");
#nullable restore
#line 44 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\About\EditAbout.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
