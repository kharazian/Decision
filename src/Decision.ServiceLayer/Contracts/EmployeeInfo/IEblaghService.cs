using System;
using System.Threading.Tasks;
using Decision.ViewModel.Eblagh;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IEblaghService
    {
        Task<EblaghListViewModel> GetEblaghAsync(EblaghSearchRequest request);
    }
}
