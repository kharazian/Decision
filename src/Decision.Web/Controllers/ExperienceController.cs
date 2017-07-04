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
using Decision.ViewModel.Experience;
using Decision.Web.Filters;
using MvcSiteMapProvider;
using Decision.Common.Extentions;
using Decision.ServiceLayer.Contracts.Users;

namespace Decision.Web.Controllers
{
    [RoutePrefix("Employee/Experience")]
    [Route("{action}")]
    public partial class ExperienceController : Controller
    {
        #region	Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IExperienceService _experienceService;
        private readonly IApplicationUserManager _userManager;
        #endregion

        #region	Ctor
        public ExperienceController(IUnitOfWork unitOfWork, IExperienceService experienceService, IApplicationUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _experienceService = experienceService;
            _userManager = userManager;

        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{empno}")]
        public virtual async Task<ActionResult> List(string empno)
        {
            var viewModel = await _experienceService.GetExperienceAsync(new ExperienceSearchRequest
            {
                Empno = empno
            });
            return View(viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> ListAjax(ExperienceSearchRequest request)
        {
            var viewModel = await _experienceService.GetExperienceAsync(request);
            if (viewModel.Experiences == null || !viewModel.Experiences.Any()) return Content("no-more-info");
            return PartialView(MVC.Experience.Views._ListAjax, viewModel);
        }
        #endregion
    }
}