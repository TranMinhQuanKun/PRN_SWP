#pragma checksum "C:\Users\Admin\Desktop\PRN_SWP\PRN_GroceryStoreManagement\PRN_GroceryStoreManagement\Views\Shared\PreviousReceipts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa68a4bfbd7282bd29cda3ad489e11c27cfcfa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PreviousReceipts), @"mvc.1.0.view", @"/Views/Shared/PreviousReceipts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa68a4bfbd7282bd29cda3ad489e11c27cfcfa5", @"/Views/Shared/PreviousReceipts.cshtml")]
    public class Views_Shared_PreviousReceipts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("getTime(); GetPreviousReceipt();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa68a4bfbd7282bd29cda3ad489e11c27cfcfa53531", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 250, "\"", 260, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 287, "\"", 297, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>Previous Receipts Page</title>

    <!-- Custom fonts for this template-->
    <link href=""/storeowner/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""/storeowner/css/gsm-storeowner-stylesheet1.css"" rel=""stylesheet"">
    <!-- Link jquery for sidebar -->
    <script src=""//code.jquery.com/jquery.min.js""></script>
    <link rel=""apple-touch-icon"" sizes=""57x57"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-57x57.png"">
    <link rel=""apple-touch-icon"" sizes=""60x60"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-60x60.png"">
    <link rel=""apple-touch-icon"" sizes=""72x72"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-72x72.png"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""/GroceryStoreManagement/sto");
                WriteLiteral(@"reowner/favicon/apple-icon-76x76.png"">
    <link rel=""apple-touch-icon"" sizes=""114x114"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-114x114.png"">
    <link rel=""apple-touch-icon"" sizes=""120x120"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-120x120.png"">
    <link rel=""apple-touch-icon"" sizes=""144x144"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-144x144.png"">
    <link rel=""apple-touch-icon"" sizes=""152x152"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-152x152.png"">
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""/GroceryStoreManagement/storeowner/favicon/apple-icon-180x180.png"">
    <link rel=""icon"" type=""image/png"" sizes=""192x192"" href=""/GroceryStoreManagement/storeowner/favicon/android-icon-192x192.png"">
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/GroceryStoreManagement/storeowner/favicon/favicon-32x32.png"">
    <link rel=""icon"" type=""image/png"" sizes=""96x96"" href=""/GroceryStoreManagement/storeowner/favicon/favicon-96");
                WriteLiteral(@"x96.png"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/GroceryStoreManagement/storeowner/favicon/favicon-16x16.png"">
    <link rel=""manifest"" href=""/GroceryStoreManagement/storeowner/favicon/manifest.json"">
    <meta name=""msapplication-TileColor"" content=""#ffffff"">
    <meta name=""msapplication-TileImage"" content=""/ms-icon-144x144.png"">
    <meta name=""theme-color"" content=""#ffffff"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa68a4bfbd7282bd29cda3ad489e11c27cfcfa57715", async() => {
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <div id=""sidebar-placeholder"">
        </div>
        <script>
                $.get(""Sidebar"", function (data) {
                    $(""#sidebar-placeholder"").replaceWith(data);
                });
        </script>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <div class=""container-fluid"">
                    <!-- Page Heading -->
                    <div class=""d-sm-flex align-items-center justify-content-between my-3"">
                        <h1 class=""mb-0"" id=""header-page"">BIÊN LAI NHẬP HÀNG</h1>
                    </div>

                    <!-- Divider -->
                    <hr class=""sidebar-divider mb-2"">

                    <!-- Content Row -->
                    <div class=""row"">

                        <!-- Look ");
                WriteLiteral(@"up Table -->
                        <div class=""col-xl-6 col-lg-6"">
                            <div class=""card shadow mb-4"">
                                <div class=""card-header pb-2 pt-3"" style=""margin-bottom:-1rem;"">
                                    <h3 class=""m-0 font-weight-bold text-primary header-center"">TÌM KIẾM</h3>
                                </div>

                                <div class=""card-body"">
                                    <div class=""row justify-content-start"">
                                        <div class=""col-5"">
                                            <h6 class=""font-weight-bold text-primary ml-1 pt-2"">
                                                Từ: &nbsp;
                                            </h6>
                                            <div class=""form-group d-flex"">
                                                <input class=""form-control date-date-from"" type=""date""
                                                       id");
                WriteLiteral(@"=""date-from"" style=""color:black;"">
                                            </div>
                                        </div>
                                        <div class=""col-5"">
                                            <h6 class=""font-weight-bold text-primary pt-2"">
                                                Đến: &nbsp;
                                            </h6>
                                            <div class=""form-group d-flex"">
                                                <input class=""form-control date-date-to"" type=""date""
                                                       id=""date-to"" style=""color:black;"">
                                            </div>
                                        </div>
                                        <div class=""col-2"">
                                            <button onclick=""GetPreviousReceipt()""
                                                    class=""btn btn-primary mb-3"" style=""margin-top:2.2rem;""");
                WriteLiteral(@">
                                                <i class='fas fa-search'></i>
                                            </button>
                                        </div>
                                    </div>

                                    <!-- Look up Table Content -->
                                    <div class=""text-center small"">
                                        <table class=""table table-striped table-border-custom"">
                                            <thead>
                                                <tr>
                                                    <th scope=""col"" class=""table-heading"" style=""width:5%;""></th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:30%;"">Ngày</th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:35%;"">Người tạo</th>
                                                    <th scope=""col"" class=""table-heading"" st");
                WriteLiteral(@"yle=""width:25%;"">Tổng tiền</th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:5%;""></th>
                                                </tr>
                                            </thead>
                                            <tbody id=""tableContent"">
                                            </tbody>
                                        </table>
                                    </div>
                                    <!--/ End of Look up Table Content -->
                                </div>

                            </div>

                        </div>
                        <!--/ End of Look up Table -->
                        <!-- Receipt Information Table -->
                        <div class=""col-xl-6 col-lg-6"">
                            <div class=""card shadow mb-4"">
                                <div class=""card-header pb-2 pt-3"" style=""margin-bottom:-1rem;"">
                             ");
                WriteLiteral(@"       <h3 class=""m-0 font-weight-bold text-primary header-center"">
                                        CHI TIẾT
                                    </h3>
                                </div>

                                <!-- Receipt Information Table Content -->
                                <div class=""card-body mt-1"" style=""display:none;"" id=""receipt-info"">
                                    <div class=""ml-2 d-inline-block"" style=""width:55%;"">
                                        <div class=""row"">
                                            <div class=""justify-content-start d-flex"" style=""width:45%;"">
                                                <span class=""m-0 font-weight-bold text-primary pt-1 ml-1 d-flex"">Người tạo: &nbsp;</span>
                                            </div>
                                            <div class=""justify-content-start d-flex"" style=""width:55%;"">
                                                <span class=""pt-1 ml-1 bill-info"" id=""ST");
                WriteLiteral(@"OREOWNERUSERNAME""></span>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""justify-content-start d-flex"" style=""width:45%;"">
                                                <span class=""m-0 font-weight-bold text-primary pt-1 ml-1 d-flex"">Thời gian: &nbsp;</span>
                                            </div>
                                            <div class=""justify-content-start d-flex"" style=""width:55%;"">
                                                <span class=""pt-1 ml-1 bill-info"" id=""IMPORTDATE""></span>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""justify-content-start d-flex"" style=""width:45%;"">
                                                <span class=");
                WriteLiteral(@"""m-0 font-weight-bold text-primary pt-1 ml-1 d-flex"" style=""color: red !important;"">
                                                    Tổng:
                                                    &nbsp;
                                                </span>
                                            </div>
                                            <div class=""justify-content-start d-flex"" style=""width:55%;"">
                                                <span class=""pt-1 ml-1 bill-info"" id=""TOTALCOST""></span>
                                            </div>
                                        </div>

                                    </div>

                                    <div class=""text-center small pt-2"">
                                        <table class=""table table-striped table-border-custom"">
                                            <thead>
                                                <tr>
                                                    <th scope=""col"" cla");
                WriteLiteral(@"ss=""table-heading"" style=""width:5%;""></th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:30%;"">TÊN SP</th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:20%;"">SỐ LƯỢNG</th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:20%;"">ĐƠN GIÁ</th>
                                                    <th scope=""col"" class=""table-heading"" style=""width:25%;"">THÀNH TIỀN</th>
                                                </tr>
                                            </thead>
                                            <tbody id=""receiptDetailContent"">
                                            </tbody>
                                        </table>

                                    </div>
                                </div>
                                <!--/ End of Receipt Information Table Content -->

                     ");
                WriteLiteral(@"       </div>
                        </div>
                        <!--/ End of Receipt Information Table -->

                    </div>
                </div>
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->
        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Bootstrap core JavaScript-->
    <script src=""/storeowner/vendor/jquery/jquery.min.js""></script>
    <script src=""/storeowner/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""/storeowner/vendor/jquery-easing/jquery.easing.min.js""></script>
    <script src=""/storeowner/vendor/datatables/jquery.dataTables.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""/storeowner/js/gsm-storeowner-1.js""></sc");
                WriteLiteral("ript>\r\n    <script src=\"/storeowner/js/gsm-storeowner-2.js\"></script>\r\n    <script src=\"/storeowner/js/previousreceipt-storeowner.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
