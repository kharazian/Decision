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
            var montlyResults = 
                Service//.Include(a => a.CreatedBy)
                   .AsNoTracking()
                   .AsQueryable();

            if (request.Empno != string.Empty)
                montlyResults = montlyResults.Where(a => a.Empno == request.Empno).AsQueryable();
            if (request.ResultYear != string.Empty)
                montlyResults = montlyResults.Where(a => a.ResultYear == request.ResultYear).AsQueryable();
            if (request.ResultMonth != string.Empty)
                montlyResults = montlyResults.Where(a => a.ResultMonth.Contains(request.ResultMonth)).AsQueryable();

            //applicants = applicants.OrderBy($"{request.CurrentSort} {request.SortDirection}");
            montlyResults = montlyResults.OrderBy(a => new { a.Empno, a.ResultYear, a.ResultMonth });

            var selectedmontlyResults = montlyResults.ProjectTo<MontlyResultViewModel>(MappingEngine);
            var resultsToSkip = (request.PageIndex - 1) * request.PageSize;
            var query = await selectedmontlyResults
                //.Skip(() => resultsToSkip)
                //.Take(() => request.PageSize)
                .ToListAsync();

            return new MontlyResultListViewModel { Request = request, MontlyResults = query };
        }

        #endregion
    }
}