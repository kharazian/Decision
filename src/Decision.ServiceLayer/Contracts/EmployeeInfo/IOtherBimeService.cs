using System;
using System.Threading.Tasks;
using Decision.ViewModel.OtherBime;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IOtherBimeService
    {
        Task<OtherBimeListViewModel> GetOtherBimeAsync(OtherBimeSearchRequest request);
    }
}
