#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed022892ac7c6022b6aa31ca8c00c2113ddf0612"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offers_ListOffers), @"mvc.1.0.view", @"/Views/Offers/ListOffers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offers/ListOffers.cshtml", typeof(AspNetCore.Views_Offers_ListOffers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed022892ac7c6022b6aa31ca8c00c2113ddf0612", @"/Views/Offers/ListOffers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Offers_ListOffers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OfferListViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-outline-secondary  btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm rounded-circle "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/printthis/printThis.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
  
    ViewData["Title"] = "List Offers";

#line default
#line hidden
            BeginContext(75, 1431, true);
            WriteLiteral(@"<!----------------------Confirm Delete -->
<div class=""modal fade"" id=""dlgConfirmDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h5 class=""modal-title"" id=""exampleModalLabel"">title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <span><h5 class=""card-text"">Are you sure you want to delete?</h5></span>
                <input id=""txtDeleteItemID"" type=""text"" hidden placeholder=""text"" />
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"" style=""width:auto;""><i class=""fa fa-times""></i> cancel</button>
       ");
            WriteLiteral(@"         <button id=""btnSave"" data-dismiss=""modal"" onclick=""DeleteItem()"" type=""button"" class=""btn btn-outline-danger"" style=""width:auto;""><i class=""fa fa-trash""></i> Delete </button>
            </div>
        </div>
    </div>
</div>

<div class=""card"">
    <div class=""card-header"">
        <div class=""flex-container text-center"">
            <span class=""col-11""><h5> Offers List</h5></span>
");
            EndContext();
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                 if (Model.userPermission != null)
                {
                    if (Model.userPermission.CanAdd == true)
                    {

#line default
#line hidden
            BeginContext(1662, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1686, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed022892ac7c6022b6aa31ca8c00c2113ddf06129192", async() => {
                BeginContext(1804, 72, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i> <span class=\"sr-only\">(current)</span>");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1880, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1924, 448, true);
            WriteLiteral(@"

        </div>
    </div>

    <div style="" border:solid 1px black; padding:3px;"">
        <table class=""table table-hover"" id=""myTable"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Id</th>
                    <th>Offer Date</th>
                    <th>Customer</th>
                    <th>Currency</th>
                    <th>Total</th>
                    <th style=""width:30px;""></th>
");
            EndContext();
#line 55 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                     if (Model.userPermission.CanDelete)
                    {

#line default
#line hidden
            BeginContext(2453, 55, true);
            WriteLiteral("                        <th style=\"width:30px;\"></th>\r\n");
            EndContext();
#line 58 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                    }

#line default
#line hidden
            BeginContext(2531, 53, true);
            WriteLiteral("\r\n                </tr>\r\n            </thead>\r\n\r\n\r\n\r\n");
            EndContext();
#line 65 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
             foreach (var offer in Model.OfferList)
            {


#line default
#line hidden
            BeginContext(2654, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2701, 8, false);
#line 69 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                   Write(offer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2709, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2741, 38, false);
#line 70 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                   Write(offer.OfferDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2779, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2811, 18, false);
#line 71 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                   Write(offer.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(2829, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2861, 18, false);
#line 72 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                   Write(offer.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(2879, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2911, 16, false);
#line 73 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                   Write(offer.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2927, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2958, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed022892ac7c6022b6aa31ca8c00c2113ddf061214760", async() => {
                BeginContext(3105, 25, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                                                                                                                                                    WriteLiteral(offer.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3134, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 75 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                     if (Model.userPermission.CanDelete)
                    {

#line default
#line hidden
            BeginContext(3222, 30, true);
            WriteLiteral("                        <td>\r\n");
            EndContext();
            BeginContext(3914, 111, true);
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-outline-danger rounded-circle btn-sm\" style=\"width:auto\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 4025, "\"", 4095, 3);
            WriteAttributeValue("", 4067, "contDelete(\'", 4067, 12, true);
#line 87 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
WriteAttributeValue("", 4079, offer.Id, 4079, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4088, "\',true)", 4088, 7, true);
            EndWriteAttribute();
            BeginContext(4096, 34, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n");
            EndContext();
            BeginContext(4206, 31, true);
            WriteLiteral("                        </td>\r\n");
            EndContext();
#line 92 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                    }

#line default
#line hidden
            BeginContext(4260, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 94 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"

            }

#line default
#line hidden
            BeginContext(4300, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 96 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
             if (Model.OffersTotals.Any())
            {

#line default
#line hidden
            BeginContext(4359, 253, true);
            WriteLiteral("                <tfoot>\r\n                    <tr>\r\n                        <th></th>\r\n                        <th></th>\r\n                        <th></th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n");
            EndContext();
#line 106 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                     foreach (var total in Model.OffersTotals)
                    {

#line default
#line hidden
            BeginContext(4699, 111, true);
            WriteLiteral("                        <tr>\r\n                            <td colspan=4></td>\r\n                            <td>");
            EndContext();
            BeginContext(4811, 35, false);
#line 110 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                           Write(total.TotalAmount.ToString("#0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(4846, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(4849, 18, false);
#line 110 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                                                                 Write(total.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(4867, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 112 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
                    }

#line default
#line hidden
            BeginContext(4928, 26, true);
            WriteLiteral("                </tfoot>\r\n");
            EndContext();
#line 114 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Offers\ListOffers.cshtml"
            }

#line default
#line hidden
            BeginContext(4969, 42, true);
            WriteLiteral("\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5028, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(5036, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed022892ac7c6022b6aa31ca8c00c2113ddf061222116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5091, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5097, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed022892ac7c6022b6aa31ca8c00c2113ddf061223372", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5141, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5147, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed022892ac7c6022b6aa31ca8c00c2113ddf061224628", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5199, 798, true);
                WriteLiteral(@"
    <script>
        $(window).ready(function () {
            $('#mnuTMS').removeClass('collapse show');
            $('#mnuOffers').addClass('collapse show');
            $('#mnuTMS').addClass('collapse hide');
        });

        //---------------Confirm Item Delete
        function contDelete(ItemId) {
            $('#txtDeleteItemID').val(ItemId);
            $('#dlgConfirmDelete').modal('show');
        };

        //-------------- Delete Item Button
        function DeleteItem() {
            $.post('/Offers/Delete',
                {
                    Id: $('#txtDeleteItemID').val()
                },
                function (response, status) {
                    location.reload(true);

                }
            );
        };

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfferListViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
