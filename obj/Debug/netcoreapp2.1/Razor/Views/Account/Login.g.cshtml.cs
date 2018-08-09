#pragma checksum "/Users/ryandines/Projects/SqlServerApp/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452ff1e9f1824caa9a79ef1a251ebabec829bb2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "/Users/ryandines/Projects/SqlServerApp/Views/_ViewImports.cshtml"
using SqlServerApp;

#line default
#line hidden
#line 2 "/Users/ryandines/Projects/SqlServerApp/Views/_ViewImports.cshtml"
using SqlServerApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452ff1e9f1824caa9a79ef1a251ebabec829bb2b", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be7e972047b896ffe56cbf98ae779a22058aaf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("account"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 157, true);
            WriteLiteral("<div class=\"container body-content\">\r\n\r\n\r\n    <h2>Log in</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <section>\r\n                ");
            EndContext();
            BeginContext(157, 2766, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb3778e187f45178988d12e9f4d7a27", async() => {
                BeginContext(214, 2702, true);
                WriteLiteral(@"
                    <h4>Use a local account to log in.</h4>
                    <hr>
                    <div class=""text-danger validation-summary-valid"" data-valmsg-summary=""true"">
                        <ul>
                            <li style=""display:none""></li>
                        </ul>
                    </div>
                    <div class=""form-group"">
                        <label for=""Input_Email"">Email</label>
                        <input class=""form-control"" type=""email"" data-val=""true"" data-val-email=""The Email field is not a valid e-mail address."" data-val-required=""The Email field is required."" id=""Input_Email"" name=""Input.Email"" value="""">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.Email"" data-valmsg-replace=""true""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Input_Password"">Password</label>
                        <input class=""form-control"" t");
                WriteLiteral(@"ype=""password"" data-val=""true"" data-val-required=""The Password field is required."" id=""Input_Password"" name=""Input.Password"">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.Password"" data-valmsg-replace=""true""></span>
                    </div>
                    <div class=""form-group"">
                        <div class=""checkbox"">
                            <label for=""Input_RememberMe"">
                                <input type=""checkbox"" data-val=""true"" data-val-required=""The Remember me? field is required."" id=""Input_RememberMe"" name=""Input.RememberMe"" value=""true"">
                                Remember me?
                            </label>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-default"">Log in</button>
                    </div>
                    <div class=""form-group"">
                        <p>
     ");
                WriteLiteral(@"                       <a id=""forgot-password"" href=""/Identity/Account/ForgotPassword"">Forgot your password?</a>
                        </p>
                        <p>
                            <a href=""/Identity/Account/Register?returnUrl=%2F"">Register as a new user</a>
                        </p>
                    </div>
                    <input name=""__RequestVerificationToken"" type=""hidden"" value=""CfDJ8IWbPHM_NTJDv_7HGewWzbYSGrBQCXAuzSubuem5-ONYoFfbxxDgctFbYH42Lhebbce1-eKaa3MeoBsZvf6SlgJ8tAouSMyEXpWyOAjrQeslUVx7DH6gbfWBqzzW3iRxoKvRXBhNc9KYbzGJIAZi08M""><input name=""Input.RememberMe"" type=""hidden"" value=""false"">
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2923, 631, true);
            WriteLiteral(@"
            </section>
        </div>
        <div class=""col-md-6 col-md-offset-2"">
            <section>
                <h4>Use another service to log in.</h4>
                <hr>
                <div>
                    <p>
                        There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                        for details on setting up this ASP.NET application to support logging in via external services.
                    </p>
                </div>
            </section>
        </div>
    </div>
</div>
");
            EndContext();
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
