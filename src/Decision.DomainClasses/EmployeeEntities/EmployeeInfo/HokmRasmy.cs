namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmRasmy")]
    public partial class HokmRasmy : ITenant
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        [Column("EmpNo")]
        public string Empno { get; set; }
        public string SequenceNo { get; set; }
        public string RunDate { get; set; }
        public string HokmType { get; set; }
        public string RastehCod { get; set; }
        public string ReshtehCod { get; set; }
        public string DegreeCod { get; set; }
        public string MajorCod { get; set; }
        public string Grooh { get; set; }
        public string Tabagheh { get; set; }
        public string CityPlcCod { get; set; }
        public string VillPlcDsc { get; set; }
        public string PartPlcDsc { get; set; }
        public int? SanavatOld { get; set; }
        public int Sanavat { get; set; }
        public double SanavatPercent { get; set; }
        public string CalcBackPay { get; set; }
        public string CalcBackPayOld { get; set; }
        public string Permanent { get; set; }
        public string FirstHokm { get; set; }
        public string MarriCod { get; set; }
        public string FamilyProtector { get; set; }
        public int? NoChild { get; set; }
        public string FDsc { get; set; }
        public string EmpState { get; set; }
        public string StopStat { get; set; }
        public string PartTime { get; set; }
        public DateTime? CreDat { get; set; }
        public DateTime? UpdDat { get; set; }
        public string OprCod { get; set; }
        public string PostNumber { get; set; }
        public string GroupTashvighy { get; set; }
        public decimal? GTatbigh { get; set; }
        public decimal? BTatbigh { get; set; }
        public float? APercentBasij { get; set; }
        public string EmpType { get; set; }
        public string Id { get; set; }

        public virtual ItemsDsc HokmT { get; set; }
        public virtual CodeFile Rasteh { get; set; }
        public virtual JobDsc Reshteh { get; set; }
        public virtual CodeFile Degree { get; set; }
        public virtual Major Major { get; set; }
        public virtual CodeFile Married { get; set; }
        public virtual ICollection<HokmPaysRasmy> HokmPays { get; set; }
    }
}
