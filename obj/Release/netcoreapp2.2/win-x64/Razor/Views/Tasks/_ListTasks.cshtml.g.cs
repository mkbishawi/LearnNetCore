#pragma checksum "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fb0dcef03d7236f57fda3adf40617256ecb689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks__ListTasks), @"mvc.1.0.view", @"/Views/Tasks/_ListTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tasks/_ListTasks.cshtml", typeof(AspNetCore.Views_Tasks__ListTasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62fb0dcef03d7236f57fda3adf40617256ecb689", @"/Views/Tasks/_ListTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7151bfa4a517a41b78302f3d3fd56968e597610", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks__ListTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MSIS.ViewModels.TaskDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm rounded-circle "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tasks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 518, true);
            WriteLiteral(@"<div style="" border:solid 1px black; padding:3px;"">
    <table class=""table table-hover"" id=""myTable"">

        <thead class=""thead-dark"">
            <tr>
                <th>Task Date</th>
                <th>Task Subject</th>
                <th>Task Owner</th>
                <th>Responsible for Task</th>
                <th style=""width:100px;"">Task Status</th>
                <th style=""width:30px;""></th>
                <th style=""width:30px;""></th>

            </tr>
        </thead>



");
            EndContext();
#line 20 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
           string strProjectName = ""; 

#line default
#line hidden
            BeginContext(611, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 21 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
         foreach (var task in Model)
        {
            

#line default
#line hidden
#line 23 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
             if (task.strGroupBy == "ProjectName")
            {
                

#line default
#line hidden
#line 25 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 if (strProjectName != task.ProjectName)
                {
                    strProjectName = task.ProjectName;

#line default
#line hidden
            BeginContext(860, 100, true);
            WriteLiteral("                    <tr>\r\n                        <th colspan=\"7\">\r\n                            <h1>");
            EndContext();
            BeginContext(961, 16, false);
#line 30 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                           Write(task.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(977, 65, true);
            WriteLiteral("</h1>\r\n                        </th>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }

#line default
#line hidden
#line 33 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 
            }
            else if (task.strGroupBy == "TaskOwnerName")
            {
                

#line default
#line hidden
#line 37 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 if (strProjectName != task.TaskOwnerName)
                {
                    strProjectName = task.TaskOwnerName;

#line default
#line hidden
            BeginContext(1286, 121, true);
            WriteLiteral("                    <tr>\r\n                        <th colspan=\"7\">\r\n                            <h3 class=\"text-center\"> ");
            EndContext();
            BeginContext(1408, 18, false);
#line 42 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                Write(task.TaskOwnerName);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 67, true);
            WriteLiteral("</h3>\r\n                        </th>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 46 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }

#line default
#line hidden
#line 46 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 
            }

            else if (task.strGroupBy == "TaskResponsibleName")
            {
                

#line default
#line hidden
#line 51 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 if (strProjectName != task.TaskResponsibleName)
                {
                    strProjectName = task.TaskResponsibleName;

#line default
#line hidden
            BeginContext(1757, 101, true);
            WriteLiteral("                    <tr>\r\n                        <th colspan=\"7\">\r\n                            <h3> ");
            EndContext();
            BeginContext(1859, 24, false);
#line 56 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                            Write(task.TaskResponsibleName);

#line default
#line hidden
            EndContext();
            BeginContext(1883, 67, true);
            WriteLiteral("</h3>\r\n                        </th>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 60 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }

#line default
#line hidden
#line 60 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 
            }

            else
            {
                if (task.strGroupBy == "TaskStatusCode")
                {
                    

#line default
#line hidden
#line 67 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                     if (strProjectName != task.TaskStatusCode)
                    {
                        strProjectName = task.TaskStatusCode;

#line default
#line hidden
            BeginContext(2247, 113, true);
            WriteLiteral("                        <tr>\r\n                            <th colspan=\"7\">\r\n                                <h3> ");
            EndContext();
            BeginContext(2361, 19, false);
#line 72 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                Write(task.TaskStatusCode);

#line default
#line hidden
            EndContext();
            BeginContext(2380, 75, true);
            WriteLiteral("</h3>\r\n                            </th>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 76 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                    }

#line default
#line hidden
#line 76 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                     
                }
            }

#line default
#line hidden
            BeginContext(2514, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(2553, 18, false);
#line 81 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
               Write(task.TaskStartDate);

#line default
#line hidden
            EndContext();
            BeginContext(2571, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2599, 16, false);
#line 82 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
               Write(task.TaskSubject);

#line default
#line hidden
            EndContext();
            BeginContext(2615, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2643, 18, false);
#line 83 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
               Write(task.TaskOwnerName);

#line default
#line hidden
            EndContext();
            BeginContext(2661, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2689, 24, false);
#line 84 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
               Write(task.TaskResponsibleName);

#line default
#line hidden
            EndContext();
            BeginContext(2713, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 85 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                 if (task.TaskStatusId == 1)
                {

#line default
#line hidden
            BeginContext(2785, 57, true);
            WriteLiteral("                    <td class=\"bg-secondary text-center\">");
            EndContext();
            BeginContext(2843, 15, false);
#line 87 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                    Write(task.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(2858, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 88 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }
                else if (task.TaskStatusId == 2)
                {

#line default
#line hidden
            BeginContext(2954, 55, true);
            WriteLiteral("                    <td class=\"bg-primary text-center\">");
            EndContext();
            BeginContext(3010, 15, false);
#line 91 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                  Write(task.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(3025, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 92 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }
                else if (task.TaskStatusId == 3)
                {

#line default
#line hidden
            BeginContext(3121, 54, true);
            WriteLiteral("                    <td class=\"bg-danger text-center\">");
            EndContext();
            BeginContext(3176, 15, false);
#line 95 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                 Write(task.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(3191, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 96 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }
                else if (task.TaskStatusId == 4)
                {

#line default
#line hidden
            BeginContext(3287, 55, true);
            WriteLiteral("                    <td class=\"bg-warning text-center\">");
            EndContext();
            BeginContext(3343, 15, false);
#line 99 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                  Write(task.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(3358, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 100 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }
                else if (task.TaskStatusId == 5)
                {

#line default
#line hidden
            BeginContext(3454, 58, true);
            WriteLiteral("                    <td class=\"badge-success text-center\">");
            EndContext();
            BeginContext(3513, 15, false);
#line 103 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                     Write(task.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(3528, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 104 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3596, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(3621, 15, false);
#line 107 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                   Write(task.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(3636, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 108 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"

                }

#line default
#line hidden
            BeginContext(3665, 22, true);
            WriteLiteral("\r\n                <td>");
            EndContext();
            BeginContext(3687, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62fb0dcef03d7236f57fda3adf40617256ecb68918783", async() => {
                BeginContext(3824, 33, true);
                WriteLiteral("<i class=\"fa fa-info-circle\"></i>");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 111 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                                                                                                       WriteLiteral(task.Id);

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
            BeginContext(3861, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3910, 906, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62fb0dcef03d7236f57fda3adf40617256ecb68921675", async() => {
                BeginContext(3982, 31, true);
                WriteLiteral("\r\n                        <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4013, "\"", 4044, 2);
                WriteAttributeValue("", 4018, "confirmDeleteSpan_", 4018, 18, true);
#line 114 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
WriteAttributeValue("", 4036, task.Id, 4036, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4045, 283, true);
                WriteLiteral(@" style=""display:none"">
                            <span>Are you sure you want to delete?</span>
                            <button type=""submit"" class=""btn btn-danger""><i class=""fa fa-check-circle""></i>Yes</button>
                            <a href=""#"" class=""btn btn-primary""");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 4328, "\"", 4401, 3);
                WriteAttributeValue("", 4370, "confirmDelete(\'", 4370, 15, true);
#line 118 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
WriteAttributeValue("", 4385, task.Id, 4385, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 4393, "\',false)", 4393, 8, true);
                EndWriteAttribute();
                BeginContext(4402, 106, true);
                WriteLiteral("><i class=\"fa fa-times-circle\"></i> No</a>\r\n                        </span>\r\n                        <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4508, "\"", 4532, 2);
                WriteAttributeValue("", 4513, "deleteSpan_", 4513, 11, true);
#line 120 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
WriteAttributeValue("", 4524, task.Id, 4524, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4533, 106, true);
                WriteLiteral(">\r\n                            <a href=\"#\" class=\"btn btn-danger rounded-circle btn-sm\" style=\"width:auto\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 4639, "\"", 4711, 3);
                WriteAttributeValue("", 4681, "confirmDelete(\'", 4681, 15, true);
#line 122 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
WriteAttributeValue("", 4696, task.Id, 4696, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 4704, "\',true)", 4704, 7, true);
                EndWriteAttribute();
                BeginContext(4712, 97, true);
                WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                        </span>\r\n\r\n\r\n\r\n\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"
                                                        WriteLiteral(task.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4816, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 132 "E:\Home Programs\Web\MultiSolution\MultiSolution\MultiSolution\Views\Tasks\_ListTasks.cshtml"

        }

#line default
#line hidden
            BeginContext(4873, 28, true);
            WriteLiteral("\r\n\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MSIS.ViewModels.TaskDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
