#pragma checksum "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f637afc0bed3e4030af9999f0666049110c029c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f637afc0bed3e4030af9999f0666049110c029c3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(144, 312, true);
            WriteLiteral(@"
<!-- dykstra3
create a view for the about page
-->
<h2>Student Body Statistics</h2>

<table>
    <tr>
        <th>
            Year Rank
        </th>
        <th>
            Students
        </th>
    </tr>

    <!--
    loop through school context database to display the result. 
    -->
");
            EndContext();
#line 25 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(497, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(546, 43, false);
#line 29 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearRank));

#line default
#line hidden
            EndContext();
            BeginContext(589, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(645, 17, false);
#line 32 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(662, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "C:\Users\thuan\Desktop\School\T INFO 431\ContosoUniversity_dykstra4\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(705, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
