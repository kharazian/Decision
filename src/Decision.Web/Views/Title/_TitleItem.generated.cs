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
    using Decision.Common.MVC;
    
    #line 1 "..\..\Views\Title\_TitleItem.cshtml"
    using Decision.DomainClasses.Entities.Common;
    
    #line default
    #line hidden
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Title/_TitleItem.cshtml")]
    public partial class _Views_Title__TitleItem_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Title.TitleViewModel>
    {
        public _Views_Title__TitleItem_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12 \"");

WriteAttribute("id", Tuple.Create(" id=\"", 118), Tuple.Create("\"", 138)
, Tuple.Create(Tuple.Create("", 123), Tuple.Create("title-", 123), true)
            
            #line 3 "..\..\Views\Title\_TitleItem.cshtml"
, Tuple.Create(Tuple.Create("", 129), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 129), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n       \r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-location-arrow\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        عنوان :\r\n                    </label>\r\n               " +
"     <small>");

            
            #line 13 "..\..\Views\Title\_TitleItem.cshtml"
                      Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-square\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        نوع :\r\n                    </label>\r\n                 " +
"   <small>");

            
            #line 20 "..\..\Views\Title\_TitleItem.cshtml"
                      Write(Html.DisplayFor(a => Model.Type));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n");

            
            #line 22 "..\..\Views\Title\_TitleItem.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Title\_TitleItem.cshtml"
                 if (Model.Type == TitleType.CourseContent)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-square\"");

WriteLiteral("></i>\r\n                        <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                            گروه :\r\n                        </label>\r\n        " +
"                <small>");

            
            #line 29 "..\..\Views\Title\_TitleItem.cshtml"
                          Write(Html.DisplayFor(a => Model.Category));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                    </div>\r\n");

            
            #line 31 "..\..\Views\Title\_TitleItem.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 33 "..\..\Views\Title\_TitleItem.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Title\_TitleItem.cshtml"
              Html.RenderPartial(MVC.Shared.Views._AuditLog, Model);
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-footer \"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(" data-ajax-oncomplete=\"editGetOnComplete(xhr,status)\"");

WriteLiteral("\r\n                   data-ajax=\"true\"");

WriteLiteral(" data-ajax-method=\"GET\"");

WriteLiteral("\r\n                   data-ajax-begin=\"onBegin(xhr,this)\"");

WriteLiteral("\r\n                   data-ajax-mode=\"REPLACE-WITH\"");

WriteLiteral(" data-ajax-success=\"inlineEditGetOnSuccess(data, status, xhr,\'");

            
            #line 41 "..\..\Views\Title\_TitleItem.cshtml"
                                                                                                         Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\')\"");

WriteLiteral("\r\n                   data-ajax-update=\"#title-");

            
            #line 42 "..\..\Views\Title\_TitleItem.cshtml"
                                       Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("href", Tuple.Create("\r\n                   href=\"", 1835), Tuple.Create("\"", 1899)
            
            #line 43 "..\..\Views\Title\_TitleItem.cshtml"
, Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Title.Edit(Model.Id))
            
            #line default
            #line hidden
, 1862), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-edit\"");

WriteLiteral("></i>ویرایش</a>\r\n\r\n                <button");

WriteLiteral(" class=\"btn-sm btn btn-danger\"");

WriteLiteral("\r\n                        type=\"button\"");

WriteLiteral(" data-delete-url=\"");

            
            #line 46 "..\..\Views\Title\_TitleItem.cshtml"
                                                  Write(Url.Action(MVC.Title.Delete()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-removal-element=\"#title-");

            
            #line 46 "..\..\Views\Title\_TitleItem.cshtml"
                                                                                                                Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2137), Tuple.Create("\"", 2158)
, Tuple.Create(Tuple.Create("", 2142), Tuple.Create("remove-", 2142), true)
            
            #line 46 "..\..\Views\Title\_TitleItem.cshtml"
                                                           , Tuple.Create(Tuple.Create("", 2149), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 2149), false)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i>\r\n                    حذف\r\n                </button>\r\n            </div>\r\n  " +
"          <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591