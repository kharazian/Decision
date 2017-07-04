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
using Decision.DomainClasses.EmployeeEntities;
using Decision.ServiceLayer.Contracts.Common;
using Decision.ServiceLayer.Contracts.EmployeeInfo;
using Decision.ServiceLayer.Contracts.Users;
using Decision.Utility;
using Decision.ViewModel.Home;
using Decision.ViewModel.Employee;
using EntityFramework.Extensions;
using Microsoft.AspNet.Identity;

namespace Decision.ServiceLayer.EFServiecs.EmployeeInfo
{
    /// <summary>
    /// نشان دهنده سرویس دهنده عملیات مرتبط با متقاضی
    /// </summary>
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        #region Fields

        private const int A5Width = 420;
        private const int A5Height = 595;
        private const int A6Width = 298;
        private const int A6Height = 420;

        private const string DefaultAvatarPath = "~/Content/Images/default-avatar.png";
        
        private readonly HttpContextBase _httpContextBase;
        #endregion

        #region Ctor

        public EmployeeService(HttpContextBase httpContextBase, IUnitOfWork unitOfWork, IApplicationUserManager userManager,
            IMappingEngine mappingEngine):base(unitOfWork, userManager, mappingEngine)
        {
            _httpContextBase = httpContextBase;
        }
        #endregion

        #region GetPagedList
        public async Task<EmployeeListViewModel> GetPagedListAsync(EmployeeSearchRequest request)
        {
            var employees =
                Service//.Include(a => a.CreatedBy)
                    //.Include(a => a.ModifiedBy)
                    .AsNoTracking()
                    .AsQueryable();

            if (request.IdNo.HasValue())
                employees = employees.Where(a => a.IdNo == request.IdNo).AsQueryable();
            if (request.MelliCode.HasValue())
                employees = employees.Where(a => a.MelliCode == request.MelliCode).AsQueryable();
            if (request.Name.HasValue())
                employees = employees.Where(a => a.Name.Contains(request.Name)).AsQueryable();
            if (request.Family.HasValue())
                employees = employees.Where(a => a.Family.Contains(request.Family)).AsQueryable();

            employees = employees.OrderBy($"{request.CurrentSort} {request.SortDirection}");

            var selectedEmployees = employees.ProjectTo<EmployeeViewModel>(MappingEngine);
            var resultsToSkip = (request.PageIndex - 1) * request.PageSize;
            var query = await selectedEmployees
                .Skip(() => resultsToSkip)
                .Take(() => request.PageSize)
                .ToListAsync();

            return new EmployeeListViewModel { SearchRequest = request, Employees = query };
        }
        #endregion


        #region GetEmployeeDetails
        public async Task<EmployeeDetailsViewModel> GetEmployeeDetails(string id)
        {
            var viewModel =
                await
                    Service.Where(a => a.Empno == id)
                        .ProjectTo<EmployeeDetailsViewModel>(MappingEngine)
                        .FirstOrDefaultAsync();

            return viewModel;
        }
        #endregion

    }
}
