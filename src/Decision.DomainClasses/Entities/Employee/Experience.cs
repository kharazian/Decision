namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Experience")]
    public partial class Experience
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(8)]
        public string EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PlcDsc { get; set; }

        [StringLength(5)]
        public string DegreeCod { get; set; }

        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(4)]
        public string JobCod { get; set; }

        [StringLength(5)]
        public string BazType { get; set; }

        [StringLength(30)]
        public string ResonChange { get; set; }

        [Required]
        [StringLength(1)]
        public string OkCod { get; set; }

        [Required]
        [StringLength(1)]
        public string OkCod2 { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(10)]
        public string HokmNumber { get; set; }

        [StringLength(8)]
        public string IssueDate { get; set; }

        [StringLength(50)]
        public string JobDsc { get; set; }
    }
}
