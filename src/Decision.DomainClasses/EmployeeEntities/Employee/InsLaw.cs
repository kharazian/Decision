namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsLaw")]
    public partial class InsLaw
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
        [StringLength(5)]
        public string InsType { get; set; }

        public float EmpShare { get; set; }

        public float? BossShare1 { get; set; }

        public float? BossShare2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Limit { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        [Required]
        [StringLength(1)]
        public string PriceOrPercent { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual CodeFile CodeFile1 { get; set; }
    }
}
