﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Author\Partial\ListTemplate.cshtml"
    using BetterCms.Module.Blog.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Author\Partial\ListTemplate.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Author\Partial\ListTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Author\Partial\ListTemplate.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Author/Partial/ListTemplate.cshtml")]
    public partial class _Views_Author_Partial_ListTemplate_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Author_Partial_ListTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Author\Partial\ListTemplate.cshtml"
  
    var gridViewModel = new EditableGridViewModel
    {
        TopBlockClass = "bcms-top-block-holder",
        Columns = new List<EditableGridColumn>
            {
                new EditableGridColumn(BlogGlobalization.SiteSettings_AuthorsTab_AuthorImage_Title, "", "imageId")
                    {
                        HeaderAttributes = "style=\"width: 105px;\"",
                        CellView = "Partial/ImageCell"
                    },
                new EditableGridColumn(BlogGlobalization.SiteSettings_AuthorsTab_AuthorName_Title, "Name", "name")
                    {
                        AutoFocus = true
                    },
                new EditableGridColumn(BlogGlobalization.SiteSettings_AuthorsTab_AuthorDescription_Title, "Description", "description")    
            }
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 26 "..\..\Views\Author\Partial\ListTemplate.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridTemplate, gridViewModel));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
