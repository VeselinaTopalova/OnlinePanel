#pragma checksum "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19679423f9f68cad896dd88000a1d44c77426780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_SelectPersonEditorViewModel), @"mvc.1.0.view", @"/Views/Users/SelectPersonEditorViewModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19679423f9f68cad896dd88000a1d44c77426780", @"/Views/Users/SelectPersonEditorViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb8cd6458f0e484dc345187abff30ec0a64a05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_SelectPersonEditorViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SayOnlinePanel.Web.ViewModels.Users.SelectAnswerEditorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<tr>\n    <td style=\"text-align:center\">\n        ");
#nullable restore
#line 4 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml"
   Write(Html.CheckBoxFor(model => model.Selected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 7 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 10 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n\n    <td>\n        ");
#nullable restore
#line 14 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 15 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml"
   Write(Html.ActionLink("Details", "Details", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 16 "C:\Users\Acer\Desktop\MyProjectNew\Web\SayOnlinePanel.Web\Views\Users\SelectPersonEditorViewModel.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SayOnlinePanel.Web.ViewModels.Users.SelectAnswerEditorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
