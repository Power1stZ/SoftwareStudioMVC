#pragma checksum "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcd0b1a5654e97638fee523a312f49852a65752"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcd0b1a5654e97638fee523a312f49852a65752", @"/Views/SelectEquipment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa18a685f75738db7c974e4b1ed0d820d1291efd", @"/Views/_ViewImports.cshtml")]
    public class Views_SelectEquipment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SelectPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SelectEquipment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_TopNavBarLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"light\">\n");
            WriteLiteral("    <div class=\"column left\">\n        <h2 class=\"username\">ห้อง : ");
#nullable restore
#line 12 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                               Write(Model.tools.room);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <div class=\"schedule-date\">\n            <h3 id=\"show-curr\">ตารางวันที่ : ");
#nullable restore
#line 14 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                        Write(Model.historys[0].rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n        <div class=\"panel\">\n");
#nullable restore
#line 17 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
              
                var nEquipment = Model.tools.maxCount;
                for (var item = 1; item < Model.historys.Count; item++)
                {
                    if (DateTime.Compare(Model.historys[item].rentTime.AddMinutes(70), DateTime.Now) < 0)
                    {
                        nEquipment--;
                    }
                }
                Console.WriteLine(nEquipment);
                int[] nInEachTime = { nEquipment, nEquipment, nEquipment, nEquipment, nEquipment, nEquipment };
                for (var i = 0; i < nInEachTime.Length; i++)
                {
                    if (i > 2)
                    {
                        foreach (var j in Model.historys)
                        {
                            if (DateTime.Compare(j.rentTime, @Model.historys[0].rentTime.AddHours(10 + i).AddMinutes(30)) == 0)
                            {
                                nInEachTime[i]--;
                            }
                        }
                    }
                    else
                    {
                        foreach (var j in Model.historys)
                        {
                            if (DateTime.Compare(j.rentTime, @Model.historys[0].rentTime.AddHours(9 + i).AddMinutes(30)) == 0)
                            {
                                nInEachTime[i]--;
                            }
                        }
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"content-row\">\n");
#nullable restore
#line 52 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                         if (i > 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"time\">");
#nullable restore
#line 54 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                         Write(Model.historys[0].rentTime.AddHours(10 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\n                                ");
#nullable restore
#line 55 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                           Write(Model.historys[0].rentTime.AddHours(11 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น.</div>\n");
#nullable restore
#line 56 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"time\">");
#nullable restore
#line 59 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                         Write(Model.historys[0].rentTime.AddHours(9 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\n                                ");
#nullable restore
#line 60 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                           Write(Model.historys[0].rentTime.AddHours(10 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น.</div>\n");
#nullable restore
#line 61 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 63 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                         if (nInEachTime[i] != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"status-true\">");
#nullable restore
#line 65 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                                Write(nInEachTime[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" available</div>\n");
#nullable restore
#line 66 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"status-false\">");
#nullable restore
#line 69 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                                 Write(nInEachTime[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" available</div>\n");
#nullable restore
#line 70 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n");
#nullable restore
#line 72 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"back\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcd0b1a5654e97638fee523a312f49852a6575212381", async() => {
                WriteLiteral("\n                <button class=\"backbtn\">ก่อนหน้า</button>\n            ");
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
#line 76 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                                                WriteLiteral(Model.tools.room);

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
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"column right\">\n        <h2 class=\"username\">อุปกรณ์ : ");
#nullable restore
#line 82 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                  Write(Model.tools.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <div class=\"select-date\">\n            <button class=\"select-datebtn\">\n                <div>\n                    <img class=\"img-calendar\" src=\"/pic/calendar-alt-solid.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3508, "\"", 3514, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                    <h3 id=\"show-date\">");
#nullable restore
#line 87 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                                  Write(Model.historys[0].rentTime.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                </div>\n            </button>\n        </div>\n        <div class=\"check-tool\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcd0b1a5654e97638fee523a312f49852a6575216058", async() => {
                WriteLiteral("\n                <input type=\"hidden\" id=\"datefield\" name=\"date\"");
                BeginWriteAttribute("value", " value=\'", 3862, "\'", 3922, 1);
#nullable restore
#line 93 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
WriteAttributeValue("", 3870, Model.historys[0].rentTime.ToString("dd MMMM yyyy"), 3870, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                <input type=\"hidden\" name=\"toolName\"");
                BeginWriteAttribute("value", " value=\"", 3977, "\"", 4006, 1);
#nullable restore
#line 94 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
WriteAttributeValue("", 3985, Model.tools.toolName, 3985, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                <button class=\"check-toolbtn\" type=\"submit\">เช็คอุปกรณ์</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"panel-time\">\n            <div class=\"content-time\">\n                <div class=\"select-time\">\n");
#nullable restore
#line 101 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                     if (DateTime.Now.Date.AddHours(9).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[0] >
                    0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t1\" onclick=\"selectTime(id)\">9:30 - 10:30</button>\n");
