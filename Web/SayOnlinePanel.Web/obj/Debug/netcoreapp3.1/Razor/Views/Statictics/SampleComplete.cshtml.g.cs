#pragma checksum "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5f57ce24f8bf7cd10d4c306df08c7a27584737f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statictics_SampleComplete), @"mvc.1.0.view", @"/Views/Statictics/SampleComplete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f57ce24f8bf7cd10d4c306df08c7a27584737f", @"/Views/Statictics/SampleComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb8cd6458f0e484dc345187abff30ec0a64a05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Statictics_SampleComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayOnlinePanel.Web.ViewModels.Statictics.CompleteModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
 if (Model != null)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h6>Survey Name: ");
#nullable restore
#line 8 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p>Total Sample Completed: ");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                              Write(Math.Round(Model.SampleTotalCompletePercent, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n        <p>Male Sample Completed: ");
#nullable restore
#line 10 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                             Write(Math.Round(Model.SampleMaleCompletePercent, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n        <p>Female Sample Completed: ");
#nullable restore
#line 11 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                               Write(Math.Round(Model.SampleFemaleCompletePercent, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n\r\n    </div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
        function AddChart(a, b, c) {
            const chart = Highcharts.chart('container', {
                chart: {
                    type: 'bar'
                },
                title: {
                    text: 'Completed Sample'
                },
                xAxis: {
                    categories: ['Completed All Sample', 'Completed Male Sample', 'Completed Female Sample']
                },
                yAxis: {
                    title: {
                        text: 'Complete'
                    }
                },
                series: [{
                    name: '% Completed',
                    data: [a, b, c]
                }
                ]
            });

    }
    document.addEventListener('DOMContentLoaded',
        function () {
             let a = ");
#nullable restore
#line 43 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                Write(Model.SampleTotalCompletePercent);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n             let b = ");
#nullable restore
#line 44 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                Write(Model.SampleMaleCompletePercent);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n             let c = ");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
                Write(Model.SampleFemaleCompletePercent);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            AddChart(a, b, c);\r\n        }\r\n    );\r\n        </script>\r\n\r\n        <div id=\"container\" style=\"width:100%; height:400px;\"></div>\r\n    ");
            }
            );
#nullable restore
#line 52 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>Анкетата все още не е попълнена от никой!</h5>\r\n");
#nullable restore
#line 57 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Statictics\SampleComplete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayOnlinePanel.Web.ViewModels.Statictics.CompleteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
