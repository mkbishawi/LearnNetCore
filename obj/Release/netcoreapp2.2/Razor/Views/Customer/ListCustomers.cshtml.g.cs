#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa2d4f0051f2ef91ae54907dbfb1e2e2645adde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ListCustomers), @"mvc.1.0.view", @"/Views/Customer/ListCustomers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/ListCustomers.cshtml", typeof(AspNetCore.Views_Customer_ListCustomers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa2d4f0051f2ef91ae54907dbfb1e2e2645adde", @"/Views/Customer/ListCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ListCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListCustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
  
    ViewData["Title"] = "ListCustomers";

#line default
#line hidden
            BeginContext(79, 2525, true);
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

<div class=""card"">
    <div class=""card-header"">
        <div class=""flex-container text-center"">
            <span class=""col-11""><h5> Customers List</h5></span>
            ");
            EndContext();
            BeginContext(2604, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa2d4f0051f2ef91ae54907dbfb1e2e2645adde8905", async() => {
                BeginContext(2711, 33, true);
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
            BeginContext(2748, 451, true);
            WriteLiteral(@"
        </div>
    </div>

    <div style=""border:solid 1px black; padding:3px;"">
        <table class=""table table-hover gridtable"" id=""myTable"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Code</th>
                    <th>Name</th>
                    <th>Addresss</th>
                    <th>MobileNo</th>
                    <th>Email</th>
                    <th style=""width:30px;""></th>
");
            EndContext();
#line 69 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                     if (Model.userPermission.CanDelete)
                    {

#line default
#line hidden
            BeginContext(3280, 55, true);
            WriteLiteral("                        <th style=\"width:30px;\"></th>\r\n");
            EndContext();
#line 72 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                    }

#line default
#line hidden
            BeginContext(3358, 47, true);
            WriteLiteral("\r\n                </tr>\r\n            </thead>\r\n");
            EndContext();
#line 76 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
             foreach (var customer in Model.Customers)
            {

#line default
#line hidden
            BeginContext(3476, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(3523, 21, false);
#line 79 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                   Write(customer.CustomerCode);

#line default
#line hidden
            EndContext();
            BeginContext(3544, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3576, 21, false);
#line 80 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                   Write(customer.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(3597, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3629, 16, false);
#line 81 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                   Write(customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3645, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3677, 17, false);
#line 82 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                   Write(customer.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(3694, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3726, 14, false);
#line 83 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                   Write(customer.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3740, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3771, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa2d4f0051f2ef91ae54907dbfb1e2e2645adde14173", async() => {
                BeginContext(3922, 25, true);
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
#line 84 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                                                                                                                                  WriteLiteral(customer.Id);

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
            BeginContext(3951, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 85 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                     if (Model.userPermission.CanDelete) { 

#line default
#line hidden
            BeginContext(4019, 141, true);
            WriteLiteral("                        <td>\r\n                            <a href=\"#\" class=\"btn btn-outline-danger rounded-circle btn-sm\" style=\"width:auto\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 4160, "\"", 4233, 3);
            WriteAttributeValue("", 4202, "contDelete(\'", 4202, 12, true);
#line 88 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
WriteAttributeValue("", 4214, customer.Id, 4214, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4226, "\',true)", 4226, 7, true);
            EndWriteAttribute();
            BeginContext(4234, 65, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                        </td>\r\n");
            EndContext();
#line 90 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
                    }

#line default
#line hidden
            BeginContext(4322, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 92 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Customer\ListCustomers.cshtml"
            }

#line default
#line hidden
            BeginContext(4360, 38, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4415, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4421, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa2d4f0051f2ef91ae54907dbfb1e2e2645adde18914", async() => {
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
                BeginContext(4465, 1416, true);
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
            $.post('/Customer/Delete',
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
            $.post('/Customer/ValidateDelete',
                {
                    Id: $('#txtDeleteItemID').val()
                },
                ");
                WriteLiteral(@"function (response, status) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListCustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
