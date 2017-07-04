using System;
using System.Threading.Tasks;
using Decision.ViewModel.Experience;

namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IExperienceService
    {
        Task<ExperienceListViewModel> GetExperienceAsync(ExperienceSearchRequest request);
    }
}
