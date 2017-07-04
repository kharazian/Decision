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
using Decision.ViewModel.Eblagh;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Eblagh")]
    [Route("{action}")]
    public partial class EblaghController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IEblaghService _eblaghService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public EblaghController(IUnitOfWork unitOfWork, IEblaghService eblaghService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _eblaghService = eblaghService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _eblaghService.GetEblaghAsync(new EblaghSearchRequest
            {
                Empno = empno
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(EblaghSearchRequest request)
        {
            var viewModel = await _eblaghService.GetEblaghAsync(request);
            if (viewModel.Eblaghs == null || !viewModel.Eblaghs.Any()) return Content("no-more-info");
            return PartialView(MVC.Address.Views._ListAjax, viewModel);
        }
        #endregion
    }
}