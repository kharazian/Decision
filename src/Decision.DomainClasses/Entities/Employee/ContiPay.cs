namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContiPay")]
    public partial class ContiPay
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string StartYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string StartMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string PayCod { get; set; }

        [StringLength(4)]
        public string EndYear { get; set; }

        [StringLength(2)]
        public string EndMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [StringLength(1)]
        public string Calck { get; set; }

        [StringLength(1)]
        public string CalckOld { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(1)]
        public string permanent { get; set; }

        [StringLength(150)]
        public string Des { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }
    }
}
