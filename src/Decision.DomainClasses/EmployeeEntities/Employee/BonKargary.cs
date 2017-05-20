namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BonKargary")]
    public partial class BonKargary
    {
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string StartYear { get; set; }

        [Required]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string Season { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Zone Zone { get; set; }
    }
}
