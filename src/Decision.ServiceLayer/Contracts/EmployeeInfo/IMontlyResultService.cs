using System;
using System.Threading.Tasks;
using Decision.ViewModel.MontlyResult;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IMontlyResultService
    {
        Task<MontlyResultListViewModel> GetMontlyResultAsync(MontlyResultSearchRequest request);
    }
}
