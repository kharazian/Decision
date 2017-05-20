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
            CurrentSort = SortByMode.CreatedOn;
        }

        [DisplayName("نام")]
        public string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        /// <summary>
        /// کد ملی متقاضی
        /// </summary>
        [DisplayName("کد ملی")]
        public string NationalCode { get; set; }
        /// <summary>
        /// شماره شناسنامه متقاضی
        /// </summary>
        [DisplayName("شماره شناسنامه")]
        public string BirthCertificateNumber { get; set; } 
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
        public const string FirstName = nameof(FirstName);
        public const string LastName = nameof(LastName);
    }
}