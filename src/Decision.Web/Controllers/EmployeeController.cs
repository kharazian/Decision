using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Decision.Common.Extentions;
using Decision.Common.Filters;
using Decision.Common.Helpers;
using Decision.DataLayer.Context;
using Decision.ServiceLayer.Contracts.Common;
using Decision.ServiceLayer.Contracts.Employee;
using Decision.ServiceLayer.Contracts.Users;
using Decision.ViewModel.Applicant;
using Decision.Web.Filters;
using MvcSiteMapProvider.Web.Mvc.Filters;
using Auth = Decision.ServiceLayer.Security.AssignableToRolePermissions;


namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Manage")]
    [Route("{action}")]
    public class EmployeeController : Controller
    {
	    #region	Fields
	    private readonly IUnitOfWork _unitOfWork;
		private readonly IEmployeeService _EmployeeService;
	    #endregion 

		#region	Ctor
		public EmployeeController(IUnitOfWork unitOfWork,IEmployeeService EmployeeService){
		_unitOfWork=unitOfWork;
		_EmployeeService=EmployeeService;
		}
		#endregion 

        #region Details
        [HttpGet]
        [Mvc5Authorize(Auth.CanViewApplicantDetails)]
        [Route("Details/{EmployeeId}")]

        [SiteMapTitle("FullName", Target = AttributeTarget.CurrentNode)]
        public virtual async Task<ActionResult> Details(String employeeId)
        {
            var viewModel = await _EmployeeService.GetEmployeeDetails(employeeId);
            if (viewModel == null) return HttpNotFound();
            return View(viewModel);
        }
        #endregion

        public virtual async Task<ActionResult> GetEmployeeFile(String EmpNo, string type)
        {
            var file = new byte[10]; ;// await _applicantService.GetApplicantDocument(applicantId, type);
            return File(file, "image/png", $"{EmpNo}.png");
        }

    }
}
