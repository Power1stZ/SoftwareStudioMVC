#pragma checksum "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e18c4c056336d253424d34bd25afd602e3d64486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SelectEquipment_SelectDate), @"mvc.1.0.view", @"/Views/SelectEquipment/SelectDate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18c4c056336d253424d34bd25afd602e3d64486", @"/Views/SelectEquipment/SelectDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa18a685f75738db7c974e4b1ed0d820d1291efd", @"/Views/_ViewImports.cshtml")]
    public class Views_SelectEquipment_SelectDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_TopNavBarLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"light\">\r\n");
            WriteLiteral("    <div class=\"column left\">\r\n        <h2 class=\"username\">ห้อง : ");
#nullable restore
#line 12 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                               Write(Model.tools.room);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div class=\"schedule-date\">\r\n            <h3 id=\"show-curr\">ตารางวันที่ : ");
#nullable restore
#line 14 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                        Write(Model.historys[0].rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"panel\">\r\n");
#nullable restore
#line 17 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
              
                var nEquipment = Model.tools.maxCount;
                if (DateTime.Compare(DateTime.Now.Date, @Model.historys[0].rentTime.Date) <= 0){
                    for (var item = 1; item < Model.historys.Count;item++){
                        if (DateTime.Compare(Model.historys[item].rentTime.AddMinutes(70), DateTime.Now) < 0){
                            nEquipment--;
                        }
                    }
                }

                //Console.WriteLine(nEquipment);
                int[] nInEachTime = {nEquipment, nEquipment, nEquipment, nEquipment, nEquipment, nEquipment};
                for(var i = 0 ; i < nInEachTime.Length ; i++){
                    if(DateTime.Compare(DateTime.Now.Date, @Model.historys[0].rentTime.Date) <= 0){
                        if(i > 2){
                            foreach(var j in Model.historys){
                                if(DateTime.Compare(j.rentTime, @Model.historys[0].rentTime.AddHours(10 + i).AddMinutes(30)) == 0){
                                    nInEachTime[i]--;
                                }
                            }     
                        }
                        else{
                            foreach(var j in Model.historys){
                                if(DateTime.Compare(j.rentTime, @Model.historys[0].rentTime.AddHours(9 + i).AddMinutes(30)) == 0){
                                    nInEachTime[i]--;
                                }
                            }
                        }
                    }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"content-row\">\r\n");
#nullable restore
#line 48 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                         if (i > 2){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"time\">");
#nullable restore
#line 49 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                         Write(Model.historys[0].rentTime.AddHours(10 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 49 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                                                                                                         Write(Model.historys[0].rentTime.AddHours(11 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น.</div>\r\n");
#nullable restore
#line 50 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"time\">");
#nullable restore
#line 52 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                         Write(Model.historys[0].rentTime.AddHours(9 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 52 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                                                                                                        Write(Model.historys[0].rentTime.AddHours(10 + i).AddMinutes(30).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" น.</div>\r\n");
#nullable restore
#line 53 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n");
#nullable restore
#line 55 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                         if(nInEachTime[i] != 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"status-true\">");
#nullable restore
#line 56 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                                Write(nInEachTime[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" available</div>\r\n");
#nullable restore
#line 57 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"status-false\">");
#nullable restore
#line 59 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                                 Write(nInEachTime[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" available</div>\r\n");
#nullable restore
#line 60 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 62 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"back\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e18c4c056336d253424d34bd25afd602e3d6448612744", async() => {
                WriteLiteral("\r\n                <button class=\"backbtn\">ก่อนหน้า</button>\r\n            ");
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
#line 66 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"column right\">\r\n        <h2 class=\"username\">อุปกรณ์ : ");
#nullable restore
#line 72 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                  Write(Model.tools.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div class=\"select-date\">\r\n            <button class=\"select-datebtn\">\r\n                <div>\r\n                    <img class=\"img-calendar\" src=\"/pic/calendar-alt-solid.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3571, "\"", 3577, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h3 id=\"show-date\">");
#nullable restore
#line 77 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                                  Write(Model.historys[0].rentTime.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n            </button>\r\n        </div>\r\n        <div class=\"check-tool\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e18c4c056336d253424d34bd25afd602e3d6448616468", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" id=\"datefield\" name=\"date\"");
                BeginWriteAttribute("value", " value=\'", 3932, "\'", 3992, 1);
