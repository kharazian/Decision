namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherBimePrice")]
    public partial class OtherBimePrice
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string ReltypeCod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string RelSequence { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string BimeCod { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string ResultYear { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string ResultMonth { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Column(TypeName = "money")]
        public decimal? EmpAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? BossAmount { get; set; }

        [Required]
        [StringLength(1)]
        public string PayType { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
