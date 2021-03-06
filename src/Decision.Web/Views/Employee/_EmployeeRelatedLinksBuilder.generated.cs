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
    
    #line 3 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Decision.Common.HtmlHelpers;
    
    #line 4 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
    using Decision.ServiceLayer.Security;
    
    #line default
    #line hidden
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Employee/_EmployeeRelatedLinksBuilder.cshtml")]
    public partial class _Views_Employee__EmployeeRelatedLinksBuilder_cshtml : System.Web.Mvc.WebViewPage<String>
    {
        public _Views_Employee__EmployeeRelatedLinksBuilder_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("فرم مشخصات متقاضی", Url.Action(MVC.Employee.Details(Model)), "list-group-item second-split", "fa fa-eye",AssignableToRolePermissions.CanViewApplicantDetails));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 7 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("وابستگان", Url.Action(MVC.EmpRelative.List(Model)), "list-group-item second-split", "fa fa-map-marker", AssignableToRolePermissions.CanManageAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("سوابق استخدامی", Url.Action(MVC.Experience.List(Model)), "list-group-item second-split", "fa fa-graduation-cap", AssignableToRolePermissions.CanManageEducationalBackground));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 11 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("سوابق تحصیلی", Url.Action(MVC.EmpDegree.List(Model)), "list-group-item second-split", "fa fa-th-list", AssignableToRolePermissions.CanManageArticle));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 13 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("سوابق نظامی", Url.Action(MVC.MilitartyService.List(Model)), "list-group-item second-split", "fa fa-comments", AssignableToRolePermissions.CanManageInterview));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 15 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("سبد رفاهی", "#", "list-group-item second-split", "fa fa-university", AssignableToRolePermissions.CanManageScientificTeaching));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 17 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("بیمه متفرقه شخص", Url.Action(MVC.OtherBime.List(Model)), "list-group-item second-split", "fa fa-leanpub", AssignableToRolePermissions.CanManageResearchExperience));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 19 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("بیمه متفرقه وابسته", Url.Action(MVC.OtherBime.ListOther(Model)), "list-group-item second-split", "fa fa-list-alt", AssignableToRolePermissions.CanManageWorkExperience));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 21 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("مامورین", "#", "list-group-item second-split", "fa fa-list", AssignableToRolePermissions.CanManageWorkExperience));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 23 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("ابلاغ ها", Url.Action(MVC.Eblagh.List(Model)), "list-group-item second-split", "fa fa-leanpub", AssignableToRolePermissions.CanManageAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 25 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("احکام", Url.Action(MVC.Hokm.List(Model)), "list-group-item second-split", "fa fa-comments", AssignableToRolePermissions.CanManageAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 27 "..\..\Views\Employee\_EmployeeRelatedLinksBuilder.cshtml"
Write(Html.SideBarSecureActionLink("حقوق", Url.Action(MVC.MontlyResult.List(Model)), "list-group-item second-split", "fa fa-comments", AssignableToRolePermissions.CanManageAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
