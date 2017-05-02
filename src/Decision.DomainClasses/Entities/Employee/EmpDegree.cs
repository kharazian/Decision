namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpDegree")]
    public partial class EmpDegree
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string DegreeCod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string DegreeDate { get; set; }

        [Required]
        [StringLength(8)]
        public string StartDate { get; set; }

        [StringLength(8)]
        public string EndDate { get; set; }

        [StringLength(4)]
        public string MajorCod { get; set; }

        [StringLength(30)]
        public string MinorDsc { get; set; }

        [StringLength(5)]
        public string CntyCod { get; set; }

        [StringLength(30)]
        public string SchoolOldNam { get; set; }

        public float Gpa1 { get; set; }

        public int? SchoolNam { get; set; }

        public bool? GetDegree { get; set; }

        [StringLength(1)]
        public string Gpa2 { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }
    }
}
