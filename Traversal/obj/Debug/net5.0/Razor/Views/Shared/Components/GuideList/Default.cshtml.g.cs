#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ea1629ebf547bc299bfa883b565273a1a94e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GuideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GuideList/Default.cshtml")]
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
using Traversal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ea1629ebf547bc299bfa883b565273a1a94e60", @"/Views/Shared/Components/GuideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d12b22944ccdb0db5b735e5162ab2aa607e1c5dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GuideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
 <div class=""col-12 col-xl-4"">
          <div class=""card h-100"">
            <div class=""card-header pb-0 p-3"">
              <h6 class=""mb-0"">Rehber Listesti</h6>
            </div>
            <div class=""card-body p-3"">
              <ul class=""list-group"">
");
#nullable restore
#line 13 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml"
                   foreach (var item in Model)
                {
                    
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item border-0 d-flex align-items-center px-0 mb-2\">\r\n                  <div class=\"avatar me-3\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 588, "\"", 605, 1);
#nullable restore
#line 19 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml"
WriteAttributeValue("", 594, item.Image, 594, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"kal\" class=\"border-radius-lg shadow\">\r\n                  </div>\r\n                  <div class=\"d-flex align-items-start flex-column justify-content-center\">\r\n                    <h6 class=\"mb-0 text-sm\">");
#nullable restore
#line 22 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"mb-0 text-xs\">");
#nullable restore
#line 23 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml"
                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                  <a class=\"btn btn-link pe-3 ps-0 mb-0 ms-auto\" href=\"javascript:;\">Profil</a>\r\n                </li>\r\n");
#nullable restore
#line 27 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Shared\Components\GuideList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </ul>\r\n            </div>\r\n          </div>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
