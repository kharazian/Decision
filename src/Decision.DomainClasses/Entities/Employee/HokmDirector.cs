namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmDirector")]
    public partial class HokmDirector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HokmDirector()
        {
            Gharardad = new HashSet<Gharardad>();
            HokmKargary = new HashSet<HokmKargary>();
            HokmRasmy = new HashSet<HokmRasmy>();
            Mamoriat = new HashSet<Mamoriat>();
        }

        [Key]
        [StringLength(4)]
        public string SequenceNo { get; set; }

        [Required]
        [StringLength(8)]
        public string DateDirector { get; set; }

        [StringLength(5)]
        public string EmpTypeDirector { get; set; }

        [Required]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [StringLength(8)]
        public string PostNo { get; set; }

        [Required]
        [StringLength(5)]
        public string EmpType { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual CodeFile CodeFile1 { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gharardad> Gharardad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmKargary> HokmKargary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmRasmy> HokmRasmy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mamoriat> Mamoriat { get; set; }
    }
}
