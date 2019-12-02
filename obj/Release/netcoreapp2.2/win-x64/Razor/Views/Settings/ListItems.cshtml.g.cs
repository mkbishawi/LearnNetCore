#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6b7b0da34075eb9384aac83c7fd8194a9aaba4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_ListItems), @"mvc.1.0.view", @"/Views/Settings/ListItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/ListItems.cshtml", typeof(AspNetCore.Views_Settings_ListItems))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6b7b0da34075eb9384aac83c7fd8194a9aaba4", @"/Views/Settings/ListItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_ListItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListItemsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ItemDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
  
    ViewData["Title"] = "Item List";

#line default
#line hidden
            BeginContext(72, 2476, true);
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
            WriteLiteral(@"         <button id=""btnSave"" data-dismiss=""modal"" onclick=""ValidateDelete()"" type=""button"" class=""btn btn-outline-danger"" style=""width:auto;""><i class=""fa fa-trash""></i> Delete </button>
            </div>
        </div>
    </div>
</div>
<!----------------------Inform Dialog -->
<div class=""modal fade"" id=""dlgInform"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h5 class=""modal-title"" id=""exampleModalLabel"">Delete</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <span id=""ErrorMessage"" class=""card-text"">Are you sure you want to delete?</span>
                <input id=""txtDeleteItemID"" type=""text"" hidden p");
            WriteLiteral(@"laceholder=""text"" />
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"" style=""width:auto;""><i class=""fa fa-times""></i> close </button>
            </div>
        </div>
    </div>
</div>

<div class=""card-header"">
    <div class=""flex-container text-center"">
        <span class=""col-11""><h5>Items List</h5></span>
");
            EndContext();
#line 54 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
         if (Model.userPermission.CanAdd) { 

#line default
#line hidden
            BeginContext(2594, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2606, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6b7b0da34075eb9384aac83c7fd8194a9aaba49120", async() => {
                BeginContext(2717, 33, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2754, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
        }

#line default
#line hidden
            BeginContext(2767, 550, true);
            WriteLiteral(@"    </div>
</div>
<div class=""card"">


    <div style=""border:solid 1px black; padding:3px;"">
        <table class=""table table-hover gridtable"" id=""myTable"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Main Item</th>
                    <th>Item Unit</th>
                    <th>Currency</th>
                    <th>Price</th>
                    <th>Other Information</th>
                    <th style=""width:30px;""></th>
");
            EndContext();
#line 74 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                     if (Model.userPermission.CanDelete) { 

#line default
#line hidden
            BeginContext(3378, 55, true);
            WriteLiteral("                        <th style=\"width:30px;\"></th>\r\n");
            EndContext();
#line 76 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                    }

#line default
#line hidden
            BeginContext(3456, 45, true);
            WriteLiteral("                </tr>\r\n            </thead>\r\n");
            EndContext();
#line 79 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
            BeginContext(3564, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(3611, 7, false);
#line 82 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3618, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3650, 13, false);
#line 83 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(3663, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3695, 17, false);
#line 84 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.MainItemName);

#line default
#line hidden
            EndContext();
            BeginContext(3712, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3744, 17, false);
#line 85 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.ItemUnitName);

#line default
#line hidden
            EndContext();
            BeginContext(3761, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3793, 17, false);
#line 86 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(3810, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3842, 14, false);
#line 87 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3856, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3888, 21, false);
#line 88 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                   Write(item.OtherInformation);

#line default
#line hidden
            EndContext();
            BeginContext(3909, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3940, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6b7b0da34075eb9384aac83c7fd8194a9aaba415438", async() => {
                BeginContext(4091, 25, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4120, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 90 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                     if (Model.userPermission.CanDelete) { 

#line default
#line hidden
            BeginContext(4188, 141, true);
            WriteLiteral("                        <td>\r\n                            <a href=\"#\" class=\"btn btn-outline-danger rounded-circle btn-sm\" style=\"width:auto\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 4329, "\"", 4398, 3);
            WriteAttributeValue("", 4371, "contDelete(\'", 4371, 12, true);
#line 93 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
WriteAttributeValue("", 4383, item.Id, 4383, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4391, "\',true)", 4391, 7, true);
            EndWriteAttribute();
            BeginContext(4399, 65, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                        </td>\r\n");
            EndContext();
#line 95 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
                    }

#line default
#line hidden
            BeginContext(4487, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 97 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListItems.cshtml"
            }

#line default
#line hidden
            BeginContext(4525, 38, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4580, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4586, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6b7b0da34075eb9384aac83c7fd8194a9aaba420154", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4630, 1422, true);
                WriteLiteral(@"
    <script>
        $(window).ready(function () {
            $('#mnuTMS').removeClass('collapse show');
            $('#mnuSettings').addClass('collapse show');
            $('#mnuTMS').addClass('collapse hide');
        });
        //---------------Confirm Item Delete
        function contDelete(ItemId) {
            $('#txtDeleteItemID').val(ItemId);
            $('#dlgConfirmDelete').modal('show');
        };

        //-------------- Delete Item Button
        function DeleteItem() {
            $.post('/Settings/DeleteItem',
                {
                    Id: $('#txtDeleteItemID').val()
                },
                function (response, status) {
                    location.reload(true);

                }
            );
        };


        //-------------- Validate Delete
        function ValidateDelete() {
            $.post('/Settings/ValidateDeleteItem',
                {
                    Id: $('#txtDeleteItemID').val()
                },
          ");
                WriteLiteral(@"      function (response, status) {
                    if (response == """") {
                        DeleteItem();
                    } else {
                        $('#ErrorMessage').text(response);
                        $('#dlgInform').modal('show');
                    }
                    //location.reload(true);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListItemsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
