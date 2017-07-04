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
using Decision.ViewModel.OtherBime;
using EntityFramework.Extensions;

namespace Decision.ServiceLayer.EFServiecs.EmployeeInfo
{
    public class OtherBimeService : BaseService<OtherBime>, IOtherBimeService
    {


        #region Ctor
        public OtherBimeService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine): base(unitOfWork, userManager, mappingEngine)
        {
        }
        #endregion

        #region GetAddressesAsync
        public async Task<OtherBimeListViewModel> GetOtherBimeAsync(OtherBimeSearchRequest request)
        {
            return new OtherBimeListViewModel
            {
                
                OtherBimes = await Service.AsNoTracking()
                    .Where(a => a.Empno == request.Empno)                    
                    .ProjectTo<OtherBimeViewModel>(MappingEngine)
                    .Where(a => (request.BimeDsc == "شخص" && a.RelTypeCod=="REL01") || (request.BimeDsc=="" && a.RelTypeCod != "REL01"))
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