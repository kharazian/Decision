namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Refahi")]
    public partial class Refahi
    {
        [Key]
        [Column(Order = 0)]
        public long AutoRow { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Required]
        [StringLength(8)]
        public string SDate { get; set; }

        [Required]
        [StringLength(8)]
        public string EDate { get; set; }

        [Required]
        [StringLength(6)]
        public string MainCode { get; set; }

        [Required]
        [StringLength(6)]
        public string SubCode1 { get; set; }

        [Required]
        [StringLength(6)]
        public string SubCode2 { get; set; }

        [StringLength(255)]
        public string Dsc { get; set; }

        [Column(TypeName = "money")]
        public decimal? ManSahm { get; set; }

        [Column(TypeName = "money")]
        public decimal? PersonSahm { get; set; }

        [StringLength(20)]
        public string PermitNo { get; set; }

        [StringLength(10)]
        public string PermitDate { get; set; }

        [StringLength(20)]
        public string LicenceNo { get; set; }

        [StringLength(8)]
        public string LicenceDate { get; set; }

        [StringLength(1)]
        public string Permanent { get; set; }

        [StringLength(8)]
        public string SabtDate { get; set; }

        public long? TotalValwe { get; set; }

        public float? BossPercent { get; set; }

        public float? EmpPercent { get; set; }

        [StringLength(8)]
        public string LawDate { get; set; }

        public bool? DelTag { get; set; }

        [StringLength(255)]
        public string DelDsc { get; set; }
    }
}
