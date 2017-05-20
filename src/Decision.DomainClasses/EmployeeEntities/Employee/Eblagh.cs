namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Eblagh")]
    public partial class Eblagh
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
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Required]
        [StringLength(4)]
        public string SequenceNo { get; set; }

        [Required]
        [StringLength(8)]
        public string RunDate { get; set; }

        [StringLength(1)]
        public string Permanent { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(4)]
        public string RealPlace { get; set; }

        [StringLength(5)]
        public string SematCod { get; set; }

        [StringLength(1)]
        public string SetadiCod { get; set; }

        public bool? CostCenter { get; set; }

        [StringLength(1)]
        public string EblType { get; set; }

        [StringLength(100)]
        public string EblDes { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual NumberHokm NumberHokm { get; set; }
    }
}
