namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string ActiveYear { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ActiveMonth { get; set; }

        public short HowMany { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(1)]
        public string Calck { get; set; }

        [StringLength(1)]
        public string CalckOld { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }
    }
}
