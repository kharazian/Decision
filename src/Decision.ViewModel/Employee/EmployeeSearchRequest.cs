using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Decision.ViewModel.Common;
using Decision.DomainClasses.EmployeeEntities;

namespace Decision.ViewModel.Employee
{
    /// <summary>
    /// کلاسی برای کپسوله سازی اطلاعات جستجو و مرتب سازی متقاضی ها
    /// </summary>
    public class EmployeeSearchRequest : BaseSearchRequest
    {
        public EmployeeSearchRequest()
        {
            CurrentSort = ApplicantSortBy.Family;
        }

        [DisplayName("نام")]
        public string Name { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [DisplayName("نام خانوادگی")]
        public string Family { get; set; }
        /// <summary>
        /// کد ملی متقاضی
        /// </summary>
        [DisplayName("کد ملی")]
        public string MelliCode { get; set; }
        /// <summary>
        /// شماره شناسنامه متقاضی
        /// </summary>
        [DisplayName("شماره شناسنامه")]
        public string IdNo { get; set; } 
        /// <summary>
        /// فیلتر بر اساس تأیید شده یا نشده
        /// </summary>
        [DisplayName("وضعیت تأیید")]
        public EmpState  ApplicantApprovalFilter { get; set; }
        /// <summary>
        /// کد پرسنلی
        /// </summary>
        public string PersonnelCode { get; set; }
    }

public static class ApplicantSortBy
    {
        public const string Name = nameof(Name);
        public const string Family = nameof(Family);
    }
}