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
using Decision.ViewModel.Hokm;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Hokm")]
    [Route("{action}")]
    public partial class HokmController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IHokmService _hokmService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public HokmController(IUnitOfWork unitOfWork, IHokmService hokmService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _hokmService = hokmService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _hokmService.GetHokmAsync(new HokmSearchRequest
            {
                Empno = empno
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(HokmSearchRequest request)
        {
            var viewModel = await _hokmService.GetHokmAsync(request);
            if (viewModel.Hokms == null || !viewModel.Hokms.Any()) return Content("no-more-info");
            return PartialView(MVC.Hokm.Views._ListAjax, viewModel);
        }
        #endregion
    }
}