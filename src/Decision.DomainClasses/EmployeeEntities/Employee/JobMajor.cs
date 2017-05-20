namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobMajor")]
    public partial class JobMajor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobMajor()
        {
            PostHokm = new HashSet<PostHokm>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string RstCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string JobMajorCode { get; set; }

        [Required]
        [StringLength(6)]
        public string IdOrgan { get; set; }

        [Required]
        [StringLength(30)]
        public string JobMajorName { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        public virtual LevelChart LevelChart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostHokm> PostHokm { get; set; }
    }
}
