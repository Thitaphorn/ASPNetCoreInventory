#pragma checksum "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Frontend\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5deea8af1a70212d71541bdd7a2fc6a62578c88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Frontend_Login), @"mvc.1.0.view", @"/Views/Frontend/Login.cshtml")]
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
#line 1 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\_ViewImports.cshtml"
using ASPNetCoreInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\_ViewImports.cshtml"
using ASPNetCoreInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5deea8af1a70212d71541bdd7a2fc6a62578c88", @"/Views/Frontend/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581af0b1db14ac4b6ed983111f43a9c2c7e33217", @"/Views/_ViewImports.cshtml")]
    public class Views_Frontend_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Frontend\Login.cshtml"
  
    ViewBag.Title = "เข้าสู่ระบบ";
    Layout = "~/Views/Shared/_Authen.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card o-hidden border-0 shadow-lg my-5"">
    <div class=""card-body p-0"">
        <!-- Nested Row within Card Body -->
        <div class=""row"">
            <div class=""col-lg-6 d-none d-lg-block bg-login-image""></div>
            <div class=""col-lg-6"">
                <div class=""p-5"">
                    <div class=""text-center"">
                        <h1 class=""h4 text-gray-900 mb-4"">เข้าสู่ระบบ</h1>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5deea8af1a70212d71541bdd7a2fc6a62578c884333", async() => {
                WriteLiteral(@"

                        <div class=""form-group"">
                            <input type=""email"" class=""form-control form-control-user""
                                   id=""exampleInputEmail"" aria-describedby=""emailHelp""
                                   placeholder=""Enter Email Address..."">
                        </div>

                        <div class=""form-group"">
                            <input type=""password"" class=""form-control form-control-user""
                                   id=""exampleInputPassword"" placeholder=""Password"">
                        </div>
                        <div class=""form-group"">
                            <div class=""custom-control custom-checkbox small"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                <label class=""custom-control-label"" for=""customCheck"">
                                    Remember
                                    Me
                    ");
                WriteLiteral(@"            </label>
                            </div>
                        </div>
                        <a href=""/backend"" class=""btn btn-primary btn-user btn-block"">
                            Login
                        </a>
                        <hr>
                        <a href=""/backend"" class=""btn btn-google btn-user btn-block"">
                            <i class=""fab fa-google fa-fw""></i> Login with Google
                        </a>
                        <a href=""/backend"" class=""btn btn-facebook btn-user btn-block"">
                            <i class=""fab fa-facebook-f fa-fw""></i> Login with Facebook
                        </a>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <hr>\r\n                    <div class=\"text-center\">\r\n                        <a class=\"small\" href=\"#\">ลืมรหัสผ่าน ?</a>\r\n                    </div>\r\n                    <div class=\"text-center\">\r\n                        ");
#nullable restore
#line 53 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Frontend\Login.cshtml"
                   Write(Html.ActionLink("ยังไม่เป็นสมาชิก ลงทะเบียน", "Register", "Frontend", null, new { @class = "small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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