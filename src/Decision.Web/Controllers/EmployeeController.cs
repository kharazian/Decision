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
using Decision.ServiceLayer.Contracts.EmployeeInfo;
using Decision.ServiceLayer.Contracts.Users;
using Decision.ViewModel.Employee;
using Decision.Web.Filters;
using MvcSiteMapProvider.Web.Mvc.Filters;
using Auth = Decision.ServiceLayer.Security.AssignableToRolePermissions;


namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Manage")]
    [Route("{action}")]
    public partial class EmployeeController : Controller
    {
        #region	Fields
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeService _EmployeeService;
        #endregion

        #region	Ctor
        public EmployeeController(IUnitOfWork unitOfWork, IEmployeeService EmployeeService)
        {
            _unitOfWork = unitOfWork;
            _EmployeeService = EmployeeService;
        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Activity(Description = "مشاهده لیست کارکنان")]
        [Mvc5Authorize(Auth.CanViewApplicantList)]
        public virtual async Task<ActionResult> List()
        {
            var viewModel = await _EmployeeService.GetPagedListAsync(new EmployeeSearchRequest());
            return View(viewModel);
        }
        //[CheckReferrer]
        [AjaxOnly]
        [HttpPost]
        [Mvc5Authorize(Auth.CanViewApplicantList)]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true, Duration = 0)]
        public virtual async Task<ActionResult> ListAjax(EmployeeSearchRequest request)
        {
            var viewModel = await _EmployeeService.GetPagedListAsync(request);
            if (viewModel.Employees == null || !viewModel.Employees.Any()) return Content("no-more-info");
            return PartialView(MVC.Applicant.Views._ListAjax, viewModel);
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
