#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185f3c202f372b461e160220d18090b61e5b0616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration__RolePages), @"mvc.1.0.view", @"/Views/Administration/_RolePages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/_RolePages.cshtml", typeof(AspNetCore.Views_Administration__RolePages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185f3c202f372b461e160220d18090b61e5b0616", @"/Views/Administration/_RolePages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration__RolePages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MSIS.ViewModels.RolePagesViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 317, true);
            WriteLiteral(@"<table id=""myTable"" class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th>Page</th>
            <th>View</th>
            <th>Add</th>
            <th>Edit</th>
            <th>Delete</th>
            <th style=""width:50px;""></th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 15 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(416, 31, true);
            WriteLiteral("        <tr>\r\n            <td> ");
            EndContext();
            BeginContext(448, 13, false);
#line 18 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
            Write(item.PageName);

#line default
#line hidden
            EndContext();
            BeginContext(461, 45, true);
            WriteLiteral("</td>\r\n            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 506, "\"", 529, 1);
#line 19 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
WriteAttributeValue("", 516, item.CanView, 516, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(530, 47, true);
            WriteLiteral("/></td>\r\n            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 577, "\"", 599, 1);
#line 20 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
WriteAttributeValue("", 587, item.CanAdd, 587, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(600, 48, true);
            WriteLiteral(" /></td>\r\n            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 648, "\"", 671, 1);
#line 21 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
WriteAttributeValue("", 658, item.CanEdit, 658, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(672, 47, true);
            WriteLiteral("/></td>\r\n            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 719, "\"", 744, 1);
#line 22 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
WriteAttributeValue("", 729, item.CanDelete, 729, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(745, 136, true);
            WriteLiteral("/> </td>\r\n            <td>\r\n                <button type=\'button\' id=\'btnEditItem\' class=\'btn btn-outline-primary btn-sm rounded-circle\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=", 881, "", 912, 3);
            WriteAttributeValue("", 890, "EditItem(", 890, 9, true);
#line 24 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
WriteAttributeValue("", 899, item.PageId, 899, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 911, ")", 911, 1, true);
            EndWriteAttribute();
            BeginContext(912, 91, true);
            WriteLiteral(" style=\'width:auto\'><i class=\'fa fa-edit\'></i></button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 27 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Administration\_RolePages.cshtml"
        }

#line default
#line hidden
            BeginContext(1014, 30, true);
            WriteLiteral("    </tbody>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MSIS.ViewModels.RolePagesViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
