namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostNumbers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostNumbers()
        {
            Tashvigh = new HashSet<Tashvigh>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string PostNo { get; set; }

        [Required]
        [StringLength(80)]
        public string Dsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [Required]
        [StringLength(1)]
        public string TypOfPost { get; set; }

        [StringLength(8)]
        public string KargarPostNo { get; set; }

        [StringLength(50)]
        public string KargarDesc { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tashvigh> Tashvigh { get; set; }
    }
}
