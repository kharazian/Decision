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

namespace Decision.ServiceLayer.EFServiecs.EmployeeInfo
{
    public class EmpRelativeService : IEmpRelativeService
    {
        #region Fields
        private readonly IMappingEngine _mappingEngine;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationUserManager _userManager;
        private readonly IDbSet<EmpRelative> _relative;
        #endregion

        #region Ctor
        public EmpRelativeService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _relative = _unitOfWork.Set<EmpRelative>();
            _mappingEngine = mappingEngine;
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

        #region GetAddressesAsync
        public async Task<EmpRelativeListViewModel> GetRelativeAsync(EmpRelativeSearchRequest request)
        {
            return new EmpRelativeListViewModel
            {
                Relatives = await _relative.AsNoTracking()
                    .Where(a => a.Empno == request.Empno)
                    .ProjectTo<EmpRelativeViewModel>(_mappingEngine)
                    //.Skip((request.PageIndex - 1) * 5)
                    //.Take(5)
                    .ToListAsync(),
                Request = request
            };
        }

        #endregion

        // public Task<AddressViewModel> GetAddressViewModel(Guid guid)
        //{
        //    return
        //        _addresses.AsNoTracking()
        //            .ProjectTo<AddressViewModel>(_mappingEngine)
        //            .FirstOrDefaultAsync(a => a.Id == guid);
        //}
    }
}