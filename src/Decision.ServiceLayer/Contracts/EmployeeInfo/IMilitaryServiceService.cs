using System;
using System.Threading.Tasks;
using Decision.ViewModel.EmpMilitary;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IMilitaryServiceService
    {
        Task<MilitaryServiceListViewModel> GetMilitaryAsync(MilitaryServiceSearchRequest request);
    }
}