#nullable restore
#line 105 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }
                    else
                    {
                        Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t1\" disabled>9:30 - 10:30</button>\n");
#nullable restore
#line 110 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"select-time\">\n");
#nullable restore
#line 113 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                     if (DateTime.Now.Date.AddHours(10).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[1] >
                    0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t2\" onclick=\"selectTime(id)\">10:30 - 11:30</button>\n");
#nullable restore
#line 117 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }
                    else
                    {
                        Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t2\" disabled>10:30 - 11:30</button>\n");
#nullable restore
#line 122 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"select-time\">\n");
#nullable restore
#line 125 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                     if (DateTime.Now.Date.AddHours(11).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[2] >
                    0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t3\" onclick=\"selectTime(id)\">11:30 - 12:30</button>\n");
#nullable restore
#line 129 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }
                    else
                    {
                        Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t3\" disabled>11:30 - 12:30</button>\n");
#nullable restore
#line 134 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n\n            <div class=\"content-time\">\n                <div class=\"select-time\">\n");
#nullable restore
#line 140 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                     if (DateTime.Now.Date.AddHours(13).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[3] >
                    0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t4\" onclick=\"selectTime(id)\">13:30 - 14:30</button>\n");
#nullable restore
#line 144 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }
                    else
                    {
                        Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t4\" disabled>13:30 - 14:30</button>\n");
#nullable restore
#line 149 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"select-time\">\n");
#nullable restore
#line 152 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                     if (DateTime.Now.Date.AddHours(14).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[4] >
                    0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t5\" onclick=\"selectTime(id)\">14:30 - 15:30</button>\n");
#nullable restore
#line 156 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }
                    else
                    {
                        Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t5\" disabled>14:30 - 15:30</button>\n");
#nullable restore
#line 161 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"select-time\">\n");
#nullable restore
#line 164 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                     if (DateTime.Now.Date.AddHours(15).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[5] >
                    0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t6\" onclick=\"selectTime(id)\">15:30 - 16:30</button>\n");
#nullable restore
#line 168 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }
                    else
                    {
                        Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t6\" disabled>15:30 - 16:30</button>\n");
#nullable restore
#line 173 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
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
                </div>
                <div class=""calendar-days""></div>
            </div>

     ");
            WriteLiteral(@"       <div class=""month-list""></div>
        </div>

        <div class=""next"">
            <button class=""nextbtn"" id = 'submitted'onclick=""togglePopup()"" disabled>ยืนยัน</button>
        </div>

        <script src=""/js/calendar.js""></script>
    </div>
    <div class=""panel-confirm"" id=""panel-confirm"">
        <div class=""schedule-date"">
            <h3>ยืนยันการจอง</h3>
        </div>
        <h4>อุปกรณ์ : ");
#nullable restore
#line 216 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                 Write(Model.tools.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <h4>วัน/เดือน/ปี : ");
#nullable restore
#line 217 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
                      Write(Model.historys[0].rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <h4>ช่วงเวลา : <span id=\"displayTime\">-</span> น.</h4>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdcd0b1a5654e97638fee523a312f49852a6575228802", async() => {
                WriteLiteral("\n            <input type=\"hidden\" id=\"inputTool\" name=\"inputTool\"");
                BeginWriteAttribute("value", " value=\"", 9472, "\"", 9501, 1);
#nullable restore
#line 220 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
WriteAttributeValue("", 9480, Model.tools.toolName, 9480, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n            <input type=\"hidden\" id=\"inputDate\" name=\"inputDate\"");
                BeginWriteAttribute("value", "\n                value=\'", 9568, "\'", 9642, 1);
#nullable restore
#line 222 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\Index.cshtml"
WriteAttributeValue("", 9592, Model.historys[0].rentTime.ToString("dd/MM/yyyy"), 9592, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            <input type=""hidden"" id=""inputTime"" name=""inputTime"">
            <div class=""confirm"">
                <button class=""confirmbtn"" type=""submit"">ยืนยัน</button>
            </div>
            <div class=""back"">
                <button class=""backbtn"" type=""reset"" onclick=""togglePopup()"">ยกเลิก</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
<script type=""text/javascript"">
    //console.log(document.getElementById(""inputTime"").value);
    //console.log(document.getElementById(""inputDate"").value);
    function selectTime(id) {
        document.getElementById(""inputTime"").value = document.getElementById(id).innerHTML;
        document.getElementById(""displayTime"").innerHTML = document.getElementById(id).innerHTML;
        document.getElementById(""submitted"").disabled = false;
        //console.log(document.getElementById(""inputTime"").value);
    }
</script>");
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
