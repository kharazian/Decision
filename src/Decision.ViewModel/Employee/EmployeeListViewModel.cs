using System.Collections.Generic;
using System.Web.Mvc;
using Decision.ViewModel.Common;

namespace Decision.ViewModel.Employee
{
    /// <summary>
    /// ویو مدل نمایش لیست متقاضی ها
    /// </summary>
    public class EmployeeListViewModel
    {
        public EmployeeListViewModel()
        {
            #region SortOrderList
            SortOrderList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = SortDirectionMode.Desc,
                    Text = "نزولی"
                    
                }
                ,
                new SelectListItem
                {
                    Value = SortDirectionMode.Asc,
                    Text = "صعودی"
                }
            };
            #endregion

            #region SortableList

            SortableList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = ApplicantSortBy.Family,
                    Text = "نام خانوادگی"
                },                new SelectListItem
                {
                    Value = ApplicantSortBy.Name,
                    Text = "نام"
                },
                new SelectListItem
                {
                    Value = SortByMode.CreatedOn,
                    Text = "تاریخ درج"
                },
                new SelectListItem
                {
                    Value = SortByMode.ModifiedOn,
                    Text = "تاریخ آخرین تغییر"
                }
            };

            #endregion

            #region PageSizeList

            PageSizeList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "10",
                    Text = "۱۰"
                },
                new SelectListItem
                {
                    Value = "20",
                    Text = "۲۰"
                },
                new SelectListItem
                {
                    Value = "30",
                    Text = "۳۰"
                },
                new SelectListItem
                {
                    Value = "50",
                    Text = "۵۰"
                },
                new SelectListItem
                {
                    Value = "100",
                    Text = "۱۰۰"
                }
            };

            #endregion

        }

        /// <summary>
        /// اطلاعات جستجو و مرتب سازی
        /// </summary>
        public EmployeeSearchRequest SearchRequest { get; set; }

        /// <summary>
        /// لیست ویو مدل نمایش متقاضی
        /// </summary>
        public IEnumerable<EmployeeViewModel> Employees { get; set; }

       
        /// <summary>
        /// لیست فیلد هایی که برای مرتب سازی استفاده  خواهند شد
        /// </summary>
        public IEnumerable<SelectListItem> SortableList { get; set; }
        /// <summary>
        /// لیست 
        /// </summary>
        public IEnumerable<SelectListItem> SortOrderList { get; set; }
        /// <summary>
        /// لیست اعداد برای نمایش در هر صفحه
        /// </summary>
        public IEnumerable<SelectListItem> PageSizeList { get; set; }
    }
}