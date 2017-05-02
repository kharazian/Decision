using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.Entities.Employee;

namespace Decision.ViewModel.Employee
{
    public class EmployeeDetailsViewModel
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
        public string MarriCod { get; set; }
        public string MarriDate { get; set; }
        public int? NoChild { get; set; }
        public string Religion { get; set; }
        public string NationalCod { get; set; }
        public string TelNo { get; set; }
        public string Mobile { get; set; }
        public string MainTelNo { get; set; }
        public string ZipNo { get; set; }
        public string Email { get; set; }
        public string NezStatCod { get; set; }
        public string Addr { get; set; }
        public string LDegreeCod { get; set; }
        public string LMajorCod { get; set; }

        public int Sanavat { get; set; }
        public EmpState StopStat { get; set; }
        public string PartTime { get; set; }
        public string AccNo { get; set; }
        public string BankNo { get; set; }
        public string BrnchNo { get; set; }
        public string BankSh { get; set; }
        public string BranchSh { get; set; }
        public string InsType { get; set; }
        public string InsNo { get; set; }
        public string BloodCod { get; set; }
        public string HealthCod { get; set; }
        public string BudgetNo { get; set; }
        public string HouseCod { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Signature { get; set; }
        public string SetadiCod { get; set; }
        public float RemMorakhasi { get; set; }
        public decimal LastMogharary { get; set; }
        public string LHokmYear { get; set; }
        public int? LSeq { get; set; }
        public string LPostNoEblagh { get; set; }
        public string LPostNoHokm { get; set; }
        public string LRunDate { get; set; }
        public string HokmType { get; set; }
        public string EmpState { get; set; }
        public string IssueDate { get; set; }
        public string Grooh { get; set; }
        public string BackUp { get; set; }
        public string Type { get; set; }
        public string SanavatDate { get; set; }
        public DateTime? CreDat { get; set; }
        public DateTime? UpdDat { get; set; }
        public string OprCod { get; set; }
        public string zonecode { get; set; }
        public string Sakhtykar { get; set; }
        public double RemMorOldYear { get; set; }
        public string UpdRemMor { get; set; }
        public double? RemMor84 { get; set; }
        public string Siba { get; set; }
        public string AccNoSh { get; set; }
        public string SibaPay { get; set; }
        public string RealPlace { get; set; }
        public string coupleEmpNo { get; set; }
        public string AccNoOld { get; set; }
        public string pass1 { get; set; }
        public string pass2 { get; set; }
        public string Thanks { get; set; }
        public string UnitWithoutCostCenter { get; set; }
        public string EmpnoNew { get; set; }
        #endregion
    }
}
