namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GharardadSaaty")]
    public partial class GharardadSaaty : ITenant
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        [Column("EmpNo")]
        public string Empno { get; set; }
        public string SequenceNo { get; set; }
        public string RunDate { get; set; }
        public string EndDate { get; set; }
        public string HokmType { get; set; }
        public decimal BasePay { get; set; }
        public int MaxHour { get; set; }
        public int? PerMaxHour { get; set; }
        public string DegreeCod { get; set; }
        public string MajorCod { get; set; }
        public string TaxTypeCod { get; set; }
        public string InsTypeCod { get; set; }
        public decimal? EachHourPrice { get; set; }
        public decimal? EachDayMamPrice { get; set; }
        public string PartTimeCod { get; set; }
        public string Permanent { get; set; }
        public string CalcBackPay { get; set; }
        public string FDsc { get; set; }
        public string StopStat { get; set; }
        public string FirstHokm { get; set; }
        public DateTime? CreDat { get; set; }
        public DateTime? UpdDat { get; set; }
        public string OprCod { get; set; }
        public string BaseTag { get; set; }
        public string Tarabary { get; set; }
        public string DscBase { get; set; }
        public virtual ItemsDsc HokmT { get; set; }
        public virtual CodeFile Degree { get; set; }
        public virtual Major Major { get; set; }
        public virtual ICollection<HokmPaysRasmy> HokmPays { get; set; }

    }
}
