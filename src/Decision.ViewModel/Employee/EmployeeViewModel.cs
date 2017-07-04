using System;
using Decision.DomainClasses.Entities.ApplicantInfo;
using Decision.ViewModel.Common;
using System.ComponentModel.DataAnnotations;
using Decision.DomainClasses.EmployeeEntities;

namespace Decision.ViewModel.Employee
{
    public class EmployeeViewModel 
    {
        #region properties
        [Key]
        public string Empno { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FatherName { get; set; }
        public string LastFamily { get; set; }
        public string IdNo { get; set; }
        public string IdNoContinued { get; set; }
        public string BirthDate { get; set; }
        public string SexCod { get; set; }
        public string MostakhdemNo { get; set; }
        public string BirthCity { get; set; }
        public string IssueCity { get; set; }
        public string EmpType { get; set; }
        public string Unit { get; set; }
        public string GovEmpDate { get; set; }
        public string ManEmpDate { get; set; }
        public string SanavatHokm { get; set; }
        public string SanavatHoghogh { get; set; }
        public string SematCod { get; set; }
        public string MelliCode { get; set; }
        public string MarriageDsc { get; set; }
        public string MarriDate { get; set; }
        public int? NoChild { get; set; }
        public string ReligionDsc { get; set; }
        public string NationalDsc { get; set; }
        public string TelNo { get; set; }
        public string Mobile { get; set; }
        public string MainTelNo { get; set; }
        public string ZipNo { get; set; }
        public string Email { get; set; }
        public string NezStatDsc { get; set; }
        public string Addr { get; set; }
        public string LDegreeDsc { get; set; }
        public string LMajorDsc { get; set; }
        public string StopStat { get; set; }
        public EmpState StopStatE { get
            {
                try
                {
                    return (EmpState)Enum.Parse(typeof(EmpState), StopStat);
                }
                catch (Exception)
                {
                    return EmpState.None;
                }
            }
            
        }
        public string Acc { get; set; }
        public string InsTypeDsc { get; set; }
        public string InsNo { get; set; }
        public string BloodDsc { get; set; }
        public string HealthDsc { get; set; }
        public string HouseDsc { get; set; }
        public byte[] Photo { get; set; }
        public string LPostEblagh { get; set; }
        //public string EmpState { get; set; }
        public string zonecode { get; set; }
        public string RealPlace { get; set; }
        #endregion
    }
}