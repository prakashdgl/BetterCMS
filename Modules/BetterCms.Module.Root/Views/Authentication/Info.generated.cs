﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Authentication\Info.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Authentication/Info.cshtml")]
    public partial class Info : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.Models.Authentication.InfoViewModel>
    {
        public Info()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-sidemenu-credentials\"");

WriteLiteral(">\r\n    <div>");

            
            #line 4 "..\..\Views\Authentication\Info.cshtml"
    Write(RootGlobalization.Sidebar_LoggedInAsTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 5 "..\..\Views\Authentication\Info.cshtml"
    
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Authentication\Info.cshtml"
     if (!string.IsNullOrEmpty(Model.EditUserProfileUrl))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-sidemenu-username\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"bcms-pointer\"");

WriteLiteral(" data-url=\"");

            
            #line 8 "..\..\Views\Authentication\Info.cshtml"
                                         Write(Model.EditUserProfileUrl);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Authentication\Info.cshtml"
                                                                    Write(Html.Encode(Model.UserName));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteLiteral(" class=\"bcms-pointer bcms-view-page-as-public\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Authentication\Info.cshtml"
                                                                                 Write(RootGlobalization.Authentication_ViewAsPublic_Public);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n");

            
            #line 11 "..\..\Views\Authentication\Info.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-sidemenu-username\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\Authentication\Info.cshtml"
       Write(Html.Encode(Model.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <a");

WriteLiteral(" class=\"bcms-pointer bcms-view-page-as-public\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Authentication\Info.cshtml"
                                                                                 Write(RootGlobalization.Authentication_ViewAsPublic_Public);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n");

            
            #line 18 "..\..\Views\Authentication\Info.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
