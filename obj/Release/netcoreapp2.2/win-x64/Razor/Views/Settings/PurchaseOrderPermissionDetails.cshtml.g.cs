#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b5ba9fa7860c6c4c505f019a8c4a69dfce5a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_PurchaseOrderPermissionDetails), @"mvc.1.0.view", @"/Views/Settings/PurchaseOrderPermissionDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/PurchaseOrderPermissionDetails.cshtml", typeof(AspNetCore.Views_Settings_PurchaseOrderPermissionDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b5ba9fa7860c6c4c505f019a8c4a69dfce5a45", @"/Views/Settings/PurchaseOrderPermissionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_PurchaseOrderPermissionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseOrderPermissionDetailsViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListPurchaseOrderPermission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPurchaseOrderPermission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
  
    ViewData["Title"] = "PurchaseOrderPermissionDetails";

#line default
#line hidden
            BeginContext(115, 387, true);
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header card-title text-center"">
        <h5> Purchase Order Permission</h5>
    </div>
    <div class=""card-body"">
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Id-addon"">Id</span>
            <span class=""form-control col-sm-8"" placeholder="" Id"" aria-describedby=""Id-addon""> ");
            EndContext();
            BeginContext(503, 32, false);
#line 12 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                          Write(Model.purchaseOrderPermission.Id);

#line default
#line hidden
            EndContext();
            BeginContext(535, 260, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Name-addon"">User </span>
            <span class=""form-control col-sm-8"" placeholder=""Name"" aria-describedby=""Name-addon""> ");
            EndContext();
            BeginContext(796, 14, false);
#line 16 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                             Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(810, 280, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""BranchName-addon"">Branch </span>
            <span class=""form-control col-sm-8"" placeholder=""BranchName"" aria-describedby=""BranchName-addon""> ");
            EndContext();
            BeginContext(1091, 16, false);
#line 20 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                                         Write(Model.BranchName);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 293, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""AllowConfirm-addon"">Allow Confirm</span>
            <span class=""form-control col-sm-8"" placeholder=""Allow Confirm"" aria-describedby=""AllowConfirm-addon""> ");
            EndContext();
            BeginContext(1401, 42, false);
#line 24 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                                              Write(Model.purchaseOrderPermission.AllowConfirm);

#line default
#line hidden
            EndContext();
            BeginContext(1443, 297, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""AllowDelivery-addon"">Allow Delivery</span>
            <span class=""form-control col-sm-8"" placeholder=""Allow Delivery"" aria-describedby=""AllowDelivery-addon""> ");
            EndContext();
            BeginContext(1741, 43, false);
#line 28 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                                                Write(Model.purchaseOrderPermission.AllowDelivery);

#line default
#line hidden
            EndContext();
            BeginContext(1784, 284, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""AllowPrint-addon"">Allow Print</span>
            <span class=""form-control col-sm-8"" placeholder=""AllowPrint"" aria-describedby=""AllowPrint-addon""> ");
            EndContext();
            BeginContext(2069, 40, false);
#line 32 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                                         Write(Model.purchaseOrderPermission.AllowPrint);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 288, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""AllowVerify-addon"">Allow Verify</span>
            <span class=""form-control col-sm-8"" placeholder=""AllowVerify"" aria-describedby=""AllowVerify-addon""> ");
            EndContext();
            BeginContext(2398, 41, false);
#line 36 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                                           Write(Model.purchaseOrderPermission.AllowVerify);

#line default
#line hidden
            EndContext();
            BeginContext(2439, 263, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Notes-addon"">Phone</span>
            <span class=""form-control col-sm-8"" placeholder=""Notes"" aria-describedby=""Notes-addon""> ");
            EndContext();
            BeginContext(2703, 35, false);
#line 40 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                               Write(Model.purchaseOrderPermission.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(2738, 88, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer text-center\">\r\n        ");
            EndContext();
            BeginContext(2826, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b5ba9fa7860c6c4c505f019a8c4a69dfce5a4512223", async() => {
                BeginContext(2952, 35, true);
                WriteLiteral("<i class=\"fa fa-backward\"></i> Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2991, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3005, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b5ba9fa7860c6c4c505f019a8c4a69dfce5a4514014", async() => {
                BeginContext(3176, 31, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\PurchaseOrderPermissionDetails.cshtml"
                                                                                    WriteLiteral(Model.purchaseOrderPermission.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3211, 26, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurchaseOrderPermissionDetailsViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
