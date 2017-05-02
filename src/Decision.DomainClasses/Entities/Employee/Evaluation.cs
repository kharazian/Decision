namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Evaluation")]
    public partial class Evaluation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string EvaluationYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string EvaluationMon { get; set; }

        [StringLength(2)]
        public string EvaluationGroup { get; set; }

        public float? Evaluation360 { get; set; }

        public float? EvaluationSum { get; set; }

        public float? SanavatPercent { get; set; }

        [StringLength(2)]
        public string UpCod { get; set; }

        [StringLength(8)]
        public string EvaluationDate { get; set; }

        [StringLength(5)]
        public string TashvighGroup { get; set; }

        [StringLength(8)]
        public string TashvighDate { get; set; }

        public int? TashvighCount { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
