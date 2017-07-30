using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.MontlyResult
{
    public class MontlyResultViewModel
    {
        public string Empno { get; set; }
        public string ResultYear { get; set; }
        public string ResultMonth { get; set; }
        public int seq { get; set; }
        public string HokmYear { get; set; }
        public int HokmSeq { get; set; }
        public string Unit { get; set; }
        public string MamorCod { get; set; }
        public string PayType { get; set; }
        public string RunDate { get; set; }
        public string Calck { get; set; }
        public string EmpType { get; set; }
        public int? CurrMonthActivity { get; set; }
        public decimal? BazTotal { get; set; }
        public decimal? InsTotal { get; set; }
        public decimal? FixTaxTotal { get; set; }
        public decimal? VarTaxTotal { get; set; }
        public string AccNo { get; set; }
        public string BankCod { get; set; }
        public string BranchCod { get; set; }
        public decimal SumDeduct { get; set; }
        public decimal SumPay { get; set; }
        public string EmpState { get; set; }
        public string StopStat { get; set; }
        public string PartTime { get; set; }
        public string HokmNoHokmRelDate { get; set; }
        public string ItemsLawDate { get; set; }
        public string InsLawDate { get; set; }
        public string FixTaxLawDate { get; set; }
        public string VarTaxLawDate { get; set; }
        public decimal EmployerTaxTotal { get; set; }
        public string EmployerTaxLawDate { get; set; }
        public string SibaPay { get; set; }
        public string OrganCod { get; set; }
        public string OrganCodSh { get; set; }
        public string AccNoSh { get; set; }
        public string BankCodSh { get; set; }
        public string BranchCodSh { get; set; }
    }
}
