using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Decision.Common.Extentions;
using Decision.DataLayer.Context;
using Decision.DomainClasses.Entities.Common;
using Decision.DomainClasses.Entities.Employee;
using Decision.ServiceLayer.Contracts.Common;
using Decision.ServiceLayer.Contracts.Employee;
using Decision.ServiceLayer.Contracts.Users;
using Decision.Utility;
using Decision.ViewModel.Home;
using Decision.ViewModel.Employee;
using EntityFramework.Extensions;
using Microsoft.AspNet.Identity;

namespace Decision.ServiceLayer.EFServiecs.ApplicantInfo
{
    /// <summary>
    /// نشان دهنده سرویس دهنده عملیات مرتبط با متقاضی
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        #region Fields

        private const int A5Width = 420;
        private const int A5Height = 595;
        private const int A6Width = 298;
        private const int A6Height = 420;

        private const string DefaultAvatarPath = "~/Content/Images/default-avatar.png";

        private readonly IMappingEngine _mappingEngine;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationUserManager _userManager;
        private readonly IDbSet<Employee> _employee;
        private readonly HttpContextBase _httpContextBase;
        private readonly EmployeeDbContext empdbContext;
        #endregion

        #region Ctor

        public EmployeeService(HttpContextBase httpContextBase, IUnitOfWork unitOfWork, IApplicationUserManager userManager,
            IMappingEngine mappingEngine
            )
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _employee = _unitOfWork.Set<Employee>();
            _mappingEngine = mappingEngine;
            _httpContextBase = httpContextBase;
            empdbContext = new EmployeeDbContext();
        }
        #endregion

        #region GetEmployeeDetails
        public async Task<EmployeeDetailsViewModel> GetEmployeeDetails(string id)
        {
            Employee temp = empdbContext.Employee.Where(x => x.Empno == id).FirstOrDefault();
            var viewModel = (EmployeeDetailsViewModel)_mappingEngine.Map<EmployeeDetailsViewModel>(temp);
                //await
                //    _employee.Where(a => a.Empno == id)
                //        .ProjectTo<EmployeeDetailsViewModel>(_mappingEngine)
                //        .FirstOrDefaultAsync();
            return viewModel;
        }
        #endregion

    }
}
