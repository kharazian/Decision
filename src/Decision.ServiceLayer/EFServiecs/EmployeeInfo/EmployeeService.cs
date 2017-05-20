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
            var cuser = _userManager.GetCurrentUser();

            if (cuser.UserName == "Admin")
            {
                _unitOfWork.DisableFiltering("Tenant");
            }
            else
            {
                _unitOfWork.EnableFiltering("Tenant", "empno", cuser.Access);
            }
        }
        #endregion

        #region GetPagedList
        public async Task<EmployeeListViewModel> GetPagedListAsync(EmployeeSearchRequest request)
        {
            var employees =
                _employee//.Include(a => a.CreatedBy)
                    //.Include(a => a.ModifiedBy)
                    .AsNoTracking()
                    .AsQueryable();

            //if (request.BirthCertificateNumber.HasValue())
            //    applicants = applicants.Where(a => a.BirthCertificateNumber == request.BirthCertificateNumber).AsQueryable();
            //if (request.NationalCode.HasValue())
            //    applicants = applicants.Where(a => a.NationalCode == request.NationalCode).AsQueryable();
            //if (request.FirstName.HasValue())
            //    applicants = applicants.Where(a => a.FirstName.Contains(request.FirstName)).AsQueryable();
            //if (request.LastName.HasValue())
            //    applicants = applicants.Where(a => a.LastName.Contains(request.LastName)).AsQueryable();

            //if (request.State.HasValue())
            //{
            //    applicants = applicants.Where(a => a.BirthPlaceState == request.State).AsQueryable();
            //    if (request.City.HasValue())
            //        applicants = applicants.Where(a => a.BirthPlaceCity == request.City).AsQueryable();
            //}
            //applicants = applicants.OrderBy($"{request.CurrentSort} {request.SortDirection}");

            //var selectedEmployees = employees.ProjectTo<EmployeeViewModel>(_mappingEngine);
            //var resultsToSkip = (request.PageIndex - 1) * request.PageSize;
            //var query = await selectedEmployees
            //.Skip(() => resultsToSkip)
            //.Take(() => request.PageSize)
            //.ToListAsync();
            //var selectedEmployees = _mappingEngine.Map<List<EmployeeViewModel>>(employees.Take(10));
            //var resultsToSkip = (request.PageIndex - 1) * request.PageSize;
            //var query =  selectedEmployees;

            var selectedEmployees = employees.ProjectTo<EmployeeViewModel>(_mappingEngine);
            var resultsToSkip = (request.PageIndex - 1) * request.PageSize;
            var query = await selectedEmployees
                //.Skip(() => resultsToSkip)
                .Take(() => request.PageSize)
                .ToListAsync();

            return new EmployeeListViewModel { SearchRequest = request, Employees = query };
        }
        #endregion


        #region GetEmployeeDetails
        public async Task<EmployeeDetailsViewModel> GetEmployeeDetails(string id)
        {

            //Employee temp = _employee.Where(x => x.Empno == id).FirstOrDefault();
            //var viewModel = (EmployeeDetailsViewModel)_mappingEngine.Map<EmployeeDetailsViewModel>(temp);
            //var viewModel =
            //    await
            //        _employee.Where(a => a.Empno == id).Include(a => a.CreatedBy)
            //            .Include(a => a.ModifiedBy)
            //            .ProjectTo<EmployeeDetailsViewModel>(_mappingEngine)
            //            .FirstOrDefaultAsync();
            //var viewModel =
            //        await
            //            _employee.Where(a => a.Empno == id)
            //                .ProjectTo<EmployeeDetailsViewModel>(_mappingEngine)
            //                .FirstOrDefaultAsync();
            //var aaa = _employee.Where(a => a.Empno == id);
            //var viewModel1 = aaa.ProjectTo<EmployeeDetailsViewModel>(_mappingEngine);
            //var viewModel = viewModel1.FirstOrDefault();

            var viewModel =
                await
                    _employee.Where(a => a.Empno == id)
                        .ProjectTo<EmployeeDetailsViewModel>(_mappingEngine)
                        .FirstOrDefaultAsync();

            return viewModel;
        }
        #endregion

    }
}
