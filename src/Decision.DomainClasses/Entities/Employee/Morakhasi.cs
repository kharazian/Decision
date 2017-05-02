namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Morakhasi")]
    public partial class Morakhasi
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

        [StringLength(8)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(5)]
        public string MorakhasiCod { get; set; }

        [StringLength(6)]
        public string DirectorEmpNo { get; set; }

        [StringLength(8)]
        public string EndDate { get; set; }

        public int DayNo { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        [StringLength(1)]
        public string CalcBackPayOld { get; set; }

        [StringLength(1)]
        public string Permanent { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual NumberHokm NumberHokm { get; set; }
    }
}
