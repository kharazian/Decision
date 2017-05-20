using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.ViewModel.Employee;



namespace Decision.ServiceLayer.Contracts.EmployeeInfo
{
    public interface IEmployeeService
    {
        Task<EmployeeDetailsViewModel> GetEmployeeDetails(String id);
        Task<EmployeeListViewModel> GetPagedListAsync(EmployeeSearchRequest request);

    }
}
