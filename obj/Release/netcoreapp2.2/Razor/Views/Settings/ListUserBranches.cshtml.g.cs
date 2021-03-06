#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae6f65c1b494cb0b45b01b01d7377123a32e336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_ListUserBranches), @"mvc.1.0.view", @"/Views/Settings/ListUserBranches.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/ListUserBranches.cshtml", typeof(AspNetCore.Views_Settings_ListUserBranches))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae6f65c1b494cb0b45b01b01d7377123a32e336", @"/Views/Settings/ListUserBranches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_ListUserBranches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserBranchListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery.form/jquery.form.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
  
    ViewBag.Title = "List User Branches";

#line default
#line hidden
            BeginContext(84, 3564, true);
            WriteLiteral(@"<!----------------------Confirm Delete -->
<div class=""modal fade"" id=""dlgConfirmDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h5 class=""modal-title"" id=""exampleModalLabel"">User Branch</h5>
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
            WriteLiteral(@"               <button id=""btnSave"" data-dismiss=""modal"" onclick=""DeleteItem()"" type=""button"" class=""btn btn-outline-danger"" style=""width:auto;""><i class=""fa fa-trash""></i> Delete </button>
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
                <input id=""txtDeleteItemID"" type=""text"" hidden");
            WriteLiteral(@" placeholder=""text"" />
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"" style=""width:auto;""><i class=""fa fa-times""></i> close </button>
            </div>
        </div>
    </div>
</div>

<!-----------------------Modal        -->
<div class=""modal fade"" id=""basicExampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div>
                <input type=""text"" id=""txtEditMode"" value=""false"" />
            </div>
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">User Branch</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>

            </div>
            <div class=""");
            WriteLiteral(@"modal-body"">
                <div class=""input-group col-sm-12 row"">
                    <span class=""input-group-text col-sm-3 "" id=""txtItem-addon"">Id</span>
                    <input id=""txtId"" class=""form-control col-sm-9"" disabled placeholder=""Id"" aria-describedby=""txtId-addon"" />
                </div>

                <div class=""input-group col-sm-12 row"">
                    <span class=""input-group-text col-sm-3 "" id=""txtProject-addon"">Branch</span>
                    ");
            EndContext();
            BeginContext(3649, 137, false);
#line 75 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
               Write(Html.DropDownList("txtBranch", new SelectList(Model.Branches, "Id", "Name"), new { @id = "txtBranch", @class = "form-control col-sm-6" }));

#line default
#line hidden
            EndContext();
            BeginContext(3786, 400, true);
            WriteLiteral(@"

                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"" style=""width:auto;""><i class=""fa fa-times""></i> close</button>
                <button id=""btnSaveAjax"" type=""button"" class=""btn btn-outline-primary"" style=""width:auto;""><i class=""fa fa-save""></i> save</button>


");
            EndContext();
            BeginContext(4285, 171, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <div class=\"flex-container text-center\">\r\n            ");
            EndContext();
            BeginContext(4456, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ae6f65c1b494cb0b45b01b01d7377123a32e33610083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 94 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4489, 71, true);
            WriteLiteral("\r\n            <span class=\"col-11\"><h5>User Branches List</h5></span>\r\n");
            EndContext();
#line 96 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
             if (Model.userPermission.CanAdd)
            {

#line default
#line hidden
            BeginContext(4622, 187, true);
            WriteLiteral("                <div class=\"col-1 \"> <button id=\"btnAddBranch\" type=\"button\" class=\"btn btn-primary\" style=\"width:auto;text-align:left;\"><i class=\"fa fa-plus-circle\"></i></button></div>\r\n");
            EndContext();
#line 99 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                //<a asp-action="Create" asp-controller="Projects" class="btn btn-outline-secondary mt-2 mb-2" style="width:auto"><i class="fa fa-plus-circle"></i></a>
            }

#line default
#line hidden
            BeginContext(4993, 447, true);
            WriteLiteral(@"        </div>
    </div>
    <div style=""border:solid 1px black; padding:3px;"">
        <div id=""OrderItems"" class=""col-12"">
            <table class=""table gridtable table-hover"" id=""tblItemDetails"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Id</th>
                        <th>User Name</th>
                        <th>Employee Name</th>
                        <th>Branch</th>
");
            EndContext();
#line 112 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                         if (Model.userPermission.CanEdit)
                        {

#line default
#line hidden
            BeginContext(5527, 59, true);
            WriteLiteral("                            <th style=\"width:30px;\"></th>\r\n");
            EndContext();
#line 115 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                        }

#line default
#line hidden
            BeginContext(5613, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 116 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                         if (Model.userPermission.CanDelete)
                        {

#line default
#line hidden
            BeginContext(5702, 59, true);
            WriteLiteral("                            <th style=\"width:30px;\"></th>\r\n");
            EndContext();
#line 119 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                        }

#line default
#line hidden
            BeginContext(5788, 53, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n");
            EndContext();
#line 122 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                 if (Model.UserBranches!=null)
                {
                    

#line default
#line hidden
#line 124 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                     foreach (var branch in Model.UserBranches)
                    {

#line default
#line hidden
            BeginContext(5996, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(6059, 9, false);
#line 127 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                           Write(branch.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6068, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6108, 15, false);
#line 128 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                           Write(branch.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6123, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6163, 19, false);
#line 129 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                           Write(branch.EmployeeName);

#line default
#line hidden
            EndContext();
            BeginContext(6182, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(6222, 17, false);
#line 130 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                           Write(branch.BranchName);

#line default
#line hidden
            EndContext();
            BeginContext(6239, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 131 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                             if (Model.userPermission.CanEdit)
                            {

#line default
#line hidden
            BeginContext(6341, 166, true);
            WriteLiteral("                                <td>\r\n                                    <button type=\'button\' id=\'btnEditItem\' class=\'btn btn-outline-primary btn-sm rounded-circle\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=", 6507, "", 6536, 3);
            WriteAttributeValue("", 6516, "EditItem(", 6516, 9, true);
#line 134 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
WriteAttributeValue("", 6525, branch.Id, 6525, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 6535, ")", 6535, 1, true);
            EndWriteAttribute();
            BeginContext(6536, 96, true);
            WriteLiteral(" style=\'width:auto\'><i class=\'fa fa-edit\'></i></button>\r\n                                </td>\r\n");
            EndContext();
#line 136 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                            }

#line default
#line hidden
            BeginContext(6663, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 137 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                             if (Model.userPermission.CanDelete)
                            {

#line default
#line hidden
            BeginContext(6760, 157, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\" class=\"btn btn-outline-danger rounded-circle btn-sm\" style=\"width:auto\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                                       onclick=\"", 6917, "\"", 6989, 3);
            WriteAttributeValue("", 6967, "contDelete(", 6967, 11, true);
#line 141 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
WriteAttributeValue("", 6978, branch.Id, 6978, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 6988, ")", 6988, 1, true);
            EndWriteAttribute();
            BeginContext(6990, 73, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                                </td>\r\n");
            EndContext();
#line 143 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                            }

#line default
#line hidden
            BeginContext(7094, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 145 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                    }

#line default
#line hidden
#line 145 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#line 149 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Settings\ListUserBranches.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(7299, 62, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7378, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7384, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae6f65c1b494cb0b45b01b01d7377123a32e33621085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7439, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7445, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae6f65c1b494cb0b45b01b01d7377123a32e33622341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7505, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7511, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae6f65c1b494cb0b45b01b01d7377123a32e33623597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7555, 7038, true);
                WriteLiteral(@"
    <script>
        //---------------- Ready
        $(document).ready(function () {
            // -------------  General
            $('.chosen').chosen();
            $('#txtEditMode').val('true');
            $('#txtEditMode').hide();

            var table = $('#tblItemDetails').DataTable({
                columnDefs: [
                    { ""name"": ""ItemUnitId"", ""targets"": 2, visible: false }
                ]
            });

            //------------- Add Project
            $('#btnAddBranch').on('click', function () {
                $('#txtEditMode').val('false');
                $('#txtBranch').val('');
                $('#basicExampleModal').modal('show')
            });

            function ClearItems() {
                $('#txtEditMode').val('false');
                $('#txtBranch').val('');
                $('#basicExampleModal').modal('show')
            };
            $('#btnSaveAjax').click(function () {
                if (validateItem()) {
                 ");
                WriteLiteral(@"   if ($('#txtEditMode').val() == 'true') {
                        $.post('/Settings/EditUserBranch',
                            {
                                Id: $('#txtId').val(),
                                BranchId: $('#txtBranch').val()
                            },
                            function (response, status) {
                                $('#OrderItems').html('');
                                BuildItemsTable(response);
                            }
                        );
                    } else {
                        $.post('/Settings/AddUserBranch',
                            {
                                UserId: $('#UserId').val(),
                                BranchId: $('#txtBranch').val()
                            },
                            function (response, status) {
                                $('#OrderItems').html('');
                                BuildItemsTable(response);
                                ClearIte");
                WriteLiteral(@"ms();
                            }
                        );
                    }
                }
            }
            );


        });

        $(window).ready(function () {
            $('#mnuTMS').removeClass('collapse show');
            $('#mnuSettings').addClass('collapse show');
            $('#mnuTMS').addClass('collapse hide');
        });
        //----------------- Render Table
        function BuildItemsTable(response) {
            var i;
            var TotalPrice=0
            var strResult = """";
            strResult = '<table id=""tblItemDetails"" class=""table table-hover"">';
            strResult = strResult + '<thead class=""thead-dark"">';
            strResult += ""<tr>"";
            strResult += ""<th>Id</th>"";
            strResult += ""<th>User Name</th>"";
            strResult += ""<th>Employee Name</th>"";
            strResult += ""<th>Branch</th>"";
            strResult += ""<th style='width:30px;'></th>"";
            strResult += ""<th style='width:30px;");
                WriteLiteral(@"'></th>"";

            strResult += ""</tr>"";

            strResult += ""</thead>"";
            strResult += ""<tbody>"";

            var text = """";
            for (i = 0; i < response.length; i++) {
                strResult += ""<tr>"";
                strResult += ""<td>"" + response[i].Id + ""</td>"";
                strResult += ""<td>"" + response[i].UserName + ""</td>"";
                strResult += ""<td>"" + response[i].EmployeeName + ""</td>"";
                strResult += ""<td>"" + response[i].BranchName + ""</td>"";
                strResult += ""<td>"";
                strResult += ""<button type='button' id='btnEditItem' class='btn btn-outline-primary btn-sm rounded-circle' onclick=EditItem("" + response[i].Id + "") style = 'width:auto' > <i class='fa fa-edit'></i></button > "";
                strResult +=""</td>""
                strResult +=""<td>""
                strResult += ""                <Button Type='Button' class='btn btn-outline-danger rounded-circle btn-sm' style='width:auto'"";
            ");
                WriteLiteral(@"    strResult += ""                    onclick=contDelete("" + response[i].Id + "")><i class='fa fa-trash'></i></a>"";
                strResult += ""</td>"";
                strResult += ""</tr>"";
            };
            strResult += ""</tbody>"";
            strResult += ""</table>"";
            $('#OrderItems').html(strResult);
            var table = $('#tblItemDetails').DataTable();
            return strResult;
        };
        //----------------- Edit order Items
        function EditItem(Id) {
            $.get('/Settings/GetUserBranch',
                { Id: Id },
                function (data, status) {
                    $('#txtEditMode').val('true');
                    $('#txtBranch').val(data.BranchId);
                    $('#txtId').val(data.Id);
                    $('#basicExampleModal').modal('show')
                }
            );
        };

        //----------------- validate Item
        function validateItem() {
            var isValid = true;
            //if ");
                WriteLiteral(@"($.isNumeric($('#txtPrice').val())) {
            //    if ($.isNumeric($('#txtQnt').val())) {
            //        if ($('#txtPrice').val() == 0 || $('#txtQnt').val() == 0) {
            //            isValid = false;
            //            alert('Price and Qnt must be more than 0');
            //        };
            //    } else {
            //            isValid = false;
            //            alert('Qnt must be Numeric Value');
            //    };

            //    } else {
            //            isValid = false;
            //            alert('Price must be Numeric Value');
            //    };

            return isValid;
        }
        //---------------Confirm Item Delete
        function contDelete(Id) {
            $('#txtDeleteItemID').val(Id);
            $('#dlgConfirmDelete').modal('show');
        };

        //-------------- Delete Item Button
        function DeleteItem() {
            $.post('/Settings/DeleteUserBranch',
                {
      ");
                WriteLiteral(@"              Id: $('#txtDeleteItemID').val()
                },
                function (response, status) {
                    location.reload(true);

                }
            );
        };


        //-------------- Validate Delete
        function ValidateDelete() {
            return true;
            //$.post('/Projects/ValidateDelete',
            //    {
            //        Id: $('#txtDeleteItemID').val()
            //    },
            //    function (response, status) {
            //        if (response == """") {
            //            DeleteItem();
            //        } else {
            //            $('#ErrorMessage').text(response);
            //            $('#dlgInform').modal('show');
            //        }
            //        //location.reload(true);

            //    }
            //);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserBranchListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
