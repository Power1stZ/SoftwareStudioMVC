#pragma checksum "E:\SoftwareStudioMVC\Frontend\Views\HomeAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f58208d1712cb778532e59ff6d50435b161a85d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeAdmin_Index), @"mvc.1.0.view", @"/Views/HomeAdmin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f58208d1712cb778532e59ff6d50435b161a85d", @"/Views/HomeAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\SoftwareStudioMVC\Frontend\Views\HomeAdmin\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_AdminSidebarLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""column mid"">
    <h2 class=""roomno"">ห้องที่ 1</h2>
    <div class=""dropdownrow"">
        <div class=""dropdown"">
            <button class=""dropbtn"">อุปกรณ์ : เชิงเทียน</button>
            <div class=""dropdown-content"">
                <a href=""#"">Link 1</a>
                <a href=""#"">Link 2</a>
                <a href=""#"">Link 3</a>
            </div>
        </div>
        <div class=""dropdown"">
            <button class=""dropbtn"">ช่วงเวลา : 9:30 - 10:30</button>
            <div class=""dropdown-content"">
                <a href=""#"">Link 1</a>
                <a href=""#"">Link 2</a>
                <a href=""#"">Link 3</a>
            </div>
        </div>
    </div>
    <div class=""column even"">
        <h3 class=""leftcolhead"">สถานะการจอง</h3>
        <div class=""leftcardcontent"">
            <div class=""listcontent"">
                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <button class=""canclebookbutton"">ยกเลิกก");
            WriteLiteral(@"ารจอง</button>
                </div>
                <hr class=""solid"">

                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <button class=""canclebookbutton"">ยกเลิกการจอง</button>
                </div>
                <hr class=""solid"">

                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <button class=""canclebookbutton"">ยกเลิกการจอง</button>
                </div>
                <hr class=""solid"">

                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <p class=""bookerstatusreturned"">คืนอุปกรณ์แล้ว</p>
                </div>
                <hr class=""solid"">

                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <p class=""bookerstatuscancled"">ยกเลิกการจองแล้ว</p>
                </div>
                <hr class=""solid"">

            </div>
 ");
            WriteLiteral(@"       </div>
    </div>
    <div class=""column even"">
        <h3 class=""rightcolhead"">ประวัติการยืมเกินเวลา</h3>
        <div class=""rightcardcontent"">
            <div class=""listcontent"">
                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <button class=""banbutton"">Ban</button>
                </div>
                <hr class=""solid"">

                <div class=""listelement"">
                    <p class=""booker"">SwaggyTT</p>
                    <button class=""bannedbutton"">Banned</button>
                </div>
                <hr class=""solid"">



            </div>
        </div>
    </div>
</div>
</div>
");
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
