#pragma checksum "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f70e25c138619ab74e8de70be83007d783fe8a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#nullable restore
#line 1 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f70e25c138619ab74e8de70be83007d783fe8a32", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa18a685f75738db7c974e4b1ed0d820d1291efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f70e25c138619ab74e8de70be83007d783fe8a323553", async() => {
                WriteLiteral(@"
    <title>Software Studio</title>
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Prompt&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Prompt:wght@700&display=swap"" rel=""stylesheet"">

    <link rel=""stylesheet"" href=""/css/admin.css"" />
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f70e25c138619ab74e8de70be83007d783fe8a325006", async() => {
                WriteLiteral(@"
    <ul class=""navbar"">
        <li class=""navbarlist""><a class=""active"" href=""#home"">Home</a></li>
        <li class=""navbarlist""><a href=""#news"">News</a></li>
        <li class=""navbarlist""><a href=""#contact"">Contact</a></li>
        <li class=""navbarlist""><a href=""#about"">About</a></li>
    </ul>

    <div class=""admin_header"">
        <div class=""header_element"">
            <div>
                <h3 class='welcome_msg'>สวัสดี, ");
#nullable restore
#line 27 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
                                            Write(User.FindFirst("firstName").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 27 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
                                                                                 Write(User.FindFirst("lastName").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                <p class=""sub_msg"">ระบบจัดการห้องปฏิบัติการสถาบันเทคโนโลยีพระจอมเกล้าเจ้าคุณทหารลาดกระบัง</p>
            </div>
            <div>
                <p class=""clock"">04:00</p>
            </div>
        </div>
        <hr>
        <div class=""tab_area"">
            <button type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 1391, "\"", 1446, 3);
                WriteAttributeValue("", 1401, "location.href=\'", 1401, 15, true);
#nullable restore
#line 36 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 1416, Url.Action("Index", "Admin"), 1416, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1445, "\'", 1445, 1, true);
                EndWriteAttribute();
                WriteLiteral(" >สถานะการจอง</button>\r\n            <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1504, "\"", 1565, 3);
                WriteAttributeValue("", 1514, "location.href=\'", 1514, 15, true);
#nullable restore
#line 37 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 1529, Url.Action("RoomAndTool", "Admin"), 1529, 35, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1564, "\'", 1564, 1, true);
                EndWriteAttribute();
                WriteLiteral(" >จัดการห้องและอุปกรณ์</button>\r\n            <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1632, "\"", 1691, 3);
                WriteAttributeValue("", 1642, "location.href=\'", 1642, 15, true);
#nullable restore
#line 38 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 1657, Url.Action("Blacklist", "Admin"), 1657, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1690, "\'", 1690, 1, true);
                EndWriteAttribute();
                WriteLiteral(" >จัดการ Blacklist</button>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 44 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n    ");
#nullable restore
#line 47 "E:\work\3D\Semester 2\SW Studio\Borrow Web\SoftwareStudioMVC\Frontend\Views\Shared\_AdminLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
