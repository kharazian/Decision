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

namespace Decision.Web.Views.TrainingCenter
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
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TrainingCenter/_ListAjax.cshtml")]
    public partial class _ListAjax : System.Web.Mvc.WebViewPage<Decision.ViewModel.TrainingCenter.TrainingCenterListViewModel>
    {
        public _ListAjax()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 4 "..\..\Views\TrainingCenter\_ListAjax.cshtml"
 foreach (var cneter in Model.TrainingCenters)
{
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\TrainingCenter\_ListAjax.cshtml"
Write(Html.Partial(MVC.TrainingCenter.Views._TrainingCenterItem, cneter));

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\TrainingCenter\_ListAjax.cshtml"
                                                                       
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591