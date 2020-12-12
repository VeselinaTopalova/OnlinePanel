#pragma checksum "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91dc43e12dc967697ef01abfe595bf2a4adccb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TargetSurveys_SelectedAnswers), @"mvc.1.0.view", @"/Views/TargetSurveys/SelectedAnswers.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
using SayOnlinePanel.Web.ViewModels.TargetSurveys;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91dc43e12dc967697ef01abfe595bf2a4adccb4", @"/Views/TargetSurveys/SelectedAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb8cd6458f0e484dc345187abff30ec0a64a05e", @"/Views/_ViewImports.cshtml")]
    public class Views_TargetSurveys_SelectedAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayOnlinePanel.Web.ViewModels.TargetSurveys.PeopleSelectionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
   ViewBag.Title = Model.TargetSurvey.Name; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 5 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
                            
    int index = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
     foreach (QuestionsViewModel question in Model.TargetSurvey.TargetQuestions)
    {
        int answerIndex = 0;
        int answersCount = question.TargetAnswers.ToArray().Length;
        int width = 100 / answersCount;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
       Write(question.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
                       Write(question.TargetQuestionType);

#line default
#line hidden
#nullable disable
            WriteLiteral(") (check all target answer)\r\n        </div>\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 672, "\"", 713, 3);
            WriteAttributeValue("", 679, "model.AnsweredQuestions[", 679, 24, true);
#nullable restore
#line 20 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
WriteAttributeValue("", 703, index, 703, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 709, "].Id", 709, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 714, "", 733, 1);
#nullable restore
#line 20 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
WriteAttributeValue("", 721, question.Id, 721, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 22 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
         foreach (var answer in question.TargetAnswers)
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-check\">\r\n                    <label class=\"form-check-label\">\r\n                        <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 985, "\"", 1043, 3);
            WriteAttributeValue("", 992, "model.AnsweredQuestions[", 992, 24, true);
#nullable restore
#line 26 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
WriteAttributeValue("", 1016, index, 1016, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1022, "].SelectedAnswerIds[]", 1022, 21, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1044, "", 1061, 1);
#nullable restore
#line 26 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
WriteAttributeValue("", 1051, answer.Id, 1051, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 27 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
                   Write(answer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"

            answerIndex++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n");
#nullable restore
#line 34 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"

        
        index++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <input type=\"submit\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\TargetSurveys\SelectedAnswers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>&nbsp;</p>\r\n<p>&nbsp;</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayOnlinePanel.Web.ViewModels.TargetSurveys.PeopleSelectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591