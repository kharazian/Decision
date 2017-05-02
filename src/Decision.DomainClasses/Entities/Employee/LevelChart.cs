namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LevelChart")]
    public partial class LevelChart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LevelChart()
        {
            JobMajor = new HashSet<JobMajor>();
            OrganPost = new HashSet<OrganPost>();
            PostHokm = new HashSet<PostHokm>();
        }

        [StringLength(6)]
        public string Id { get; set; }

        [Required]
        [StringLength(8)]
        public string ChartDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Dsc { get; set; }

        [StringLength(6)]
        public string FatherId { get; set; }

        [Required]
        [StringLength(4)]
        public string LevelCode { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobMajor> JobMajor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganPost> OrganPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostHokm> PostHokm { get; set; }
    }
}
