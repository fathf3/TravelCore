#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4d46edf63d9a3e1c35a41840ab93002b63e1d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 4 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4d46edf63d9a3e1c35a41840ab93002b63e1d2", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad659cf7607014f894977cd2a8e8398e4bae2d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminPanel.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div style=""align-content: center"">
<div class=""container m-5"">
    

<table class=""table table-bordred"">
                                        
<tr style=""background-color: darkcyan; color:white"">
                                              
        <th>#</th>
        <th>Name</th>
        <th>Mail</th>
        <th>Resim</th>
        <th>Telefon No.</th>
        <th>Tur Geçmişi</th>
        <th>Yorumlar</th>
        <th>Düzenle</th>
        <th>Sil</th>
</tr>
                                       
                                        
");
#nullable restore
#line 30 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
  foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr class=\"tr-shadow\">\r\n                                               \r\n <th>");
#nullable restore
#line 34 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
 Write(sayac = sayac+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 35 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 36 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 37 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
       Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 38 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n  <th><a");
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1063, 2);
            WriteAttributeValue("", 1027, "/admin/User/ReservationUser/", 1027, 28, true);
#nullable restore
#line 39 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1055, item.Id, 1055, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" clas=\"btn btn-outline-success\">Göster</a> </th>\r\n  <th><a");
            BeginWriteAttribute("href", " href=\"", 1122, "\"", 1161, 2);
            WriteAttributeValue("", 1129, "/admin/User/CommentUser/", 1129, 24, true);
#nullable restore
#line 40 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1153, item.Id, 1153, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" clas=\"btn btn-outline-info\">Göster</a> </th>\r\n  <th><a");
            BeginWriteAttribute("href", " href=\"", 1217, "\"", 1256, 2);
            WriteAttributeValue("", 1224, "/admin/Comment/EditUser/", 1224, 24, true);
#nullable restore
#line 41 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1248, item.Id, 1248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" clas=\"btn btn-outline-secondary\">Düzenle</a> </th>\r\n  <th><a");
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1356, 2);
            WriteAttributeValue("", 1325, "/admin/User/DeleteUser/", 1325, 23, true);
#nullable restore
#line 42 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1348, item.Id, 1348, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" clas=\"btn btn-outline-danger\">Sil</a> </th>\r\n</tr>\r\n");
#nullable restore
#line 44 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Admin\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       \r\n</table>\r\n<a href=\"/Admin/User/AddUser\" clas=\"btn btn-outline-primary\">Yeni Kullanıcı Ekle</a>\r\n\r\n</div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
