#pragma checksum "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0354c8d6502b3a0717cfabbf0a31df98604a0643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\SourceCodes\PurchaseSystem\Views\_ViewImports.cshtml"
using PurchaseSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SourceCodes\PurchaseSystem\Views\_ViewImports.cshtml"
using PurchaseSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0354c8d6502b3a0717cfabbf0a31df98604a0643", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354566da74be520e92fd5c1fc15e61d662677371", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("skin-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0354c8d6502b3a0717cfabbf0a31df98604a06434809", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>AdminLTE 2 | Dashboard</title>
    <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
    <!-- Bootstrap 3.3.2 -->
    <link href=""../../bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Font Awesome Icons -->
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Ionicons -->
    <link href=""http://code.ionicframework.com/ionicons/2.0.0/css/ionicons.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Theme style -->
    <link href=""../../dist/css/AdminLTE.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
         folder instead of downloading all of them to reduce the load. -->
    <link href=""../../dist/css/skins/_all-skins.min.css"" rel=""stylesheet"" type=""text/css"" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and m");
                WriteLiteral(@"edia queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js""></script>
    <![endif]-->
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0354c8d6502b3a0717cfabbf0a31df98604a06437190", async() => {
                WriteLiteral(@"
    <!-- Site wrapper -->
    <div class=""wrapper"">

        <header class=""main-header"">
            <a href=""../../index2.html"" class=""logo""><b>Admin</b>LTE</a>
            <!-- Header Navbar: style can be found in header.less -->
            <nav class=""navbar navbar-static-top"" role=""navigation"">
                <!-- Sidebar toggle button-->
                <a href=""#"" class=""sidebar-toggle"" data-toggle=""offcanvas"" role=""button"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span style=""color:white""></span>
                    <span style=""color:white"">Purchase Management System</span>
                </a>
                <div class=""navbar-custom-menu"">
                    <ul class=""nav navbar-nav"">
                        <!-- Messages: style can be found in dropdown.less-->
                        <li class=""dropdown messages-menu"">
      ");
                WriteLiteral(@"                      <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <i class=""fa fa-envelope-o""></i>
                                <span class=""label label-success"">4</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <li class=""header"">You have 4 messages</li>
                                <li>
                                    <!-- inner menu: contains the actual data -->
                                    <ul class=""menu"">
                                        <li>
                                            <!-- start message -->
                                            <a href=""#"">
                                                <div class=""pull-left"">
                                                    <img src=""../../dist/img/user2-160x160.jpg"" class=""img-circle"" alt=""User Image"" />
                                                </div>
                   ");
                WriteLiteral(@"                             <h4>
                                                    Support Team
                                                    <small><i class=""fa fa-clock-o""></i> 5 mins</small>
                                                </h4>
                                                <p>Why not buy a new awesome theme?</p>
                                            </a>
                                        </li><!-- end message -->
                                    </ul>
                                </li>
                                <li class=""footer""><a href=""#"">See All Messages</a></li>
                            </ul>
                        </li>
                        <!-- Notifications: style can be found in dropdown.less -->
                        <li class=""dropdown notifications-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <i class=""fa fa-bell-o""></i>
                 ");
                WriteLiteral(@"               <span class=""label label-warning"">10</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <li class=""header"">You have 10 notifications</li>
                                <li>
                                    <!-- inner menu: contains the actual data -->
                                    <ul class=""menu"">
                                        <li>
                                            <a href=""#"">
                                                <i class=""fa fa-users text-aqua""></i> 5 new members joined today
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""footer""><a href=""#"">View all</a></li>
                            </ul>
                        </li>
                        <!-- Tasks: style can be found in dropdown.les");
                WriteLiteral(@"s -->
                        <li class=""dropdown tasks-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <i class=""fa fa-flag-o""></i>
                                <span class=""label label-danger"">9</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <li class=""header"">You have 9 tasks</li>
                                <li>
                                    <!-- inner menu: contains the actual data -->
                                    <ul class=""menu"">
                                        <li>
                                            <!-- Task item -->
                                            <a href=""#"">
                                                <h3>
                                                    Design some buttons
                                                    <small class=""pull-right"">20%</small>
       ");
                WriteLiteral(@"                                         </h3>
                                                <div class=""progress xs"">
                                                    <div class=""progress-bar progress-bar-aqua"" style=""width: 20%"" role=""progressbar"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                        <span class=""sr-only"">20% Complete</span>
                                                    </div>
                                                </div>
                                            </a>
                                        </li><!-- end task item -->
                                    </ul>
                                </li>
                                <li class=""footer"">
                                    <a href=""#"">View all tasks</a>
                                </li>
                            </ul>
                        </li>
                        <!-- User Account: style can be found in d");
                WriteLiteral(@"ropdown.less -->
                        <li class=""dropdown user user-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <img src=""../../dist/img/user2-160x160.jpg"" class=""user-image"" alt=""User Image"" />
                                <span class=""hidden-xs"">Alexander Pierce</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <!-- User image -->
                                <li class=""user-header"">
                                    <img src=""../../dist/img/user2-160x160.jpg"" class=""img-circle"" alt=""User Image"" />
                                    <p>
                                        Alexander Pierce - Web Developer
                                        <small>Member since Nov. 2012</small>
                                    </p>
                                </li>
                                <!-- Menu Body -->
          ");
                WriteLiteral(@"                      <li class=""user-body"">
                                    <div class=""col-xs-4 text-center"">
                                        <a href=""#"">Followers</a>
                                    </div>
                                    <div class=""col-xs-4 text-center"">
                                        <a href=""#"">Sales</a>
                                    </div>
                                    <div class=""col-xs-4 text-center"">
                                        <a href=""#"">Friends</a>
                                    </div>
                                </li>
                                <!-- Menu Footer-->
                                <li class=""user-footer"">
                                    <div class=""pull-left"">
                                        <a href=""#"" class=""btn btn-default btn-flat"">Profile</a>
                                    </div>
                                    <div class=""pull-right"">
                    ");
                WriteLiteral(@"                    <a href=""#"" class=""btn btn-default btn-flat"">Sign out</a>
                                    </div>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>

        <!-- =============================================== -->
        <!-- Left side column. contains the sidebar -->
        <aside class=""main-sidebar"">
            <!-- sidebar: style can be found in sidebar.less -->
            <section class=""sidebar"">
                <!-- Sidebar user panel -->
                <div class=""user-panel"">
                    <div class=""pull-left image"">
                        <img src=""../../dist/img/user2-160x160.jpg"" class=""img-circle"" alt=""User Image"" />
                    </div>
                    <div class=""pull-left info"">
                        <p>Alexander Pierce</p>

                        <a href=""#""><i class=""fa fa-circle text");
                WriteLiteral("-success\"></i> Online</a>\r\n                    </div>\r\n                </div>\r\n                <!-- search form -->\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0354c8d6502b3a0717cfabbf0a31df98604a064317335", async() => {
                    WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" name=""q"" class=""form-control"" placeholder=""Search..."" />
                        <span class=""input-group-btn"">
                            <button type='submit' name='seach' id='search-btn' class=""btn btn-flat""><i class=""fa fa-search""></i></button>
                        </span>
                    </div>
                ");
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
                WriteLiteral(@"
                <!-- /.search form -->
                <!-- sidebar menu: : style can be found in sidebar.less -->

                <ul class=""sidebar-menu"">
                    <li class=""header"">MAIN NAVIGATION</li>
                    <li class=""active treeview"">
                        <a href=""#"">
                            <i class=""fa fa-dashboard""></i> <span>Home</span> <i class=""fa fa-angle-left pull-left""></i>
                        </a>
                        <ul class=""treeview-menu"">
                            <li>");
#nullable restore
#line 204 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa fa-book\"></i>Home</li>\r\n                            <li>");
#nullable restore
#line 205 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("About Us", "About", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa fa-book\"></i>About Us</li>\r\n                            <li>");
#nullable restore
#line 206 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Contact Us", "Contact", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""fa fa-book""></i>Contact Us</li>
                        </ul>
                    </li>
                    <li class=""treeview"">
                        <a href=""#"">
                            <i class=""fa fa-dashboard""></i><span>Transactions</span><i class=""fa fa-angle-left pull-left""></i>
                        </a>
                        <ul class=""treeview-menu"">
                            <li>");
#nullable restore
#line 214 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Item Section", "Display", "Item"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa fa-book\"></i>Item Section</li>\r\n                            <li>");
#nullable restore
#line 215 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Purchase Section", "Display", "Purchase"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa fa-book\"></i>Purchase Section</li>\r\n                            <li>");
#nullable restore
#line 216 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Issuance Section", "Display", "Issuance"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""fa fa-book""></i>Issuance Section</li>
                        </ul>
                    </li>
                    <li class=""treeview"">
                        <a href=""#"">
                            <i class=""fa fa-dashboard""></i><span>Reports</span><i class=""fa fa-angle-left pull-left""></i>
                        </a>
                        <ul class=""treeview-menu"">
                            <li>");
#nullable restore
#line 224 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Item Report", "ItemData", "Report"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa fa-book\"></i>Item Section</li>\r\n                            <li>");
#nullable restore
#line 225 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Purchase Report", "PurchaseReport", "Report"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa fa-book\"></i>Purchase Section</li>\r\n                            <li>");
#nullable restore
#line 226 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Issuance Report", "IssuanceReport", "Report"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""fa fa-book""></i>Issuance Section</li>
                        </ul>
                    </li>
                </ul>
            </section>
            <!-- /.sidebar -->
        </aside>

        <!-- =============================================== -->
        <!-- Right side column. Contains the navbar and content of the page -->
        <div class=""content-wrapper"">

            <!-- Main content -->
            <section class=""content"">
                ");
#nullable restore
#line 240 "C:\SourceCodes\PurchaseSystem\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </section>
        </div><!-- /.content-wrapper -->

        <footer class=""main-footer"">
            <div class=""pull-right hidden-xs"">
                <b>Version</b> 2.0
            </div>
            <strong>Copyright &copy; 2023 <a href=""http://almsaeedstudio.com""> 2nd Floor </a>.</strong>
        </footer>
    </div><!-- ./wrapper -->
    <!-- jQuery 2.1.3 -->
    <script src=""../../plugins/jQuery/jQuery-2.1.3.min.js""></script>
    <!-- Bootstrap 3.3.2 JS -->
    <script src=""../../bootstrap/js/bootstrap.min.js"" type=""text/javascript""></script>
    <!-- SlimScroll -->
    <script src=""../../plugins/slimScroll/jquery.slimScroll.min.js"" type=""text/javascript""></script>
    <!-- FastClick -->
    <script src='../../plugins/fastclick/fastclick.min.js'></script>
    <!-- AdminLTE App -->
    <script src=""../../dist/js/app.min.js"" type=""text/javascript""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
