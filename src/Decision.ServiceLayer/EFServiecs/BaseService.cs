using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Decision.DataLayer.Context;
using Decision.DomainClasses.EmployeeEntities;
using Decision.ServiceLayer.Contracts.EmployeeInfo;
using Decision.ServiceLayer.Contracts.Common;
using Decision.ServiceLayer.Contracts.Users;
using Decision.ViewModel.EmpRelative;
using EntityFramework.Extensions;

namespace Decision.ServiceLayer.EFServiecs
{
    public class BaseService
    {
        #region Fields
        protected readonly IMappingEngine MappingEngine;
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IApplicationUserManager UserManager;
        #endregion

        #region Ctor
        public BaseService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine)
        {
            UserManager = userManager;
            UnitOfWork = unitOfWork;
            MappingEngine = mappingEngine;
            var cuser = UserManager.GetCurrentUser();
            if (cuser.UserName == "Admin" || cuser.UserName == "501021")
            {
                UnitOfWork.DisableFiltering("Tenant");
            }
            else
            {
                UnitOfWork.EnableFiltering("Tenant", "empno", cuser.Access);
            }
        }
        #endregion
    }

    public class BaseService<T> where T :class 
    {
        #region Fields
        protected readonly IMappingEngine MappingEngine;
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IApplicationUserManager UserManager;
        protected readonly IDbSet<T> Service;
        #endregion

        #region Ctor
        public BaseService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine)
        {
            UserManager = userManager;
            UnitOfWork = unitOfWork;
            MappingEngine = mappingEngine;
            Service = unitOfWork.Set<T>();
            var cuser = UserManager.GetCurrentUser();
            if (userManager.IsInRoleManager())
            {
                UnitOfWork.DisableFiltering("Tenant");
            }
            else
            {
                UnitOfWork.EnableFiltering("Tenant", "empno", cuser.Access);
            }
        }
        #endregion
    }

}
