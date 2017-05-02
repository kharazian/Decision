namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodeFile")]
    public partial class CodeFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeFile()
        {
            BasePay = new HashSet<BasePay>();
            DegreeTashvigh = new HashSet<DegreeTashvigh>();
            EmpForeignLang = new HashSet<EmpForeignLang>();
            EmpForeignLang1 = new HashSet<EmpForeignLang>();
            EmpRelative = new HashSet<EmpRelative>();
            EmpRelative1 = new HashSet<EmpRelative>();
            EmpRelative2 = new HashSet<EmpRelative>();
            EmpRelative3 = new HashSet<EmpRelative>();
            EmpRelative4 = new HashSet<EmpRelative>();
            EmpRelative5 = new HashSet<EmpRelative>();
            EmpRelative6 = new HashSet<EmpRelative>();
            Gharardad = new HashSet<Gharardad>();
            Gharardad1 = new HashSet<Gharardad>();
            HokmDirector = new HashSet<HokmDirector>();
            HokmDirector1 = new HashSet<HokmDirector>();
            HokmKargary = new HashSet<HokmKargary>();
            HokmKargary1 = new HashSet<HokmKargary>();
            HokmLaw = new HashSet<HokmLaw>();
            HokmNoHokmRel = new HashSet<HokmNoHokmRel>();
            HokmPayItemsLaw = new HashSet<HokmPayItemsLaw>();
            HokmRasmy = new HashSet<HokmRasmy>();
            HokmRasmy1 = new HashSet<HokmRasmy>();
            HokmRasmy2 = new HashSet<HokmRasmy>();
            InsLaw = new HashSet<InsLaw>();
            InsLaw1 = new HashSet<InsLaw>();
            Mamoriat = new HashSet<Mamoriat>();
            Mamoriat1 = new HashSet<Mamoriat>();
            MilitaryService = new HashSet<MilitaryService>();
            MontlyResult = new HashSet<MontlyResult>();
            MontlyResult1 = new HashSet<MontlyResult>();
            Morakhasi = new HashSet<Morakhasi>();
            NumberHokm = new HashSet<NumberHokm>();
            OtherBime = new HashSet<OtherBime>();
            OtherBime1 = new HashSet<OtherBime>();
            PlaceEmp = new HashSet<PlaceEmp>();
            PostNumbers = new HashSet<PostNumbers>();
            SpecialItem = new HashSet<SpecialItem>();
            TaxLaw = new HashSet<TaxLaw>();
        }

        [Key]
        [StringLength(5)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Dsc { get; set; }

        [Required]
        [StringLength(1)]
        public string Tag { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasePay> BasePay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DegreeTashvigh> DegreeTashvigh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpForeignLang> EmpForeignLang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpForeignLang> EmpForeignLang1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gharardad> Gharardad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gharardad> Gharardad1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmDirector> HokmDirector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmDirector> HokmDirector1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmKargary> HokmKargary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmKargary> HokmKargary1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmLaw> HokmLaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmNoHokmRel> HokmNoHokmRel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmPayItemsLaw> HokmPayItemsLaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmRasmy> HokmRasmy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmRasmy> HokmRasmy1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmRasmy> HokmRasmy2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsLaw> InsLaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsLaw> InsLaw1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mamoriat> Mamoriat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mamoriat> Mamoriat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MilitaryService> MilitaryService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MontlyResult> MontlyResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MontlyResult> MontlyResult1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Morakhasi> Morakhasi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NumberHokm> NumberHokm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherBime> OtherBime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherBime> OtherBime1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceEmp> PlaceEmp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostNumbers> PostNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialItem> SpecialItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxLaw> TaxLaw { get; set; }
    }

    /// <summary>
    /// انواع وضعیت
    /// </summary>
    public enum EmpState
    {
        /// <summary>
        /// فعال رسمی
        /// </summary>
        [Display(Name = "فعال رسمی")]
        Activeofficial=0,
        /// <summary>
        /// راکد موقت
        /// </summary>
        [Display(Name = "راکد موقت")]
        InActiveTemporary,
        /// <summary>
        /// راکد دائم
        /// </summary>
        [Display(Name = "راکد دائم")]
        InActivePermanent,
        /// <summary>
        /// فعال شرکتی
        /// </summary>
        [Display(Name = "فعال شرکتی")]
        ActiveCorporative
    }
}
