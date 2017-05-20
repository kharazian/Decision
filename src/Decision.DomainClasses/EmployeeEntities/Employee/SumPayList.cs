namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SumPayList")]
    public partial class SumPayList
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string FinYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string FinMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Column(TypeName = "money")]
        public decimal? Hoghogh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Shoghl { get; set; }

        [Column(TypeName = "money")]
        public decimal? Jazb { get; set; }

        [Column(TypeName = "money")]
        public decimal? Place { get; set; }

        [Column(TypeName = "money")]
        public decimal? AelehOlad { get; set; }

        [Column(TypeName = "money")]
        public decimal? Masheghat { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tatbigh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Nobatkari { get; set; }

        [Column(TypeName = "money")]
        public decimal? TashvighDgr { get; set; }

        [Column(TypeName = "money")]
        public decimal? Naghdi { get; set; }

        [Column(TypeName = "money")]
        public decimal? Maskan { get; set; }

        [Column(TypeName = "money")]
        public decimal? Jebheh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tarmim { get; set; }

        [Column(TypeName = "money")]
        public decimal? EzafeKar { get; set; }

        [Column(TypeName = "money")]
        public decimal? TatilKari { get; set; }

        [Column(TypeName = "money")]
        public decimal? Padash { get; set; }

        [Column(TypeName = "money")]
        public decimal? PadashNet { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaneh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sarparasti { get; set; }

        [Column(TypeName = "money")]
        public decimal? Mamoriat { get; set; }

        [Column(TypeName = "money")]
        public decimal? Jalaseh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sham { get; set; }

        [Column(TypeName = "money")]
        public decimal? CashKasr { get; set; }

        [Column(TypeName = "money")]
        public decimal? Traffick { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaie { get; set; }

        [Column(TypeName = "money")]
        public decimal? Mosaedat { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShabKari { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZohrKari { get; set; }

        [Column(TypeName = "money")]
        public decimal? Shir { get; set; }

        [Column(TypeName = "money")]
        public decimal? TarmimHoghogh { get; set; }

        [Column(TypeName = "money")]
        public decimal? HazinehMaskan { get; set; }

        [Column(TypeName = "money")]
        public decimal? FoghVisheh { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherPay { get; set; }

        [Column(TypeName = "money")]
        public decimal? Vabasteh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Dolati { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax { get; set; }

        [Column(TypeName = "money")]
        public decimal? GharsLoan { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bime { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeBossSpec { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeBossSpecEmployeer { get; set; }

        [Column(TypeName = "money")]
        public decimal? Mogharari { get; set; }

        [Column(TypeName = "money")]
        public decimal? Darmani1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Darmani2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Darmani3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DarmaniBoss1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DarmaniBoss2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DarmaniBoss3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeLife { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeLifeBoss { get; set; }

        [Column(TypeName = "money")]
        public decimal? Saving { get; set; }

        [Column(TypeName = "money")]
        public decimal? Takhir { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixSaving { get; set; }

        [Column(TypeName = "money")]
        public decimal? Khazaneh { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherBime { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherKasr { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxBoss { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeBoss1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeBossEmployeer { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeBoss2 { get; set; }

        [Required]
        [StringLength(1)]
        public string Etebar { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixPasandaz { get; set; }

        [Column(TypeName = "money")]
        public decimal? KaranehManage { get; set; }

        [Column(TypeName = "money")]
        public decimal? HaghAlZahmeh { get; set; }

        [Column(TypeName = "money")]
        public decimal? Keshik { get; set; }

        [Column(TypeName = "money")]
        public decimal? HazinehTel { get; set; }

        [Column(TypeName = "money")]
        public decimal? BimeKarfarma4P { get; set; }

        [Required]
        [StringLength(1)]
        public string PayList { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(8)]
        public string RunDate { get; set; }
    }
}
