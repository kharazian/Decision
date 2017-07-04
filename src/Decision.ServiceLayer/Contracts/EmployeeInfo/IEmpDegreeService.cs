using System;
using System.Threading.Tasks;
using Decision.ViewModel.EmpDegree;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IEmpDegreeService
    {
        Task<EmpDegreeListViewModel> GetEmpDegreeAsync(EmpDegreeSearchRequest request);
    }
}
