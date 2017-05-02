namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Photo = BitConverter.GetBytes(0);

            Activity = new HashSet<Activity>();
            BonKargary = new HashSet<BonKargary>();
            ContiDeduct = new HashSet<ContiDeduct>();
            ContiPay = new HashSet<ContiPay>();
            Deduct = new HashSet<Deduct>();
            Eblagh = new HashSet<Eblagh>();
            EmpForeignLang = new HashSet<EmpForeignLang>();
            OtherBime = new HashSet<OtherBime>();
            EmpRelative = new HashSet<EmpRelative>();
            EmpWriting = new HashSet<EmpWriting>();
            Evaluation = new HashSet<Evaluation>();
            Gharardad = new HashSet<Gharardad>();
            HokmDirector = new HashSet<HokmDirector>();
            HokmKargary = new HashSet<HokmKargary>();
            HokmRasmy = new HashSet<HokmRasmy>();
            HourMamoriat = new HashSet<HourMamoriat>();
            HourMamoriat1 = new HashSet<HourMamoriat>();
            HourMorakhasi = new HashSet<HourMorakhasi>();
            HourMorakhasi1 = new HashSet<HourMorakhasi>();
            Loan = new HashSet<Loan>();
            Mamoriat = new HashSet<Mamoriat>();
            Management = new HashSet<Management>();
            MilitaryService = new HashSet<MilitaryService>();
            MontlyDeductBoss = new HashSet<MontlyDeductBoss>();
            MontlyResult = new HashSet<MontlyResult>();
            Morakhasi = new HashSet<Morakhasi>();
            OtherBimePrice = new HashSet<OtherBimePrice>();
            Padash = new HashSet<Padash>();
            Pay = new HashSet<Pay>();
            PlaceEmp = new HashSet<PlaceEmp>();
            Saving = new HashSet<Saving>();
            Tashvigh = new HashSet<Tashvigh>();
            Tashvigh1 = new HashSet<Tashvigh>();
        }


        [StringLength(6)]
        public string Empno { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Family { get; set; }

        [Required]
        [StringLength(20)]
        public string FatherName { get; set; }

        [StringLength(30)]
        public string LastFamily { get; set; }

        [Required]
        [StringLength(14)]
        public string IdNo { get; set; }

        [StringLength(20)]
        public string IdNoContinued { get; set; }

        [Required]
        [StringLength(8)]
        public string BirthDate { get; set; }

        [Required]
        [StringLength(5)]
        public string SexCod { get; set; }

        [StringLength(10)]
        public string MostakhdemNo { get; set; }

        [Required]
        [StringLength(6)]
        public string BirthCityCod { get; set; }

        [Required]
        [StringLength(6)]
        public string IssueCityCod { get; set; }

        [Required]
        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(8)]
        public string GovEmpDate { get; set; }

        [StringLength(8)]
        public string ManEmpDate { get; set; }

        [StringLength(6)]
        public string SanavatHokm { get; set; }

        [StringLength(6)]
        public string SanavatHoghogh { get; set; }

        [StringLength(5)]
        public string SematCod { get; set; }

        [StringLength(10)]
        public string MelliCode { get; set; }

        [Required]
        [StringLength(5)]
        public string MarriCod { get; set; }

        [StringLength(8)]
        public string MarriDate { get; set; }

        public int? NoChild { get; set; }

        [StringLength(5)]
        public string ReligionCod { get; set; }

        [StringLength(5)]
        public string NationalCod { get; set; }

        [StringLength(11)]
        public string TelNo { get; set; }

        [StringLength(11)]
        public string Mobile { get; set; }

        [StringLength(11)]
        public string MainTelNo { get; set; }

        [StringLength(10)]
        public string ZipNo { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(5)]
        public string NezStatCod { get; set; }

        [StringLength(90)]
        public string Addr { get; set; }

        [StringLength(5)]
        public string LDegreeCod { get; set; }

        [StringLength(4)]
        public string LMajorCod { get; set; }

        public int Sanavat { get; set; }

        [Required]
        [StringLength(1)]
        public string StopStat { get; set; }

        [Required]
        [StringLength(1)]
        public string PartTime { get; set; }

        [StringLength(13)]
        public string AccNo { get; set; }

        [StringLength(2)]
        public string BankNo { get; set; }

        [StringLength(4)]
        public string BrnchNo { get; set; }

        [StringLength(2)]
        public string BankSh { get; set; }

        [StringLength(4)]
        public string BranchSh { get; set; }

        [StringLength(5)]
        public string InsType { get; set; }

        [StringLength(12)]
        public string InsNo { get; set; }

        [StringLength(5)]
        public string BloodCod { get; set; }

        [StringLength(5)]
        public string HealthCod { get; set; }

        [StringLength(8)]
        public string BudgetNo { get; set; }

        [StringLength(5)]
        public string HouseCod { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Signature { get; set; }

        [Required]
        [StringLength(1)]
        public string SetadiCod { get; set; }

        public float RemMorakhasi { get; set; }

        [Column(TypeName = "money")]
        public decimal LastMogharary { get; set; }

        [StringLength(4)]
        public string LHokmYear { get; set; }

        public int? LSeq { get; set; }

        [StringLength(8)]
        public string LPostNoEblagh { get; set; }

        [StringLength(8)]
        public string LPostNoHokm { get; set; }

        [Required]
        [StringLength(8)]
        public string LRunDate { get; set; }

        [StringLength(4)]
        public string HokmType { get; set; }

        [Required]
        [StringLength(1)]
        public string EmpState { get; set; }

        [Required]
        [StringLength(8)]
        public string IssueDate { get; set; }

        [StringLength(2)]
        public string Grooh { get; set; }

        [Required]
        [StringLength(1)]
        public string BackUp { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [StringLength(8)]
        public string SanavatDate { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(2)]
        public string zonecode { get; set; }

        [Required]
        [StringLength(1)]
        public string Sakhtykar { get; set; }

        public double RemMorOldYear { get; set; }

        [Required]
        [StringLength(4)]
        public string UpdRemMor { get; set; }

        public double? RemMor84 { get; set; }

        [StringLength(13)]
        public string Siba { get; set; }

        [StringLength(15)]
        public string AccNoSh { get; set; }

        [Required]
        [StringLength(1)]
        public string SibaPay { get; set; }

        [StringLength(4)]
        public string RealPlace { get; set; }

        [StringLength(6)]
        public string coupleEmpNo { get; set; }

        [StringLength(13)]
        public string AccNoOld { get; set; }

        [StringLength(20)]
        public string pass1 { get; set; }

        [StringLength(20)]
        public string pass2 { get; set; }

        [StringLength(1)]
        public string Thanks { get; set; }

        [StringLength(4)]
        public string UnitWithoutCostCenter { get; set; }

        [StringLength(6)]
        public string EmpnoNew { get; set; }
        public virtual EmpImage EmpImage { get; set; }
        public virtual Place BirthCity { get; set; }
        public virtual Place IssueCity { get; set; }
        public virtual CodeFile Religion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonKargary> BonKargary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContiDeduct> ContiDeduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContiPay> ContiPay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deduct> Deduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eblagh> Eblagh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpForeignLang> EmpForeignLang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherBime> OtherBime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpRelative> EmpRelative { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpWriting> EmpWriting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gharardad> Gharardad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmDirector> HokmDirector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmKargary> HokmKargary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmRasmy> HokmRasmy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HourMamoriat> HourMamoriat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HourMamoriat> HourMamoriat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HourMorakhasi> HourMorakhasi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HourMorakhasi> HourMorakhasi1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mamoriat> Mamoriat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Management> Management { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MilitaryService> MilitaryService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MontlyDeductBoss> MontlyDeductBoss { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MontlyResult> MontlyResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Morakhasi> Morakhasi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherBimePrice> OtherBimePrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Padash> Padash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pay> Pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceEmp> PlaceEmp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saving> Saving { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tashvigh> Tashvigh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tashvigh> Tashvigh1 { get; set; }
    }
}
