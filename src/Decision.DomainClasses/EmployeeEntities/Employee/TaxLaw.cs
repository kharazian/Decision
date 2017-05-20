namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxLaw")]
    public partial class TaxLaw
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string StartDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string TaxTypeCod { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal TaxMin { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxMax { get; set; }

        public float TaxPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxPrice { get; set; }

        [Required]
        [StringLength(1)]
        public string CalcBackPay { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }
    }
}
