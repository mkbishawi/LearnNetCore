#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d34fe359b6245438e5e071b94bb5b25a5647a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_Details), @"mvc.1.0.view", @"/Views/Suppliers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Suppliers/Details.cshtml", typeof(AspNetCore.Views_Suppliers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d34fe359b6245438e5e071b94bb5b25a5647a2", @"/Views/Suppliers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SupplierDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListSuppliers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Suppliers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(72, 396, true);
            WriteLiteral(@"


<div class=""card mt-3"">
    <div class=""card-header text-center"">
        <h4 class=""card-title""> Supplier Details</h4>
    </div>
    <div class=""card-body"">
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""Id-addon"">Id</span>
            <span class=""form-control col-sm-8"" placeholder=""Id"" aria-describedby=""Id-addon""> ");
            EndContext();
            BeginContext(469, 17, false);
#line 15 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                         Write(Model.Supplier.Id);

#line default
#line hidden
            EndContext();
            BeginContext(486, 294, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""SupplierName-addon"">Supplier Name</span>
            <span class=""form-control col-sm-10"" placeholder=""Supplier Name"" aria-describedby=""SupplierName-addon""> ");
            EndContext();
            BeginContext(781, 27, false);
#line 19 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                                               Write(Model.Supplier.SupplierName);

#line default
#line hidden
            EndContext();
            BeginContext(808, 271, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""Address-addon"">Address</span>
            <span class=""form-control col-sm-8"" placeholder=""Address"" aria-describedby=""Address-addon""> ");
            EndContext();
            BeginContext(1080, 22, false);
#line 23 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                                   Write(Model.Supplier.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 277, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""MobileNo-addon"">Mobile No</span>
            <span class=""form-control col-sm-8"" placeholder=""Mobile No"" aria-describedby=""MobileNo-addon""> ");
            EndContext();
            BeginContext(1380, 23, false);
#line 27 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                                      Write(Model.Supplier.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 269, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""Phone-addon"">Phone No</span>
            <span class=""form-control col-sm-8"" placeholder=""Phone No"" aria-describedby=""Phone-addon""> ");
            EndContext();
            BeginContext(1673, 20, false);
#line 31 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                                  Write(Model.Supplier.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 255, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"input-group col-sm-12 mt-1 row\">\r\n            <span class=\"input-group-text col-sm-2 \" id=\"Fax-addon\">Fax</span>\r\n            <span class=\"form-control col-sm-8\" placeholder=\"Fax\" aria-describedby=\"Fax-addon\"> ");
            EndContext();
            BeginContext(1949, 18, false);
#line 35 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                           Write(Model.Supplier.Fax);

#line default
#line hidden
            EndContext();
            BeginContext(1967, 265, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""Email-addon"">e-mail</span>
            <span class=""form-control col-sm-8"" placeholder=""e-mail"" aria-describedby=""Email-addon""> ");
            EndContext();
            BeginContext(2233, 20, false);
#line 39 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                                Write(Model.Supplier.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2253, 309, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""OtherInformation-addon"">Other Information</span>
            <span class=""form-control col-sm-8"" placeholder=""Other Information"" aria-describedby=""OtherInformation-addon""> ");
            EndContext();
            BeginContext(2563, 31, false);
#line 43 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                                                                                      Write(Model.Supplier.OtherInformation);

#line default
#line hidden
            EndContext();
            BeginContext(2594, 90, true);
            WriteLiteral("</span>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"card-footer text-center\">\r\n        ");
            EndContext();
            BeginContext(2684, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d34fe359b6245438e5e071b94bb5b25a5647a211690", async() => {
                BeginContext(2797, 35, true);
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
            BeginContext(2836, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
         if (Model.Permission.CanEdit) { 

#line default
#line hidden
            BeginContext(2881, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2893, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d34fe359b6245438e5e071b94bb5b25a5647a213761", async() => {
                BeginContext(3027, 31, true);
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
#line 50 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
                                                              WriteLiteral(Model.Supplier.Id);

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
            BeginContext(3062, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Suppliers\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(3075, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3116, 270, true);
                WriteLiteral(@"
    <script>
            $(window).ready(function () {
                $('#mnuTMS').removeClass('collapse show');
                $('#mnuSettings').addClass('collapse show');
                $('#mnuTMS').addClass('collapse hide');
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SupplierDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
