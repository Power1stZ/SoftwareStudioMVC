#pragma checksum "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c30bee255fa44dee01239d5b4e3646b0f3a8e709"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30bee255fa44dee01239d5b4e3646b0f3a8e709", @"/Views/Booking/Overdue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa18a685f75738db7c974e4b1ed0d820d1291efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Overdue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend.Models.History>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LendOverdue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
#line 8 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
     if(Model != null && Model.Any()){
        foreach (var item in Model)
        {
            if (item.lendTime == item.createTime && item.rentTime.ToString("dd/MM/yyyy") != tempDay &&
            DateTime.Compare(DateTime.Now,
            item.rentTime) > 0)
            {
                tempDay = item.rentTime.ToString("dd/MM/yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"date\">วันที่จอง : ");
#nullable restore
#line 16 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                        Write(item.rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <div class=\"panel\">\n");
#nullable restore
#line 18 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                     foreach (var rest in Model)
                    {
                        if (rest.rentTime.ToString("dd/MM/yyyy") == tempDay && rest.lendTime == rest.createTime)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-row\">\n                                <div class=\"equipment\">");
#nullable restore
#line 23 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                                  Write(rest.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                <div class=\"time\">");
#nullable restore
#line 24 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                             Write(rest.rentTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น. - ");
#nullable restore
#line 24 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                                                                   Write(rest.rentTime.AddHours(1).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" น.
                                </div>
                                <div class=button2>
                                    <div class=""overdue"">เกินเวลา</div>
                                </div>
                                <div class=button1>
                                    <div class=""restore"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c30bee255fa44dee01239d5b4e3646b0f3a8e7096894", async() => {
                WriteLiteral("\n                                            <button class=\"restorebtn\">คืนอุปกรณ์</button>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                                                                                                 WriteLiteral(rest.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 37 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n");
#nullable restore
#line 41 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
            }
        }
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"no-list\">ไม่มีรายการจอง</div>\n");
#nullable restore
#line 45 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Booking\Overdue.cshtml"
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
