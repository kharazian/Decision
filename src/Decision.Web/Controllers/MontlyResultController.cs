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
using Decision.ViewModel.MontlyResult;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Pay/MontlyResult")]
    [Route("{action}")]
    public partial class MontlyResultController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMontlyResultService _montlyResultService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public MontlyResultController(IUnitOfWork unitOfWork, IMontlyResultService montlyResultService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _montlyResultService = montlyResultService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _montlyResultService.GetMontlyResultAsync(new MontlyResultSearchRequest
            {
                Empno = empno,
                ResultYear = "",
                ResultMonth = ""
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(MontlyResultSearchRequest request)
        {
            var viewModel = await _montlyResultService.GetMontlyResultAsync(request);
            if (viewModel.MontlyResults == null || !viewModel.MontlyResults.Any()) return Content("no-more-info");
            return PartialView(MVC.MontlyResult.Views._ListAjax, viewModel);
        }
        #endregion

        #region Details
        public virtual async Task<ActionResult> Details(string empno, string resultYear, string resultMonth)
        {
            var viewModel = await _montlyResultService.GetMontlyResultAsync(new MontlyResultSearchRequest
            {
                Empno = empno,
                ResultYear = resultYear,
                ResultMonth = resultMonth
            });
            return PartialView(MVC.MontlyResult.Views._Details, viewModel);
        }
        #endregion
    }
}