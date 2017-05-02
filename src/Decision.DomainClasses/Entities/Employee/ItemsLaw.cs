namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemsLaw")]
    public partial class ItemsLaw
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string LawDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string Code { get; set; }

        [Required]
        [StringLength(1)]
        public string FixTax { get; set; }

        [Required]
        [StringLength(1)]
        public string VarTax { get; set; }

        [Required]
        [StringLength(1)]
        public string Insurance { get; set; }

        [Required]
        [StringLength(1)]
        public string Bazneshastegy { get; set; }

        [Required]
        [StringLength(1)]
        public string CalcUnit { get; set; }

        [Required]
        [StringLength(1)]
        public string KarkerdRelated { get; set; }

        public int? Maximom { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [Required]
        [StringLength(1)]
        public string EmployerTax { get; set; }
    }
}
