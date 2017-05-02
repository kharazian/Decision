namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExePostNumber")]
    public partial class ExePostNumber
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string SematCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string PostCode { get; set; }

        [StringLength(100)]
        public string POstDsc { get; set; }

        [StringLength(8)]
        public string KargarPostNo { get; set; }

        [StringLength(50)]
        public string KargarDsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public bool? AutoPros { get; set; }

        [StringLength(1)]
        public string EvalPost { get; set; }

        public bool? Show { get; set; }
    }
}
