namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChartRelPost")]
    public partial class ChartRelPost
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ExePostCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsManagement { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string SematCode { get; set; }

        public int? Num { get; set; }
    }
}
