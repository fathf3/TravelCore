#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32638e840b865630473aa7196372ed602b305d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyOldReservations), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyOldReservations.cshtml")]
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
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\_ViewImports.cshtml"
using Traversal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\_ViewImports.cshtml"
using Traversal.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32638e840b865630473aa7196372ed602b305d9d", @"/Areas/Member/Views/Reservation/MyOldReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63de5b753cd2435010d72e6a5eba309dd397f176", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyOldReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
  
    ViewData["Title"] = "MyOldReservations";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"align-center\"> Geçmiş Rezarvasyonlarım</h1> \r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>Lokasyon</th>\r\n        <th>Kişi Sayısı</th>\r\n        <th>Tarih</th>\r\n        <th>Durum</th>\r\n    </tr>\r\n    \r\n\r\n");
#nullable restore
#line 20 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
 foreach (var item in Model)
{
    if(item.ReservationDate < DateTime.Now)
    {
       

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
           Write(item.Destination.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
            Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
           Write(item.ReservationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Areas\Member\Views\Reservation\MyOldReservations.cshtml"
        }
        else
        {
            
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591