namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SibaDisk")]
    public partial class SibaDisk
    {
        [Required]
        [StringLength(4)]
        public string SibaYear { get; set; }

        [Required]
        [StringLength(2)]
        public string SibaMonth { get; set; }

        [Required]
        [StringLength(13)]
        public string OrganCod { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Required]
        [StringLength(4)]
        public string BranchCod { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SibaSeq { get; set; }

        [Required]
        [StringLength(2)]
        public string BankCod { get; set; }

        [Required]
        [StringLength(10)]
        public string RunDate { get; set; }

        [Required]
        [StringLength(1)]
        public string PayType { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }
    }
}
