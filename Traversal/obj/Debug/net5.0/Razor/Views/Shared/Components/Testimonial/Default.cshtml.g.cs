#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c56b0e9d9915e3757c0d4cc7cd4a602c7ef6d6f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c56b0e9d9915e3757c0d4cc7cd4a602c7ef6d6f7", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006532a3c6a6598c48ce5993d263f760e809f9c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
 <section class=""w3l-clients"" id=""clients"">
    <!-- /grids -->
    <div class=""cusrtomer-layout py-5"">
      <div class=""container py-lg-4 py-md-3 pb-lg-0"">
        <div class=""heading text-center mx-auto"">
          <h6 class=""sub-title text-center"">Müşteri Yorumları</h6>
          <h3 class=""hny-title mb-md-5 mb-4"">Müşterilerimizin Bizim Hakkında Düşünceleri</h3>
        </div>
        <!-- /grids -->
        <div class=""testimonial-width"">
          <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
            
");
#nullable restore
#line 16 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml"
               foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
              <div class=""testimonial-content"">
                <div class=""testimonial"">
                  <blockquote>
                    <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                   ");
#nullable restore
#line 23 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml"
              Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </blockquote>\r\n                  <div class=\"testi-des\">\r\n                    <div class=\"test-img\"><img");
            BeginWriteAttribute("src", " src=\"", 1068, "\"", 1091, 1);
#nullable restore
#line 26 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml"
WriteAttributeValue("", 1074, item.ClientImage, 1074, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\r\n                    </div>\r\n                    <div class=\"peopl align-self\">\r\n                      <h3>");
#nullable restore
#line 29 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml"
                     Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                     \r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\n");
#nullable restore
#line 36 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\Testimonial\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n           \r\n\r\n\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <!-- /grids -->\r\n    </div>\r\n    <!-- //grids -->\r\n  </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
