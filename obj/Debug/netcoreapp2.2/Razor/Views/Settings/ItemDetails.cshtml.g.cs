#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92868a1f67dffca7abebe83ecdc61f1c7ad94c0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_ItemDetails), @"mvc.1.0.view", @"/Views/Settings/ItemDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/ItemDetails.cshtml", typeof(AspNetCore.Views_Settings_ItemDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92868a1f67dffca7abebe83ecdc61f1c7ad94c0b", @"/Views/Settings/ItemDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_ItemDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemsDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
  
    ViewBag.Title = "Details";
    var PhotoPath = "~/images/" + (Model.ItemDetails.PhotoPath ?? "noImage.png");

#line default
#line hidden
            BeginContext(152, 182, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mt-3\">\r\n    <div class=\"card-header text-center\">\r\n        <h4 class=\"card-title\"> Item Details</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <center>");
            EndContext();
            BeginContext(334, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92868a1f67dffca7abebe83ecdc61f1c7ad94c0b6753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 14 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                    WriteLiteral(PhotoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(440, 237, true);
            WriteLiteral("</center>\r\n        <div class=\"input-group col-sm-12 mt-1 row\">\r\n            <span class=\"input-group-text col-sm-2 \" id=\"Id-addon\">Id</span>\r\n            <span class=\"form-control col-sm-8\" placeholder=\"Id\" aria-describedby=\"Id-addon\"> ");
            EndContext();
            BeginContext(678, 20, false);
#line 17 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                         Write(Model.ItemDetails.Id);

#line default
#line hidden
            EndContext();
            BeginContext(698, 281, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""ItemName-addon"">Item Name</span>
            <textarea class=""form-control col-sm-8"" placeholder=""Item Name"" aria-describedby=""ItemName-addon""> ");
            EndContext();
            BeginContext(980, 26, false);
#line 21 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                                          Write(Model.ItemDetails.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 289, true);
            WriteLiteral(@"</textarea>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""MainItemName-addon"">Main Item</span>
            <span class=""form-control col-sm-8"" placeholder=""Main Item"" aria-describedby=""MainItemName-addon""> ");
            EndContext();
            BeginContext(1296, 30, false);
#line 25 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                                          Write(Model.ItemDetails.MainItemName);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 285, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""ItemUnitName-addon"">Item Unit</span>
            <span class=""form-control col-sm-8"" placeholder=""Item Unit"" aria-describedby=""ItemUnitName-addon""> ");
            EndContext();
            BeginContext(1612, 30, false);
#line 29 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                                          Write(Model.ItemDetails.ItemUnitName);

#line default
#line hidden
            EndContext();
            BeginContext(1642, 281, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""UnitPrice-addon"">Unit Price</span>
            <span class=""form-control col-sm-8"" placeholder=""Unit Price"" aria-describedby=""UnitPrice-addon""> ");
            EndContext();
            BeginContext(1924, 27, false);
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                                        Write(Model.ItemDetails.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1951, 283, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""CurrencyName-addon"">Currency</span>
            <span class=""form-control col-sm-8"" placeholder=""Currency"" aria-describedby=""CurrencyName-addon""> ");
            EndContext();
            BeginContext(2235, 30, false);
#line 37 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                                         Write(Model.ItemDetails.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(2265, 309, true);
            WriteLiteral(@"</span>
        </div>
        <div class=""input-group col-sm-12 mt-1 row"">
            <span class=""input-group-text col-sm-2 "" id=""OtherInformation-addon"">Other Information</span>
            <span class=""form-control col-sm-8"" placeholder=""Other Information"" aria-describedby=""OtherInformation-addon""> ");
            EndContext();
            BeginContext(2575, 34, false);
#line 41 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                                                                      Write(Model.ItemDetails.OtherInformation);

#line default
#line hidden
            EndContext();
            BeginContext(2609, 94, true);
            WriteLiteral("</span>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n    <div class=\"card-footer text-center\">\r\n        ");
            EndContext();
            BeginContext(2703, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92868a1f67dffca7abebe83ecdc61f1c7ad94c0b14411", async() => {
                BeginContext(2811, 35, true);
                WriteLiteral("<i class=\"fa fa-backward\"></i> Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2850, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
         if (Model.Permission.CanEdit) { 

#line default
#line hidden
            BeginContext(2895, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2907, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92868a1f67dffca7abebe83ecdc61f1c7ad94c0b16485", async() => {
                BeginContext(3047, 31, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
                                                                 WriteLiteral(Model.ItemDetails.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3082, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ItemDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(3095, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3134, 270, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemsDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
