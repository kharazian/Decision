namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmRasmy")]
    public partial class HokmRasmy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HokmRasmy()
        {
            HokmPaysRasmy = new HashSet<HokmPaysRasmy>();
        }

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
        [StringLength(4)]
        public string HokmType { get; set; }

        [Required]
        [StringLength(5)]
        public string RastehCod { get; set; }

        [Required]
        [StringLength(4)]
        public string ReshtehCod { get; set; }

        [Required]
        [StringLength(5)]
        public string DegreeCod { get; set; }

        [StringLength(4)]
        public string MajorCod { get; set; }

        [Required]
        [StringLength(2)]
        public string Grooh { get; set; }

        [Required]
        [StringLength(2)]
        public string Tabagheh { get; set; }

        [Required]
        [StringLength(6)]
        public string CityPlcCod { get; set; }

        [StringLength(30)]
        public string VillPlcDsc { get; set; }

        [StringLength(30)]
        public string PartPlcDsc { get; set; }

        public int? SanavatOld { get; set; }

        public int Sanavat { get; set; }

        public double SanavatPercent { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        [StringLength(1)]
        public string CalcBackPayOld { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        [Required]
        [StringLength(1)]
        public string FirstHokm { get; set; }

        [Required]
        [StringLength(5)]
        public string MarriCod { get; set; }

        [Required]
        [StringLength(1)]
        public string FamilyProtector { get; set; }

        public int? NoChild { get; set; }

        [Required]
        [StringLength(600)]
        public string FDsc { get; set; }

        [Required]
        [StringLength(1)]
        public string EmpState { get; set; }

        [Required]
        [StringLength(1)]
        public string StopStat { get; set; }

        [Required]
        [StringLength(1)]
        public string PartTime { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(11)]
        public string PostNumber { get; set; }

        [StringLength(1)]
        public string GroupTashvighy { get; set; }

        [Column(TypeName = "money")]
        public decimal? GTatbigh { get; set; }

        [Column(TypeName = "money")]
        public decimal? BTatbigh { get; set; }

        public float? APercentBasij { get; set; }

        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(6)]
        public string Id { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual CodeFile CodeFile1 { get; set; }

        public virtual CodeFile CodeFile2 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual HokmDirector HokmDirector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmPaysRasmy> HokmPaysRasmy { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }

        public virtual ItemsDsc ItemsDsc1 { get; set; }

        public virtual JobDsc JobDsc { get; set; }

        public virtual NumberHokm NumberHokm { get; set; }

        public virtual Place Place { get; set; }
    }
}
