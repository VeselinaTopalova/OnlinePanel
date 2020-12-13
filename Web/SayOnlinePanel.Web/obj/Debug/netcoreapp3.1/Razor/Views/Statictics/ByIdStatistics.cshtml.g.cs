#pragma checksum "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03542d43d51587b932007e8dcc2a446314f363c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statictics_ByIdStatistics), @"mvc.1.0.view", @"/Views/Statictics/ByIdStatistics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03542d43d51587b932007e8dcc2a446314f363c9", @"/Views/Statictics/ByIdStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb8cd6458f0e484dc345187abff30ec0a64a05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Statictics_ByIdStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayOnlinePanel.Web.ViewModels.Statictics.SingleSurveyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        //let btnC = document.querySelector(""#addC"");
        //btnC.addEventListener(""click"", AddChart);

        function AddQuestionChart(container, name, answersNames, answersCount) {
            const chart = Highcharts.chart(container, {
                chart: {
                    type: 'bar'
                },
                title: {
                    text: name
                },
                xAxis: {
                    categories: answersNames
                },
                yAxis: {
                    title: {
                        text: 'Complete'
                    }
                },
                series: [{
                    name: 'Completed %',
                    data: answersCount
                }
                ]
            });

        }


    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n");
#nullable restore
#line 51 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
 foreach (var question in Model.Questions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 1413, "\"", 1440, 2);
            WriteAttributeValue("", 1418, "container-", 1418, 10, true);
#nullable restore
#line 53 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
WriteAttributeValue("", 1428, question.Id, 1428, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%; height:400px;\"></div>\r\n");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
    var answersNames = new List<string>(); // new string[question.Answers.Count()];
    var answersCount = new List<int>(); // new int[question.Answers.Count()];


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
     foreach (var answer in question.Answers)
    {
        answersNames.Add(answer.Name.ToString());
        answersCount.Add(answer.Count);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    document.addEventListener(\'DOMContentLoaded\',\r\n        function () {\r\n            let a = \"");
#nullable restore
#line 66 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
                Write(question.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n             let b = ");
#nullable restore
#line 67 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
                Write(Html.Raw(Json.Serialize(answersNames)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            let c = ");
#nullable restore
#line 68 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
               Write(Html.Raw(Json.Serialize(answersCount)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            let container = \"container-");
#nullable restore
#line 69 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
                                  Write(question.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            AddQuestionChart(container, a, b, c);\r\n        }\r\n    );\r\n        ");
#nullable restore
#line 73 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\ByIdStatistics.cshtml"
               
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayOnlinePanel.Web.ViewModels.Statictics.SingleSurveyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
