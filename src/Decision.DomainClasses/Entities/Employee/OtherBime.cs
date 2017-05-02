namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherBime")]
    public partial class OtherBime
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string RelTypeCod { get; set; }

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
        public string StartYear { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string StartMonth { get; set; }

        [StringLength(4)]
        public string EndYear { get; set; }

        [StringLength(2)]
        public string EndMonth { get; set; }

        [StringLength(12)]
        public string InsNo { get; set; }

        [Required]
        [StringLength(1)]
        public string Calck { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual CodeFile CodeFile1 { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
