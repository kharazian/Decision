namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gharardad")]
    public partial class Gharardad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gharardad()
        {
            HokmPaysGharardad = new HashSet<HokmPaysGharardad>();
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
        [StringLength(2)]
        public string GharardadType { get; set; }

        [Required]
        [StringLength(8)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(8)]
        public string EndDate { get; set; }

        [Required]
        [StringLength(2)]
        public string Tabagheh { get; set; }

        public int Sanavat { get; set; }

        [Required]
        [StringLength(5)]
        public string DegreeCod { get; set; }

        [StringLength(4)]
        public string MajorCod { get; set; }

        [Required]
        [StringLength(1)]
        public string CalcBackPay { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        [Required]
        [StringLength(5)]
        public string MarriCod { get; set; }

        public int? NoChild { get; set; }

        [StringLength(600)]
        public string FDsc { get; set; }

        [StringLength(1)]
        public string FirstHokm { get; set; }

        [StringLength(1)]
        public string FamilyProtector { get; set; }

        [StringLength(1)]
        public string StopStat { get; set; }

        [StringLength(1)]
        public string PartTime { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(11)]
        public string PostNumber { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual CodeFile CodeFile1 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual HokmDirector HokmDirector { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }

        public virtual NumberHokm NumberHokm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmPaysGharardad> HokmPaysGharardad { get; set; }
    }
}
