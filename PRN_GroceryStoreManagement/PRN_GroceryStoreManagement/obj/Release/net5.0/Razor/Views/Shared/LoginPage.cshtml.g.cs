#pragma checksum "C:\Users\quan6\OneDrive\SGK\PRN_SWP\PRN_GroceryStoreManagement\PRN_GroceryStoreManagement\Views\Shared\LoginPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fcb72529aa638b4629bc59d7b06f15b74ad016e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LoginPage), @"mvc.1.0.view", @"/Views/Shared/LoginPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fcb72529aa638b4629bc59d7b06f15b74ad016e", @"/Views/Shared/LoginPage.cshtml")]
    public class Views_Shared_LoginPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<!--\r\nnot main branch\r\n-->\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcb72529aa638b4629bc59d7b06f15b74ad016e2809", async() => {
                WriteLiteral("\r\n    <title>Login Page</title>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcb72529aa638b4629bc59d7b06f15b74ad016e3926", async() => {
                WriteLiteral("\r\n    <h1>Đây là trang login tạm thời testtttttttttttt</h1>\r\n    <form action=\"LoginServlet\" method=\"POST\">\r\n        Username <input type=\"text\" id=\"txtUsername\"");
                BeginWriteAttribute("value", " value=\"", 376, "\"", 384, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br> Password <input type=\"password\" id=\"txtPassword\"");
                BeginWriteAttribute("value", " value=\"", 441, "\"", 449, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br>
        <div id=""ErrorMessage""></div>
        <input type=""button"" value=""Login"" name=""btAction"" onclick=""checkLogin()"" />


    </form>
    <script>
        function checkLogin() {
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function() {
                if (this.readyState >= 4 && this.status <= 200) {
                    var loginErrorObject = JSON.parse(this.responseText);
                    processLoginResponse(loginErrorObject);
                }
            };
            var txtUsername = encodeURIComponent(document.getElementById(""txtUsername"").value);
            var txtPassword = encodeURIComponent(document.getElementById(""txtPassword"").value);
           var JSONObject = {
                txtUsername: txtUsername,
               txtPassword: txtPassword
           };
            xhttp.open(""POST"", ""Login"", true);
            //xhttp.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
            xhttp.setReq");
                WriteLiteral(@"uestHeader('Content-type', 'application/json');
            xhttp.setRequestHeader('Accept', 'application/json');
            xhttp.send(JSON.stringify(JSONObject));
        }

        function processLoginResponse(data) {
            if (data.has_Error) {
                document.getElementById(""ErrorMessage"").innerHTML = data.LoginErr;
            } else {
                //window.location.href = ""TestSuccessLogin.html"";

                if (data.user_type == 1) {
                    window.location.href = ""StoreownerDashboard"";
                } else if (data.user_type == 2) {
                    window.location.href = ""CashierDashboard"";
                }
                //document.getElementById(""ErrorMessage"").innerHTML = ""login successs! you are "" + role;
            }
        }
    </script>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
