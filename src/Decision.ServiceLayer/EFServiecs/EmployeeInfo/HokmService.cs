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
using Decision.ViewModel.Hokm;
using EntityFramework.Extensions;

namespace Decision.ServiceLayer.EFServiecs.EmployeeInfo
{
    public class HokmService : BaseService<HokmRasmy>, IHokmService
    {
        IDbSet<HokmKargary> _hokmKargary;
        IDbSet<GharardadSaaty> _gharardadSaaty;
        #region Ctor
        public HokmService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine): base(unitOfWork, userManager, mappingEngine)
        {
            _hokmKargary = unitOfWork.Set<HokmKargary>();
            _gharardadSaaty = unitOfWork.Set<GharardadSaaty>();
        }
        #endregion

        #region GetAddressesAsync
        public async Task<HokmListViewModel> GetHokmAsync(HokmSearchRequest request)
        {
            var allhokm = await Service.AsNoTracking()
                    .Where(a => a.Empno == request.Empno)
                    .ProjectTo<HokmViewModel>(MappingEngine)
                    //.Skip((request.PageIndex - 1) * 5)
                    //.Take(5)
                    .ToListAsync();
            allhokm.AddRange(await _hokmKargary.AsNoTracking()
                    .Where(a => a.Empno == request.Empno)
                    .ProjectTo<HokmViewModel>(MappingEngine)
                    //.Skip((request.PageIndex - 1) * 5)
                    //.Take(5)
                    .ToListAsync());
            allhokm.AddRange(await _gharardadSaaty.AsNoTracking()
                    .Where(a => a.Empno == request.Empno)
                    .ProjectTo<HokmViewModel>(MappingEngine)
                    //.Skip((request.PageIndex - 1) * 5)
                    //.Take(5)
                    .ToListAsync());
            return new HokmListViewModel
            {
                Hokms = allhokm,
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