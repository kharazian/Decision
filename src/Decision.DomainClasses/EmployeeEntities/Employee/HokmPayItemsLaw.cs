namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmPayItemsLaw")]
    public partial class HokmPayItemsLaw
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string LawDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string PayCod { get; set; }

        [Column(TypeName = "money")]
        public decimal? AmountMarrid { get; set; }

        [Column(TypeName = "money")]
        public decimal? AmountSingle { get; set; }

        [Required]
        [StringLength(1)]
        public string FixTax { get; set; }

        [Required]
        [StringLength(1)]
        public string VarTax { get; set; }

        [Required]
        [StringLength(1)]
        public string Insurance { get; set; }

        [Required]
        [StringLength(1)]
        public string Mogharary { get; set; }

        [Required]
        [StringLength(1)]
        public string Tarmim { get; set; }

        [Required]
        [StringLength(1)]
        public string Bazneshastegy { get; set; }

        public decimal? BasePay { get; set; }

        [Required]
        [StringLength(1)]
        public string DayOrMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? Maximum { get; set; }

        public int HokmItemSeq { get; set; }

        [Required]
        [StringLength(1)]
        public string CalcBackPay { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }
    }
}
