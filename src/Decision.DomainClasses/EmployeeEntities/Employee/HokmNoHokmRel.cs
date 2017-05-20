namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmNoHokmRel")]
    public partial class HokmNoHokmRel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string LawDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string NoHokmCod { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string HokmPayCod { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        public float PercentMulty { get; set; }

        public float PercentDivide { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }

        public virtual ItemsDsc ItemsDsc1 { get; set; }
    }
}
