namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmKargary")]
    public partial class HokmKargary : ITenant
    {

        public string HokmYear { get; set; }
        public int Seq { get; set; }
        [Column("EmpNo")]
        public string Empno { get; set; }
        public string SequenceNo { get; set; }
        public string RunDate { get; set; }
        public string Grooh { get; set; }
        public string HokmType { get; set; }
        public int Sanavat { get; set; }
        public string DegreeCod { get; set; }
        public string MajorCod { get; set; }
        public string CalcBackPay { get; set; }
        public string CalcBackPayOld { get; set; }
        public string Permanent { get; set; }
        public string MarriCod { get; set; }
        public int? NoChild { get; set; }
        public string FDsc { get; set; }
        public string FirstHokm { get; set; }
        public string StopStat { get; set; }
        public string PartTime { get; set; }
        public DateTime? CreDat { get; set; }
        public DateTime? UpdDat { get; set; }
        public string OprCod { get; set; }
        public string PostNumber { get; set; }
        public string GroupUp { get; set; }
        public virtual ItemsDsc HokmT { get; set; }
        public virtual CodeFile Degree { get; set; }
        public virtual Major Major { get; set; }
        public virtual CodeFile Married { get; set; }
        public virtual ICollection<HokmPaysKargary> HokmPays { get; set; }

    }
}