#nullable restore
#line 83 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
WriteAttributeValue("", 3940, Model.historys[0].rentTime.ToString("dd MMMM yyyy"), 3940, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" name=\"toolName\"");
                BeginWriteAttribute("value", " value=\"", 4048, "\"", 4077, 1);
#nullable restore
#line 84 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
WriteAttributeValue("", 4056, Model.tools.toolName, 4056, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <button class=\"check-toolbtn\" type=\"submit\">เช็คอุปกรณ์</button>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"panel-time\">\r\n            <div class=\"content-time\">\r\n                <div class=\"select-time\">\r\n");
#nullable restore
#line 91 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                     if (Model.historys[0].rentTime.Date.AddHours(9).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[0] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t1\" onclick=\"selectTime(id)\">9:30 - 10:30</button>\r\n");
#nullable restore
#line 93 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }else{
                        //Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t1\" disabled>9:30 - 10:30</button>\r\n");
#nullable restore
#line 96 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"select-time\">\r\n");
#nullable restore
#line 99 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                     if (Model.historys[0].rentTime.Date.AddHours(10).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[1] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t2\" onclick=\"selectTime(id)\">10:30 - 11:30</button>\r\n");
#nullable restore
#line 101 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }else{
                       //Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t2\" disabled>10:30 - 11:30</button>\r\n");
#nullable restore
#line 104 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"select-time\">\r\n");
#nullable restore
#line 107 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                     if (Model.historys[0].rentTime.Date.AddHours(11).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[2] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t3\" onclick=\"selectTime(id)\">11:30 - 12:30</button>\r\n");
#nullable restore
#line 109 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }else{
                        //Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t3\" disabled>11:30 - 12:30</button>\r\n");
#nullable restore
#line 112 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"content-time\">\r\n                <div class=\"select-time\">\r\n");
#nullable restore
#line 118 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                     if (Model.historys[0].rentTime.Date.AddHours(13).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[3] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t4\" onclick=\"selectTime(id)\">13:30 - 14:30</button>\r\n");
#nullable restore
#line 120 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }else{
                        //Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t4\" disabled>13:30 - 14:30</button>\r\n");
#nullable restore
#line 123 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"select-time\">\r\n");
#nullable restore
#line 126 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                     if (Model.historys[0].rentTime.Date.AddHours(14).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[4] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t5\" onclick=\"selectTime(id)\">14:30 - 15:30</button>\r\n");
#nullable restore
#line 128 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }else{
                        //Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t5\" disabled>14:30 - 15:30</button>\r\n");
#nullable restore
#line 131 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"select-time\">\r\n");
#nullable restore
#line 134 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                     if (Model.historys[0].rentTime.Date.AddHours(15).AddMinutes(30).CompareTo(DateTime.Now) > 0 && nInEachTime[5] > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"select-timebtn\" id=\"t6\" onclick=\"selectTime(id)\">15:30 - 16:30</button>\r\n");
#nullable restore
#line 136 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                    }else{
                        //Console.WriteLine("Overdue");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"disable-timebtn\" id=\"t6\" disabled>15:30 - 16:30</button>\r\n");
#nullable restore
#line 139 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
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
                <div class=""calendar-days""></div>");
            WriteLiteral(@"
            </div>

            <div class=""month-list""></div>
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
#line 183 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                 Write(Model.tools.toolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>วัน/เดือน/ปี : ");
#nullable restore
#line 184 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
                      Write(Model.historys[0].rentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>ช่วงเวลา : <span id=\"displayTime\">-</span> น.</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e18c4c056336d253424d34bd25afd602e3d6448629057", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" id=\"inputTool\" name=\"inputTool\"");
                BeginWriteAttribute("value", " value=\"", 9244, "\"", 9273, 1);
#nullable restore
#line 187 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
WriteAttributeValue("", 9252, Model.tools.toolName, 9252, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" id=\"inputDate\" name=\"inputDate\"");
                BeginWriteAttribute("value", " value=\'", 9341, "\'", 9399, 1);
#nullable restore
#line 188 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\SelectEquipment\SelectDate.cshtml"
WriteAttributeValue("", 9349, Model.historys[0].rentTime.ToString("dd/MM/yyyy"), 9349, 50, false);

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
