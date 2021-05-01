#pragma checksum "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f576c68339e3560209e85cd85bda8cf473584c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Overdue), @"mvc.1.0.view", @"/Views/Booking/Overdue.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f576c68339e3560209e85cd85bda8cf473584c1", @"/Views/Booking/Overdue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa18a685f75738db7c974e4b1ed0d820d1291efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Overdue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend.Models.History>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
  

    Layout = "_BookingLayout";

    var tempDay = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"column mid\">\n");
#nullable restore
#line 10 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
     foreach (var item in Model)
    {
        if (item.lendTime == null && item.rentTime.ToString("dd/MM/yyyy") != tempDay && DateTime.Compare(DateTime.Now, item.rentTime) > 0)
        {
            tempDay = item.rentTime.ToString("dd/MM/yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"date\">วันที่จอง : ");
#nullable restore
#line 15 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                    Write(item.rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <div class=\"panel\">\n");
#nullable restore
#line 17 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                 foreach (var rest in Model)
                {
                    if (rest.rentTime.ToString("dd/MM/yyyy") == tempDay && rest.lendTime == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"content-row\">\n                            <div class=\"equipment\">");
#nullable restore
#line 22 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                              Write(rest.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            <div class=\"time\">");
#nullable restore
#line 23 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                         Write(rest.rentTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น. - ");
#nullable restore
#line 23 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
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
                                <div class=""overdue"">เกินเวลา</div>
                            </div>
                        </div>
");
#nullable restore
#line 33 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 37 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
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
