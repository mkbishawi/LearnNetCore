#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c5ff355301e2cf1748b8db4b0c0cdcb58fea32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offers__PrintOfferList), @"mvc.1.0.view", @"/Views/Offers/_PrintOfferList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offers/_PrintOfferList.cshtml", typeof(AspNetCore.Views_Offers__PrintOfferList))]
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
#line 1 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\_ViewImports.cshtml"
using MSIS.ViewModels;

#line default
#line hidden
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\_ViewImports.cshtml"
using MSIS.Models;

#line default
#line hidden
#line 4 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c5ff355301e2cf1748b8db4b0c0cdcb58fea32", @"/Views/Offers/_PrintOfferList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Offers__PrintOfferList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SQLOffersViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"
  
    ViewData["Title"] = "List Offers";

#line default
#line hidden
            BeginContext(80, 248, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table table-hover\" id=\"myTable\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Offer Date</th>\r\n            <th>Customer</th>\r\n            <th>Currency</th>\r\n            <th>Total</th>\r\n");
            EndContext();
            BeginContext(518, 37, true);
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n\r\n\r\n\r\n");
            EndContext();
#line 27 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"
     foreach (var offer in Model)
    {


#line default
#line hidden
            BeginContext(599, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(630, 8, false);
#line 31 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"
           Write(offer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(638, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(662, 38, false);
#line 32 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"
           Write(offer.OfferDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(700, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(724, 18, false);
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"
           Write(offer.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(742, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(766, 18, false);
#line 34 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"
           Write(offer.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(784, 31, true);
            WriteLiteral("</td>\r\n            <td>0</td>\r\n");
            EndContext();
            BeginContext(1371, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 45 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\_PrintOfferList.cshtml"

    }

#line default
#line hidden
            BeginContext(1395, 14, true);
            WriteLiteral("\r\n\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SQLOffersViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591