using System;
using System.Threading.Tasks;
using Decision.ViewModel.EmpRelative;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IEmpRelativeService
    {
        Task<EmpRelativeListViewModel> GetRelativeAsync(EmpRelativeSearchRequest request);
    }
}
