namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mamoriat")]
    public partial class Mamoriat
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
        [StringLength(8)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(4)]
        public string SequenceNo { get; set; }

        [Required]
        [StringLength(5)]
        public string MamTypeCod { get; set; }

        [Required]
        [StringLength(1)]
        public string InOutCountryCod { get; set; }

        [Required]
        [StringLength(30)]
        public string Target { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(8)]
        public string EndDate { get; set; }

        [StringLength(5)]
        public string VehicleCod { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        [StringLength(40)]
        public string VehicleDes { get; set; }

        [StringLength(100)]
        public string MamorDes { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        [StringLength(1)]
        public string CalcBackPayOld { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual CodeFile CodeFile1 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual HokmDirector HokmDirector { get; set; }

        public virtual NumberHokm NumberHokm { get; set; }
    }
}
