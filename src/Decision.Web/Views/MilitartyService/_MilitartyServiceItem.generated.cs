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
    using Decision.Common.HtmlHelpers;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MilitartyService/_MilitartyServiceItem.cshtml")]
    public partial class _Views_MilitartyService__MilitartyServiceItem_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.EmpMilitary.MilitaryServiceViewModel>
    {
        public _Views_MilitartyService__MilitartyServiceItem_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12 data-item\"");

WriteAttribute("id", Tuple.Create(" id=\"", 96), Tuple.Create("\"", 119)
, Tuple.Create(Tuple.Create("", 101), Tuple.Create("Empno-", 101), true)
            
            #line 2 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
, Tuple.Create(Tuple.Create("", 107), Tuple.Create<System.Object, System.Int32>(Model.Empno
            
            #line default
            #line hidden
, 107), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">نوع سابقه:</label>\r\n                    <small>");

            
            #line 8 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.TypeDsc);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">تاریخ شروع:</label>\r\n                    <small>");

            
            #line 12 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.StartDate.GetDatePersianNumber());

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">تاریخ پایان:</label>\r\n                    <small>");

            
            #line 16 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.EndDate.GetDatePersianNumber());

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">درصد جانبازی:</label>\r\n                    <small>");

            
            #line 20 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.JanBazPercent);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">تعداد گروه مرتبط:</label>\r\n                    <small>");

            
            #line 24 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.Groups);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">محل:</label>\r\n                    <small>");

            
            #line 28 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.PlcDsc);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">تاریخ اجرا:</label>\r\n                    <small>");

            
            #line 32 "..\..\Views\MilitartyService\_MilitartyServiceItem.cshtml"
                      Write(Model.StartDate.GetDatePersianNumber());

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r" +
"\n</div>");

        }
    }
}
#pragma warning restore 1591
