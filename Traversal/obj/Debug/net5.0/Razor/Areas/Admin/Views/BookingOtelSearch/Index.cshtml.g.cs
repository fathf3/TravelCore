#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a733fa7f6e652b6f7082efbe03ab0f80d79c9418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BookingOtelSearch_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BookingOtelSearch/Index.cshtml")]
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
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a733fa7f6e652b6f7082efbe03ab0f80d79c9418", @"/Areas/Admin/Views/BookingOtelSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad659cf7607014f894977cd2a8e8398e4bae2d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BookingOtelSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Traversal.Areas.Admin.Models.BookingSearchViewModel.Result>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminPanel.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""container"">
  <div class=""row"">
    <div class=""col-xs-6 col-md-12"">
<h1 class=""text lnr-text-align-center"" style=""align-content: center"">Otel Araması PARİS</h1>
<br />

    <table class=""table table-bordered"">
         <thead class=""thead-dark"" style=""background-color: cadetblue; color: white"">
        <tr>
            <td>#</td>
            <td>Otel Adı</td>
            <td>Otel Puanı</td>
            <td>Otel Değerlendirmesi</td>
            <td>Resim</td>
            <td>Detaylar</td>
        </tr>
        </thead>
");
#nullable restore
#line 25 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
         foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
           Write(item.reviewScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
           Write(item.reviewScoreWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", "  src=\"", 997, "\"", 1022, 1);
#nullable restore
#line 33 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
WriteAttributeValue("", 1004, item.photoUrls[0], 1004, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
    }      

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n            </div></div></div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Traversal.Areas.Admin.Models.BookingSearchViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
