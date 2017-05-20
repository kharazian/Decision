namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaceEmp")]
    public partial class PlaceEmp
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string HokmYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Required]
        [StringLength(4)]
        public string Unit { get; set; }

        [Required]
        [StringLength(6)]
        public string Empno { get; set; }

        [Required]
        [StringLength(8)]
        public string RunDate { get; set; }

        [Required]
        [StringLength(8)]
        public string PostNo { get; set; }

        [Required]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Required]
        [StringLength(1)]
        public string TypeCod { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        [StringLength(4)]
        public string RealPlace { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual NumberHokm NumberHokm { get; set; }

        public virtual OrganUnit OrganUnit { get; set; }
    }
}
