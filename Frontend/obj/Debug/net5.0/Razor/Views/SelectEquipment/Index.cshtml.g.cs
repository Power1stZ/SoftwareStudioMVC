#pragma checksum "E:\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10944112e9ebd5eba80885920f507a6a9ab2e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SelectEquipment_Index), @"mvc.1.0.view", @"/Views/SelectEquipment/Index.cshtml")]
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
#line 1 "E:\SoftwareStudioMVC\Frontend\Views\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SoftwareStudioMVC\Frontend\Views\_ViewImports.cshtml"
using Frontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10944112e9ebd5eba80885920f507a6a9ab2e67", @"/Views/SelectEquipment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_SelectEquipment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SelectPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_TopNavBarLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""light"">

    <div class=""column left"">
        <h2 class=""username"">ห้องที่ : 1</h2>
        <div class=""schedule-date"">
            <h3>ตารางวันที่ : 4/4/2021</h3>
        </div>
        <div class=""panel"">
            <div class=""content-row"">
                <div class=""time"">9.30-10.30 น.</div>
                <div class=""status-true"">5 available</div>
            </div>
            <div class=""content-row"">
                <div class=""time"">10.30-11.30 น.</div>
                <div class=""status-true"">5 available</div>
            </div>
            <div class=""content-row"">
                <div class=""time"">11.30-12.30 น.</div>
                <div class=""status-true"">5 available</div>
            </div>
            <hr class=""hr-thin"" />
            <div class=""content-row"">
                <div class=""time"">13.30-14.30 น.</div>
                <div class=""status-false"">0 available</div>
            </div>
            <div class=""content-row"">
                <di");
            WriteLiteral(@"v class=""time"">14.30-15.30 น.</div>
                <div class=""status-true"">5 available</div>
            </div>
            <div class=""content-row"">
                <div class=""time"">15.30-16.30 น.</div>
                <div class=""status-false"">0 available</div>
            </div>
        </div>
        <div class=""back"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a10944112e9ebd5eba80885920f507a6a9ab2e675322", async() => {
                WriteLiteral("\r\n                <button class=\"backbtn\">ก่อนหน้า</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""column right"">
        <h2 class=""username"">อุปกรณ์ : เชิงเทียน</h2>
        <div class=""select-date"">
            <button class=""select-datebtn"">
                <div>
                    <img class=""img-calaendar"" src=""img/calendar-alt-solid.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1878, "\"", 1884, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h3 id=""show-date""></h3>
                </div>
            </button>
        </div>
        <div class=""panel-time"">
            <div class=""content-time"">
                <div class=""select-time"">
                    <button class=""select-timebtn"">9.30 - 10.30</button>
                </div>
                <div class=""select-time"">
                    <button class=""select-timebtn"">10.30 - 11.30</button>
                </div>
                <div class=""select-time"">
                    <button class=""select-timebtn"">11.30 - 12.30</button>
                </div>
            </div>

            <div class=""content-time"">
                <div class=""select-time"">
                    <button class=""select-timebtn"">13.30 - 14.30</button>
                </div>
                <div class=""select-time"">
                    <button class=""select-timebtn"">14.30 - 15.30</button>
                </div>
                <div class=""select-time"">
                    <b");
            WriteLiteral(@"utton class=""select-timebtn"">15.30 - 16.30</button>
                </div>
            </div>
        </div>
        <div class=""calendar"">
            <div class=""calendar-header"">
                <span class=""month-picker"" id=""month-picker"">February</span>
                <div class=""year-picker"">
                    <span class=""year-change"" id=""prev-year"">
                        <pre><</pre>
                    </span>
                    <span id=""year"">2021</span>
                    <span class=""year-change"" id=""next-year"">
                        <pre>></pre>
                    </span>
                </div>
            </div>
            <div class=""calendar-body"">
                <div class=""calendar-week-day"">
                    <div>Sun</div>
                    <div>Mon</div>
                    <div>Tue</div>
                    <div>Wed</div>
                    <div>Thu</div>
                    <div>Fri</div>
                    <div>Sat</div>
                </di");
            WriteLiteral(@"v>
                <div class=""calendar-days""></div>
            </div>

            <div class=""month-list""></div>
        </div>

        <div class=""next"" onclick=""togglePopup()"">
            <button class=""nextbtn"">ถัดไป</button>
        </div>


        <script src=""/js/calendar.js""></script>
    </div>
    <div class=""panel-confirm"" id=""panel-confirm"">
        <div class=""schedule-date"">
            <h3>ยืนยันการจอง</h3>
        </div>
        <h4>อุปกรณ์ : เชิงเทียน</h4>
        <h4>วัน/เดือน/ปี : 4/4/2021</h4>
        <h4>ช่วงเวลา : 9.30-10.30 น.</h4>
        <div class=""confirm"">
            <button class=""confirmbtn"">ยืนยัน</button>
        </div>
        <div class=""back"" onclick=""togglePopup()"">
            <button class=""backbtn"">ยกเลิก</button>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
