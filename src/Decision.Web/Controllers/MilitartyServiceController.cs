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
using Decision.ViewModel.EmpMilitary;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Militarty")]
    [Route("{action}")]
    public partial class MilitartyServiceController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMilitaryServiceService _militartyService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public MilitartyServiceController(IUnitOfWork unitOfWork, IMilitaryServiceService militartyService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _militartyService = militartyService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _militartyService.GetMilitaryAsync(new MilitaryServiceSearchRequest
            {
                Empno = empno
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(MilitaryServiceSearchRequest request)
        {
            var viewModel = await _militartyService.GetMilitaryAsync(request);
            if (viewModel.Militaries == null || !viewModel.Militaries.Any()) return Content("no-more-info");
            return PartialView(MVC.MilitartyService.Views._ListAjax, viewModel);
        }
        #endregion
    }
}