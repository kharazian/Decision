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
using Decision.ViewModel.MontlyResult;
using EntityFramework.Extensions;

namespace Decision.ServiceLayer.EFServiecs.EmployeeInfo
{
    public class MontlyResultService : BaseService<MontlyResult>, IMontlyResultService
    {


        #region Ctor
        public MontlyResultService(IUnitOfWork unitOfWork, IApplicationUserManager userManager, IMappingEngine mappingEngine): base(unitOfWork, userManager, mappingEngine)
        {
        }
        #endregion

        #region GetAddressesAsync
        public async Task<MontlyResultListViewModel> GetMontlyResultAsync(MontlyResultSearchRequest request)
        {
            return new MontlyResultListViewModel
            {
                MontlyResults = await Service.AsNoTracking()
                    .Where(a => a.Empno == request.Empno && a.PayType=="1" )
                    .ProjectTo<MontlyResultViewModel>(MappingEngine)
                    //.Skip((request.PageIndex - 1) * 5)
                    //.Take(5)
                    .ToListAsync(),
                Request = request
            };
        }

        #endregion
    }
}