#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5634944a8e97b6c463f1d7e66f5c6369b9a99d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrders__PurchaseOrderItems), @"mvc.1.0.view", @"/Views/PurchaseOrders/_PurchaseOrderItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrders/_PurchaseOrderItems.cshtml", typeof(AspNetCore.Views_PurchaseOrders__PurchaseOrderItems))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5634944a8e97b6c463f1d7e66f5c6369b9a99d7", @"/Views/PurchaseOrders/_PurchaseOrderItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrders__PurchaseOrderItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PurchaseOrderItemsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 1218, true);
            WriteLiteral(@"<div class=""card mt-3 col-12"">

    <div class=""card-header"">
        <h5 class=""card-title""> Purchase Order Items</h5>
        <button id=""btnAddItem"" type=""button"" class=""btn btn-primary"" style=""width:auto;"">
            <i class=""fa fa-plus-circle""></i>
        </button>
        <button id=""btnEditItem"" type=""button"" class=""btn btn-primary"" style=""width:auto;"">
            <i class=""fa fa-edit""></i>
        </button>

        <button id=""btnDeleteItem"" class=""btn btn-danger"" style=""width:auto""><i class=""fa fa-trash""></i></button>
    </div>
    <div class=""card-body"">
        <table id=""tblItemDetails"" class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Id</th>
                    <th>Item</th>
                    <th style=""visibility:hidden;"">ItemUnitId</th>
                    <th>Unit</th>
                    <th>Qnt.</th>
                    <th>Unit Price</th>
                    <th>Total Price</th>
                  ");
            WriteLiteral("  <th>Description</th>\r\n                    <th style=\"width:30px;\"></th>\r\n                    <th style=\"width:30px;\"></th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1325, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1372, 7, false);
#line 36 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1411, 13, false);
#line 37 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1456, 15, false);
#line 38 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.ItemUnitId);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1503, 17, false);
#line 39 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.ItemUnitName);

#line default
#line hidden
            EndContext();
            BeginContext(1520, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1552, 8, false);
#line 40 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.QNT);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1592, 14, false);
#line 41 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1606, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1638, 15, false);
#line 42 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1653, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1685, 16, false);
#line 43 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 149, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\'button\' id=\'btnEditItem\' class=\'btn btn-outline-primary btn-sm rounded-circle\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=", 1850, "", 1877, 3);
            WriteAttributeValue("", 1859, "EditItem(", 1859, 9, true);
#line 45 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
WriteAttributeValue("", 1868, item.Id, 1868, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1876, ")", 1876, 1, true);
            EndWriteAttribute();
            BeginContext(1877, 227, true);
            WriteLiteral(" style=\'width:auto\'><i class=\'fa fa-edit\'></i></button>\r\n                    </td>\r\n                    <td>\r\n                        <button type=\'button\' id=\'btnconfirmDel\' class=\'btn btn-outline-danger btn-sm rounded-circle\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=", 2104, "", 2133, 3);
            WriteAttributeValue("", 2113, "contDelete(", 2113, 11, true);
#line 48 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
WriteAttributeValue("", 2124, item.Id, 2124, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2132, ")", 2132, 1, true);
            EndWriteAttribute();
            BeginContext(2133, 110, true);
            WriteLiteral(" style=\'width:auto\'><i class=\'fa fa-trash\'></i></button>\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 52 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\PurchaseOrders\_PurchaseOrderItems.cshtml"
                }

#line default
#line hidden
            BeginContext(2262, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PurchaseOrderItemsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
