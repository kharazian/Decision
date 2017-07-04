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
using Decision.ViewModel.EmpMilitary;
using EntityFramework.Extensions;

namespace Decision.ServiceLayer.EFServiecs.EmployeeInfo
{
    public class MilitaryServiceService : BaseService<MilitaryService>, IMilitaryServiceService
    {


        #region Ctor
        public MilitaryServiceService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine): base(unitOfWork, userManager, mappingEngine)
        {
        }
        #endregion

        #region GetAddressesAsync
        public async Task<MilitaryServiceListViewModel> GetMilitaryAsync(MilitaryServiceSearchRequest request)
        {
            return new MilitaryServiceListViewModel
            {
                Militaries = await Service.AsNoTracking()
                    .Where(a => a.Empno == request.Empno)
                    .ProjectTo<MilitaryServiceViewModel>(MappingEngine)
                    .OrderBy(e => e.Empno)
                    .Skip((request.PageIndex - 1) * 5)
                    .Take(5)
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