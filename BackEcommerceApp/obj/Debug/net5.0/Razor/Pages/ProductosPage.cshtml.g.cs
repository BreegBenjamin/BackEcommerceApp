#pragma checksum "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a1a0a249eed1e949c46c315f1dc3a56103cf2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BackEcommerceApp.Pages.Pages_ProductosPage), @"mvc.1.0.razor-page", @"/Pages/ProductosPage.cshtml")]
namespace BackEcommerceApp.Pages
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
#line 1 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\_ViewImports.cshtml"
using BackEcommerceApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a1a0a249eed1e949c46c315f1dc3a56103cf2b", @"/Pages/ProductosPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad305014d72644e8bab57be9d6cdb5917603a3f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProductosPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <h3>Categorias</h3>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""table-responsive"">
                <table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 20 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml"
                         foreach (var items in Model.Productos)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <div class=\"card\" style=\"width: 18rem;\">\r\n                                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 829, "\"", 850, 1);
#nullable restore
#line 25 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml"
WriteAttributeValue("", 835, items.ImageUrl, 835, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                                        <div class=\"card-body\">\r\n                                            <h5 class=\"card-title\">");
#nullable restore
#line 27 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml"
                                                              Write(items.TItle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml"
                                                            Write(items.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <a href=\"#\" class=\"btn btn-primary\">Comprar!</a>\r\n                                            <span>$");
#nullable restore
#line 30 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml"
                                              Write(items.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\ecajar\source\repos\BackEcommerceApp\BackEcommerceApp\Pages\ProductosPage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductosPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductosPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductosPageModel>)PageContext?.ViewData;
        public ProductosPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
