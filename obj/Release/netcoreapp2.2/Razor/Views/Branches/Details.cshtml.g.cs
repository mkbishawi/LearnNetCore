#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875e89a9d9d5a8bda101a5661e658cf96b760fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Details), @"mvc.1.0.view", @"/Views/Branches/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Branches/Details.cshtml", typeof(AspNetCore.Views_Branches_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"875e89a9d9d5a8bda101a5661e658cf96b760fc9", @"/Views/Branches/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BranchDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListBranches", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Branches", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 410, true);
            WriteLiteral(@"


<div class=""card mt-3"">
    <div class=""card-header text-center"">
        <h4 class=""card-title""> Branch Details</h4>
    </div>
    <div class=""card-body"">
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Code-addon"">Identity No</span>
            <span class=""form-control col-sm-8"" placeholder="" Code"" aria-describedby=""Code-addon""> ");
            EndContext();
            BeginContext(486, 17, false);
#line 15 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
                                                                                              Write(Model.Branch.Code);

#line default
#line hidden
            EndContext();
            BeginContext(503, 259, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Name-addon"">Name</span>
            <span class=""form-control col-sm-8"" placeholder=""Name"" aria-describedby=""Code-addon""> ");
            EndContext();
            BeginContext(763, 17, false);
#line 19 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
                                                                                             Write(Model.Branch.Name);

#line default
#line hidden
            EndContext();
            BeginContext(780, 271, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Address-addon"">Address</span>
            <span class=""form-control col-sm-8"" placeholder=""Address"" aria-describedby=""Address-addon""> ");
            EndContext();
            BeginContext(1052, 20, false);
#line 23 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
                                                                                                   Write(Model.Branch.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 268, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Address-addon"">Mobile</span>
            <span class=""form-control col-sm-8"" placeholder=""Mobile"" aria-describedby=""Mobile-addon""> ");
            EndContext();
            BeginContext(1341, 19, false);
#line 27 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
                                                                                                 Write(Model.Branch.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 263, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-4 "" id=""Phone-addon"">Phone</span>
            <span class=""form-control col-sm-8"" placeholder=""Phone"" aria-describedby=""Phone-addon""> ");
            EndContext();
            BeginContext(1624, 18, false);
#line 31 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
                                                                                               Write(Model.Branch.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1642, 90, true);
            WriteLiteral("</span>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"card-footer text-center\">\r\n        ");
            EndContext();
            BeginContext(1732, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "875e89a9d9d5a8bda101a5661e658cf96b760fc99393", async() => {
                BeginContext(1843, 35, true);
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
            BeginContext(1882, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
         if (Model.Permission.CanEdit) { 

#line default
#line hidden
            BeginContext(1927, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1939, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "875e89a9d9d5a8bda101a5661e658cf96b760fc911462", async() => {
                BeginContext(2070, 31, true);
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
#line 38 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
                                                             WriteLiteral(Model.Branch.Id);

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
            BeginContext(2105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Branches\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2118, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2155, 270, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BranchDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
