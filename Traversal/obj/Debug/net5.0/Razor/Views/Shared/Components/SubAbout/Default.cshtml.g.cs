#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\SubAbout\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1bf1ef932a5f8247eaf90dde8208efd0e4a243a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SubAbout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SubAbout/Default.cshtml")]
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
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\SubAbout\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1bf1ef932a5f8247eaf90dde8208efd0e4a243a", @"/Views/Shared/Components/SubAbout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006532a3c6a6598c48ce5993d263f760e809f9c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SubAbout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
  <section class=""w3l-bottom py-5"">
    <div class=""container py-md-4 py-3 text-center"">
      <div class=""row my-lg-4 mt-4"">
        <div class=""col-lg-9 col-md-10 ml-auto"">
          <div class=""bottom-info ml-auto"">
            <div class=""header-section text-left"">
              <h3 class=""hny-title two"">Seyahat Etmek İnsanı Daha Mutlu Yapar</h3>
             
              <p class=""mt-3 pr-lg-5"">");
#nullable restore
#line 12 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\SubAbout\Default.cshtml"
                                 Write(Model.FirstOrDefault().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <a href=\"about.html\" class=\"btn btn-style btn-secondary mt-5\">Read More</a>\r\n            </div>\r\n           \r\n\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
