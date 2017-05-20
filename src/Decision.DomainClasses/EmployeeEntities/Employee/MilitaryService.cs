namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MilitaryService")]
    public partial class MilitaryService
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(8)]
        public string EndDate { get; set; }

        [StringLength(50)]
        public string PlcDsc { get; set; }

        public int? JanBazPercent { get; set; }

        [StringLength(8)]
        public string RunDate { get; set; }

        [StringLength(30)]
        public string LetNo { get; set; }

        [StringLength(70)]
        public string Dsc { get; set; }

        [StringLength(5)]
        public string Groups { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
