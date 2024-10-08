#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8025824c521b61d94c63be256a317974558879e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationCQRS_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8025824c521b61d94c63be256a317974558879e0", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad659cf7607014f894977cd2a8e8398e4bae2d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_DestinationCQRS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Traversal.CQRS.Results.DestinationResult.GetAllDestinationQueryResult>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminPanel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<div class=""container"">
  <div class=""row"">
    <div class=""col-xs-6 col-md-12"">
<h1 class=""text lnr-text-align-center"" style=""align-content: center"">Burası Destination</h1>

    <table class=""table table-bordered"">
         <thead class=""thead-dark"" style=""background-color: cadetblue; color: white"">
        <tr>
            <td>#</td>
            <td>Şehir</td>
            <td>Fiyat</td>
            <td>Gün Gece</td>
            <td>Kapasite</td>
            <td>Sitede Gör</td>
            <td>Sil</td>
            <td>Güncelle</td>
            
        </tr>
        </thead>
");
#nullable restore
#line 28 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
         foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.dayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1094, 2);
            WriteAttributeValue("", 1054, "/Destination/DestinationDetails/", 1054, 32, true);
#nullable restore
#line 36 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 1086, item.id, 1086, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1164, "\"", 1216, 2);
            WriteAttributeValue("", 1171, "/Admin/Destination/DeleteDestination/", 1171, 37, true);
#nullable restore
#line 37 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 1208, item.id, 1208, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1281, "\"", 1333, 2);
            WriteAttributeValue("", 1288, "/Admin/Destination/UpdateDestination/", 1288, 37, true);
#nullable restore
#line 38 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 1325, item.id, 1325, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n            \r\n\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </table>\r\n    <a href=\"/Admin/Destination/AddDestination\"><button type=\"submit\" class=\"btn btn-primary btn-block mb-4\">Yeni Tur Rotası</button></a>\r\n     \r\n            </div></div></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Traversal.CQRS.Results.DestinationResult.GetAllDestinationQueryResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
