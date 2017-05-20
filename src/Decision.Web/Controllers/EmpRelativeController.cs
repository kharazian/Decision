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
using Decision.ViewModel.EmpRelative;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Relative")]
    [Route("{action}")]
    public partial class EmpRelativeController : Controller
    {
        #region	Fields

        private const string IranCitiesPath = "~/App_Data/IranCities.xml";
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmpRelativeService _relativeService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public EmpRelativeController(IUnitOfWork unitOfWork, IEmpRelativeService relativeService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _relativeService = relativeService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _relativeService.GetRelativeAsync(new EmpRelativeSearchRequest
            {
                Empno = empno
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(EmpRelativeSearchRequest request)
        {
            var viewModel = await _relativeService.GetRelativeAsync(request);
            if (viewModel.Relatives == null || !viewModel.Relatives.Any()) return Content("no-more-info");
            return PartialView(MVC.Address.Views._ListAjax, viewModel);
        }
        #endregion
    }
}