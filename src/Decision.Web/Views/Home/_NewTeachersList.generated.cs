﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/_NewApplicantsList.cshtml")]
    public partial class _Views_Home__NewApplicantsList_cshtml : System.Web.Mvc.WebViewPage<IList<Decision.ViewModel.Home.NewAddedApplicantViewModel>>
    {
        public _Views_Home__NewApplicantsList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"fa fa-list-alt\"");

WriteLiteral("></span>\r\n                آخرین اساتید ثبت شده\r\n            </h3>\r\n        </div>" +
"\r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"list-group\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\Home\_NewApplicantsList.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Home\_NewApplicantsList.cshtml"
                 foreach (var newAddedApplicantViewModel in Model)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"list-group-item log-list\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 17 "..\..\Views\Home\_NewApplicantsList.cshtml"
                         Write(newAddedApplicantViewModel.FullName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        \r\n                        <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Home\_NewApplicantsList.cshtml"
                                       Write(newAddedApplicantViewModel.CreateDate.ToRemainingDateTime());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </li>\r\n");

            
            #line 21 "..\..\Views\Home\_NewApplicantsList.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("               \r\n\r\n            </ul>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 928)
            
            #line 27 "..\..\Views\Home\_NewApplicantsList.cshtml"
, Tuple.Create(Tuple.Create("", 897), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Applicant.List())
            
            #line default
            #line hidden
, 897), false)
);

WriteLiteral(">\r\n                موارد بیشتر\r\n                <span");

WriteLiteral(" class=\"fa fa-arrow-left\"");

WriteLiteral("></span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n");

        }
    }
}
#pragma warning restore 1591
