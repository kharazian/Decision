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
using Decision.ViewModel.OtherBime;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/OtherBime")]
    [Route("{action}")]
    public partial class OtherBimeController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtherBimeService _OtherBimeService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public OtherBimeController(IUnitOfWork unitOfWork, IOtherBimeService OtherBimeService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _OtherBimeService = OtherBimeService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _OtherBimeService.GetOtherBimeAsync(new OtherBimeSearchRequest
            {
                Empno = empno,
                BimeDsc = "شخص"
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(OtherBimeSearchRequest request)
        {
            var viewModel = await _OtherBimeService.GetOtherBimeAsync(request);
            if (viewModel.OtherBimes == null || !viewModel.OtherBimes.Any()) return Content("no-more-info");
            return PartialView(MVC.OtherBime.Views._ListAjax, viewModel);
        }
        [HttpGet]
        [Route("ListOther/{empno}")]
        public virtual async Task<ActionResult> ListOther(string empno)
        {
            var viewModel = await _OtherBimeService.GetOtherBimeAsync(new OtherBimeSearchRequest
            {
                Empno = empno,
                BimeDsc = ""
            });
            return View(MVC.OtherBime.Views.List, viewModel);
        }
        #endregion
    }
}