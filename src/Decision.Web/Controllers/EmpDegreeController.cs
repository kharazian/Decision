using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Decision.Common.Filters;
using Decision.Common.Json;
using Decision.DataLayer.Context;
using Decision.ServiceLayer.Contracts.EmployeeInfo;
using Decision.ServiceLayer.Security;
using Decision.ViewModel.EmpDegree;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/EmpDegree")]
    [Route("{action}")]
    public partial class EmpDegreeController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmpDegreeService _experienceService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public EmpDegreeController(IUnitOfWork unitOfWork, IEmpDegreeService empDegreeService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _experienceService = empDegreeService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _experienceService.GetEmpDegreeAsync(new EmpDegreeSearchRequest
            {
                Empno = empno
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(EmpDegreeSearchRequest request)
        {
            var viewModel = await _experienceService.GetEmpDegreeAsync(request);
            if (viewModel.Degrees == null || !viewModel.Degrees.Any()) return Content("no-more-info");
            return PartialView(MVC.EmpDegree.Views._ListAjax, viewModel);
        }
        #endregion
    }
}