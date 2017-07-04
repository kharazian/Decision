using System;
using System.Threading.Tasks;
using Decision.ViewModel.Hokm;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IHokmService
    {
        Task<HokmListViewModel> GetHokmAsync(HokmSearchRequest request);
    }
}
