#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cac41142e08346e1ee9f7bb3faf77c577d298ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offers_Details), @"mvc.1.0.view", @"/Views/Offers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offers/Details.cshtml", typeof(AspNetCore.Views_Offers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cac41142e08346e1ee9f7bb3faf77c577d298ff", @"/Views/Offers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Offers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OfferDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintTaskDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tasks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListOffers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 15, true);
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(88, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cac41142e08346e1ee9f7bb3faf77c577d298ff6565", async() => {
                BeginContext(223, 34, true);
                WriteLiteral(" <i class=\"fa fa-print\"> Print</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 446, true);
            WriteLiteral(@"
</div>
<div class=""card mt-3"">
    <div class=""card-header"">
        <h3 class=""text-center"">Offer Details</h3>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""input-group mt-sm-3"">
                    <span id=""Id-addon"" class=""col-sm-3 input-group-text"">Id</span>
                    <span class=""form-control col-sm-4"" aria-describedby=""Id-addon""><h5>");
            EndContext();
            BeginContext(708, 8, false);
#line 19 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(716, 334, true);
            WriteLiteral(@"</h5></span>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""input-group mt-sm-3"">
                    <span id=""OfferDate-addon"" class=""col-sm-3 input-group-text"">Date</span>
                    <span class=""form-control col-sm-6"" aria-describedby=""OfferDate-addon""><h5>");
            EndContext();
            BeginContext(1051, 38, false);
#line 25 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                                          Write(Model.OfferDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 387, true);
            WriteLiteral(@"</h5></span>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""input-group mt-sm-3"">
                    <span id=""CustomerName-addon"" class=""col-sm-3 input-group-text"">Customer</span>
                    <span class=""form-control col-sm-6"" aria-describedby=""CustomerName-addon""><h5>");
            EndContext();
            BeginContext(1477, 18, false);
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                                             Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 344, true);
            WriteLiteral(@"</h5></span>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""input-group mt-sm-3"">
                    <span id=""CurrencyName-addon"" class=""col-sm-3 input-group-text"">Currency</span>
                    <span class=""form-control col-sm-6"" aria-describedby=""CurrencyName-addon""><h5>");
            EndContext();
            BeginContext(1840, 18, false);
#line 39 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                                             Write(Model.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(1858, 362, true);
            WriteLiteral(@"</h5></span>
                </div>
            </div>
            <div class=""col-sm-12"">
                <div class=""input-group mt-sm-3"">
                    <span id=""OtherInformation-addon"" class=""col-sm-3 input-group-text"">Other Information</span>
                    <span class=""form-control col-sm-6"" aria-describedby=""OtherInformation-addon""><h5>");
            EndContext();
            BeginContext(2221, 22, false);
#line 45 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                                                 Write(Model.OtherInformation);

#line default
#line hidden
            EndContext();
            BeginContext(2243, 258, true);
            WriteLiteral(@"</h5></span>
                </div>
            </div>
        </div>
        <br />

        <div class=""row"">
            <div class=""bg-light col-sm-12  "">

                <H3 class=""card-title text-center"">Offer Items</H3>
            </div>
");
            EndContext();
#line 56 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
             if (Model.OfferItems.Any())
            {

#line default
#line hidden
            BeginContext(2558, 426, true);
            WriteLiteral(@"                <table class=""table  border table-hover"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>Item</th>
                            <th>QNT.</th>
                            <th>Unit</th>
                            <th>Unit Price</th>
                            <th>Total Price</th>
                        </tr>
                    </thead>
");
            EndContext();
#line 68 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                     foreach (var item in Model.OfferItems)
                    {

#line default
#line hidden
            BeginContext(3068, 106, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <span><h5>");
            EndContext();
            BeginContext(3175, 13, false);
#line 72 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                     Write(item.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(3188, 125, true);
            WriteLiteral("</h5></span>\r\n                            </td>\r\n                            <td>\r\n                                <span><h5>");
            EndContext();
            BeginContext(3314, 8, false);
#line 75 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                     Write(item.QNT);

#line default
#line hidden
            EndContext();
            BeginContext(3322, 125, true);
            WriteLiteral("</h5></span>\r\n                            </td>\r\n                            <td>\r\n                                <span><h5>");
            EndContext();
            BeginContext(3448, 17, false);
#line 78 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                     Write(item.ItemUnitName);

#line default
#line hidden
            EndContext();
            BeginContext(3465, 125, true);
            WriteLiteral("</h5></span>\r\n                            </td>\r\n                            <td>\r\n                                <span><h5>");
            EndContext();
            BeginContext(3591, 14, false);
#line 81 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                     Write(item.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3605, 125, true);
            WriteLiteral("</h5></span>\r\n                            </td>\r\n                            <td>\r\n                                <span><h5>");
            EndContext();
            BeginContext(3731, 15, false);
#line 84 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                     Write(item.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3746, 80, true);
            WriteLiteral("</h5></span>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 87 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(3849, 26, true);
            WriteLiteral("                </table>\r\n");
            EndContext();
#line 89 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(3925, 64, true);
            WriteLiteral("                <h5 class=\"card-title\">none at the moment</h5>\r\n");
            EndContext();
#line 94 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(4004, 102, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        <div class=\"text-center mr-sm-2\">\r\n");
            EndContext();
#line 99 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
             if (Model.Permission != null)
            {
                if (Model.Permission.CanEdit == true)
                {

#line default
#line hidden
            BeginContext(4239, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(4259, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cac41142e08346e1ee9f7bb3faf77c577d298ff18709", async() => {
                BeginContext(4381, 31, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 104 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\Details.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(4452, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(4464, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cac41142e08346e1ee9f7bb3faf77c577d298ff21762", async() => {
                BeginContext(4571, 34, true);
                WriteLiteral("<i class=\"fa fa-times\"></i> Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4609, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4666, 250, true);
                WriteLiteral("\r\n    <script>\r\n        $(window).ready(function () {\r\n            $(\'#mnuTMS\').removeClass(\'collapse show\');\r\n            $(\'#mnuOffers\').addClass(\'collapse show\');\r\n            $(\'#mnuTMS\').addClass(\'collapse hide\');\r\n        });\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfferDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
