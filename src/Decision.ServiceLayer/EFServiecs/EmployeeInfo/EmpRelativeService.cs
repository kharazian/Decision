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
    public class EmpRelativeService : BaseService<EmpRelative>, IEmpRelativeService
    {


        #region Ctor
        public EmpRelativeService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine): base(unitOfWork, userManager, mappingEngine)
        {
        }
        #endregion

        #region GetAddressesAsync
        public async Task<EmpRelativeListViewModel> GetRelativeAsync(EmpRelativeSearchRequest request)
        {
            var t = Service.AsNoTracking().Include(a => a.Bimes).Where(a => a.Empno == request.Empno).ProjectTo<EmpRelativeViewModel>(MappingEngine);
            return new EmpRelativeListViewModel
            {
                Relatives = await Service.AsNoTracking()
                    .Include(a => a.Bimes)
                    .Where(a => a.Empno == request.Empno)                    
                    .ProjectTo<EmpRelativeViewModel>(MappingEngine)
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