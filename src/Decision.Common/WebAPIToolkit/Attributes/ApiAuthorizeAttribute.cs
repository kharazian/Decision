﻿using System.Web.Http;

namespace NTierMvcFramework.Common.WebAPIToolkit.Attributes
{
    public sealed class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        public ApiAuthorizeAttribute(params string[] permissions)
        {
            Roles = string.Join(",", permissions);
        }
    }
}