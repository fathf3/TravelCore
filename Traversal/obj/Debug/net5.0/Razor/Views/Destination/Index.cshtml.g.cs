#pragma checksum "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2d2362ff21bf3b19d15a943dd61c4ea7e06e7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_Index), @"mvc.1.0.view", @"/Views/Destination/Index.cshtml")]
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
#line 4 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2d2362ff21bf3b19d15a943dd61c4ea7e06e7a", @"/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006532a3c6a6598c48ce5993d263f760e809f9c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayour.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c2d2362ff21bf3b19d15a943dd61c4ea7e06e7a4001", async() => {
                WriteLiteral(@"

  <section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
      <div class=""container"">
        <h2 class=""title"">Rotalar </h2>
        <ul class=""breadcrumbs-custom-path mt-2"">
          <li><a href=""/Default/Index"">Ana Sayfa</a></li>
          <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rotalar </li>
        </ul>
      </div>
    </div>
  </section>

 <section class=""grids-1 py-5"">
  <div class=""grids py-lg-5 py-md-4"">
      <div class=""container"">
          <h3 class=""hny-title mb-5"">Tur Rotalarımız</h3>
          <div class=""row"">
");
#nullable restore
#line 29 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
               foreach (var item in Model)
                    {
    

#line default
#line hidden
#nullable disable
                WriteLiteral("              <div class=\"col-lg-4 col-md-4 col-6\">\r\n                  <div class=\"column\">\r\n                      <a");
                BeginWriteAttribute("href", " href=\"", 978, "\"", 1036, 2);
                WriteAttributeValue("", 985, "/Destination/DestinationDetails/", 985, 32, true);
#nullable restore
#line 34 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1017, item.DestinationID, 1017, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 1042, "\"", 1059, 1);
#nullable restore
#line 34 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1048, item.Image, 1048, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1060, "\"", 1066, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"></a>\r\n                      <div class=\"info\">\r\n                          <h4><a");
                BeginWriteAttribute("href", " href=\"", 1166, "\"", 1224, 2);
                WriteAttributeValue("", 1173, "/Destination/DestinationDetails/", 1173, 32, true);
#nullable restore
#line 36 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1205, item.DestinationID, 1205, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
                                                                                       Write(item.CityName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\r\n                          <p>");
#nullable restore
#line 37 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
                        Write(item.DayNight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                          <div class=\"dst-btm\">\r\n                            <h6");
                BeginWriteAttribute("class", " class=\"", 1380, "\"", 1388, 0);
                EndWriteAttribute();
                WriteLiteral(">Start From </h6>\r\n                            <span>");
#nullable restore
#line 40 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                          </div>\r\n                      </div>\r\n                  </div>\r\n              </div>\r\n");
#nullable restore
#line 45 "C:\Users\fatih\Documents\Code\C#\Traversal\Traversal\Views\Destination\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("          </div>\r\n      </div>\r\n</div></section>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
