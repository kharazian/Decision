namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShahdarPay")]
    public partial class ShahdarPay
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ResultYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ResultMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seq { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasePay { get; set; }

        [Column(TypeName = "money")]
        public decimal? AfzSanavat { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoghJob { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoghJazb { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aeleh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Olad { get; set; }

        [Column(TypeName = "money")]
        public decimal? Maskan { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sepordeh { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoghTalash { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoghVijeh { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoghOmran { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaneh { get; set; }

        [Column(TypeName = "money")]
        public decimal? EzafeKar { get; set; }

        [Required]
        [StringLength(4)]
        public string HokmYear { get; set; }

        public int HokmSeq { get; set; }

        [Required]
        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(5)]
        public string MamorCod { get; set; }

        [StringLength(1)]
        public string PayType { get; set; }

        [StringLength(8)]
        public string RunDate { get; set; }

        [StringLength(1)]
        public string Calck { get; set; }

        [Required]
        [StringLength(5)]
        public string EmpType { get; set; }

        public int? CurrMonthActivity { get; set; }

        [Column(TypeName = "money")]
        public decimal? BazTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? InsTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixTaxTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? VarTaxTotal { get; set; }

        [StringLength(13)]
        public string AccNo { get; set; }

        [StringLength(2)]
        public string BankCod { get; set; }

        [StringLength(4)]
        public string BranchCod { get; set; }

        [Column(TypeName = "money")]
        public decimal SumDeduct { get; set; }

        [Column(TypeName = "money")]
        public decimal SumPay { get; set; }

        [StringLength(1)]
        public string EmpState { get; set; }

        [Required]
        [StringLength(1)]
        public string StopStat { get; set; }

        [Required]
        [StringLength(1)]
        public string PartTime { get; set; }

        [StringLength(8)]
        public string HokmNoHokmRelDate { get; set; }

        [StringLength(8)]
        public string ItemsLawDate { get; set; }

        [StringLength(8)]
        public string InsLawDate { get; set; }

        [StringLength(8)]
        public string FixTaxLawDate { get; set; }

        [StringLength(8)]
        public string VarTaxLawDate { get; set; }

        [Column(TypeName = "money")]
        public decimal EmployerTaxTotal { get; set; }

        [StringLength(8)]
        public string EmployerTaxLawDate { get; set; }

        [Required]
        [StringLength(1)]
        public string SibaPay { get; set; }

        [StringLength(4)]
        public string OrganCod { get; set; }

        [StringLength(13)]
        public string OrganCodSh { get; set; }

        [StringLength(15)]
        public string AccNoSh { get; set; }

        [StringLength(2)]
        public string BankCodSh { get; set; }

        [StringLength(4)]
        public string BranchCodSh { get; set; }
    }
}
