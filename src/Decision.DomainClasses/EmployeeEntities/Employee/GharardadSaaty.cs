namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GharardadSaaty")]
    public partial class GharardadSaaty
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

        [Required]
        [StringLength(8)]
        public string EndDate { get; set; }

        [Required]
        [StringLength(4)]
        public string HokmType { get; set; }

        [Column(TypeName = "money")]
        public decimal BasePay { get; set; }

        public int MaxHour { get; set; }

        public int? PerMaxHour { get; set; }

        [Required]
        [StringLength(5)]
        public string DegreeCod { get; set; }

        [StringLength(4)]
        public string MajorCod { get; set; }

        [Required]
        [StringLength(1)]
        public string TaxTypeCod { get; set; }

        [Required]
        [StringLength(1)]
        public string InsTypeCod { get; set; }

        [Column(TypeName = "money")]
        public decimal? EachHourPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? EachDayMamPrice { get; set; }

        [Required]
        [StringLength(1)]
        public string PartTimeCod { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        [Required]
        [StringLength(1)]
        public string CalcBackPay { get; set; }

        [StringLength(600)]
        public string FDsc { get; set; }

        [Required]
        [StringLength(1)]
        public string StopStat { get; set; }

        [StringLength(1)]
        public string FirstHokm { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [Required]
        [StringLength(1)]
        public string BaseTag { get; set; }

        [Required]
        [StringLength(1)]
        public string Tarabary { get; set; }

        [StringLength(600)]
        public string DscBase { get; set; }
    }
}
