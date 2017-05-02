namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tashvigh")]
    public partial class Tashvigh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string TashvighDate { get; set; }

        [Required]
        [StringLength(300)]
        public string Dsc { get; set; }

        [StringLength(6)]
        public string DirectorEmpNo { get; set; }

        [StringLength(8)]
        public string DirectorPostNo { get; set; }

        [StringLength(5)]
        public string DirectorEmpType { get; set; }

        [StringLength(20)]
        public string PostDsc { get; set; }

        [StringLength(5)]
        public string ComiteeType { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual PostNumbers PostNumbers { get; set; }
    }
}
