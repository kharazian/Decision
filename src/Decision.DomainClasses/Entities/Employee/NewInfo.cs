namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewInfo")]
    public partial class NewInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Years { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Mont { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Required]
        [StringLength(2)]
        public string PayType { get; set; }

        [StringLength(5)]
        public string SematCod { get; set; }

        [StringLength(5)]
        public string LDegreeCod { get; set; }

        [StringLength(12)]
        public string LPostNoEblagh { get; set; }

        public float? DaySanavat { get; set; }

        public int? YearSanavat { get; set; }

        public int? EmployeeYearSanavat { get; set; }

        public int? NewYearSanavat { get; set; }

        public decimal? Ehraz { get; set; }

        [StringLength(1)]
        public string JobGroup { get; set; }

        public int? FormulRow { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewBasePay { get; set; }

        [Column(TypeName = "money")]
        public decimal? SpecialJob { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumBasePayJob { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumItemHokm { get; set; }

        [Column(TypeName = "money")]
        public decimal? Difference { get; set; }

        [Column(TypeName = "money")]
        public decimal? Old3555 { get; set; }

        [Column(TypeName = "money")]
        public decimal? New3555 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Old3556 { get; set; }

        [Column(TypeName = "money")]
        public decimal? New3556 { get; set; }

        [Column(TypeName = "money")]
        public decimal? New3004 { get; set; }

        [Column(TypeName = "money")]
        public decimal? OLd3004 { get; set; }

        [StringLength(5)]
        public string Emptype { get; set; }

        [StringLength(1)]
        public string backup { get; set; }

        [StringLength(5)]
        public string Type { get; set; }

        [StringLength(1)]
        public string Activate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaee301203 { get; set; }

        public float? Code3001 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayCode3001 { get; set; }

        public float? Code3002 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayCode3002 { get; set; }

        public float? Code300102 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayCode300102 { get; set; }

        public float? Code300103 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayCode300103 { get; set; }

        public float? Code3003 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayCode3003 { get; set; }

        [Column(TypeName = "money")]
        public decimal? MangKara3029 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaee3012 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaee301202 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Aele { get; set; }

        [StringLength(4)]
        public string unit { get; set; }
    }
}
