#pragma checksum "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cbebfcf446ba6e83fba2a99d45c0fdc0596d5c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
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
#line 1 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\_ViewImports.cshtml"
using Frontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cbebfcf446ba6e83fba2a99d45c0fdc0596d5c5", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa18a685f75738db7c974e4b1ed0d820d1291efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend.Models.History>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
  
    Layout = "_BookingLayout";
    var tempDay = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"column mid\">\n");
#nullable restore
#line 9 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
     foreach (var item in Model)
    {
        if (item.lendTime == null && item.rentTime.ToString("dd/MM/yyyy") != tempDay)
        {
            tempDay = item.rentTime.ToString("dd/MM/yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"date\">วันที่จอง : ");
#nullable restore
#line 14 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
                                    Write(item.rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <div class=\"panel\">\n");
#nullable restore
#line 16 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
                 foreach (var rest in Model)
            {
                if(rest.rentTime.ToString("dd/MM/yyyy") == tempDay && rest.lendTime == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"content-row\">\n                    <div class=\"equipment\">");
#nullable restore
#line 20 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
                                      Write(rest.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"time\">");
#nullable restore
#line 21 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
                                 Write(rest.rentTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น.- ");
#nullable restore
#line 21 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
                                                                      Write(rest.rentTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" น.</div>
                    <div class=button1>
                        <div class=""restore"">
                            <button class=""restorebtn"">คืนอุปกรณ์</button>
                        </div>
                    </div>
                    <div class=button2>
                        <div class=""cancel"">
                            <button class=""cancelbtn"">ยกเลิกการจอง</button>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 33 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 36 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend.Models.History>> Html { get; private set; }
    }
}
#pragma warning restore 1591
