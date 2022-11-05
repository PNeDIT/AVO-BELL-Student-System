#pragma checksum "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67cb6dc6ea99c0f84d7afec972ca7006c52f98f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\_ViewImports.cshtml"
using Student_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\_ViewImports.cshtml"
using Student_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\_ViewImports.cshtml"
using Student_System.DataAccess;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cb6dc6ea99c0f84d7afec972ca7006c52f98f9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb2cdeae75f9acc553502828fdff305cfcdba5f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3 style="" color: cadetblue""> Welcome to our Cambridge Advanced English preparation course! </h3>
<br />
<br />
<br />
<h5 style=""margin-top:3%; margin-bottom:2%; color: dimgray""> Here you can see the names of our current students and their average success.</h5>

");
#nullable restore
#line 9 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
 if (Model == null || Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>No students to show</h4>\r\n");
#nullable restore
#line 12 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div style=""text-align: center; color: dodgerblue; font-style: italic;"" class=""col-6"">
            <h5>Student</h5>
        </div>
        <div style=""text-align: center; color: dodgerblue; font-style: italic;"" class=""col-6"">
            <h5>Average success</h5>

        </div>
    </div>
    <hr />
");
#nullable restore
#line 27 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"student-list\">\r\n            <div");
            BeginWriteAttribute("onclick", " onclick=\"", 826, "\"", 861, 3);
            WriteAttributeValue("", 836, "getStudent(\'", 836, 12, true);
#nullable restore
#line 30 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
WriteAttributeValue("", 848, student.Id, 848, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 859, "\')", 859, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"row\">\r\n                <div style=\"text-align: center;\" class=\"col-6 student-inf\">\r\n                     ");
#nullable restore
#line 32 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
                Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
                                   Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div style=\"text-align: center;\" class=\"col-6\">\r\n                     ");
#nullable restore
#line 35 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
                Write(student.AvgSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <hr />\r\n");
#nullable restore
#line 41 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\User\Documents\ASP.NET\Student_System\Student_System\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    const getStudent = (id) => {\r\n        window.location = `/Home/GetStudent/${id}`\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
