#pragma checksum "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47593d0949d1bc2b90936dc2849fbff702d51788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Surveys_ById), @"mvc.1.0.view", @"/Views/Surveys/ById.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\_ViewImports.cshtml"
using SayOnlinePanel.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\_ViewImports.cshtml"
using SayOnlinePanel.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47593d0949d1bc2b90936dc2849fbff702d51788", @"/Views/Surveys/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb8cd6458f0e484dc345187abff30ec0a64a05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Surveys_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayOnlinePanel.Web.ViewModels.Surveys.SingleSurveyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Surveys", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>");
#nullable restore
#line 2 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div>\r\n");
#nullable restore
#line 5 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
     foreach (var question in Model.Questions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label>");
#nullable restore
#line 7 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
          Write(question.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
         if (question.QuestionType.ToString() == "SingleAnswer")
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
             foreach (var answer in question.Answers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-check\">\r\n                    <label class=\"form-check-label\">\r\n                        <input type=\"radio\" class=\"form-check-input\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                   Write(answer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                </div>");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
         if (question.QuestionType.ToString() == "MultipleAnswer")
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
             foreach (var answer in question.Answers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-check\">\r\n                    <label class=\"form-check-label\">\r\n                        <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 919, "\"", 927, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                   Write(answer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                </div>");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
         if (question.QuestionType.ToString() == "LikertScales")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47593d0949d1bc2b90936dc2849fbff702d5178810154", async() => {
                WriteLiteral("\r\n                <div class=\"wrap\">\r\n                    <ul class=\'likert\'>\r\n");
#nullable restore
#line 34 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                         foreach (var answer in question.Answers)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <input type=\"radio\" name=\"likert\" value=\"strong_agree\">\r\n                                <label>");
#nullable restore
#line 38 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                                  Write(answer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            </li>\r\n");
#nullable restore
#line 40 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 43 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
         if (question.QuestionType.ToString() == "Dichotomous")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <select class=\"form-control\">\r\n");
#nullable restore
#line 48 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                     foreach (var answer in question.Answers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47593d0949d1bc2b90936dc2849fbff702d5178813441", async() => {
#nullable restore
#line 50 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                           Write(answer.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>");
#nullable restore
#line 53 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
         if (question.QuestionType.ToString() == "OpenEnded")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"exampleTextarea\"></label>\r\n                <textarea class=\"form-control\" rows=\"2\"></textarea>\r\n            </div>");
#nullable restore
#line 59 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
         if (question.QuestionType.ToString() == "Quantitative")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"exampleTextarea\"></label>\r\n                <input class=\"form-control\" type=\"number\" rows=\"1\">\r\n            </div>");
#nullable restore
#line 65 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />");
#nullable restore
#line 66 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47593d0949d1bc2b90936dc2849fbff702d5178816630", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47593d0949d1bc2b90936dc2849fbff702d5178819180", async() => {
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <button class=""btn btn-outline-danger"" data-toggle=""modal"" data-target=""#deleteModal"">Delete</button>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""deleteModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <p>Do you want to delete """);
#nullable restore
#line 80 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Surveys\ById.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""?</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" onclick=""deleteForm.submit()"">Yes</button>
                    <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">No</button>
                </div>
            </div>
        </div>
    </div>
</div>
<p>&nbsp;</p>
<p>&nbsp;</p>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayOnlinePanel.Web.ViewModels.Surveys.SingleSurveyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
