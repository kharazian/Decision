namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostHokm")]
    public partial class PostHokm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostHokm()
        {
            OrganPost = new HashSet<OrganPost>();
        }

        [Key]
        [StringLength(10)]
        public string PostCode { get; set; }

        [Required]
        [StringLength(6)]
        public string IdOrgan { get; set; }

        [Required]
        [StringLength(5)]
        public string RstCode { get; set; }

        [Required]
        [StringLength(4)]
        public string JobMajorCode { get; set; }

        [Required]
        [StringLength(50)]
        public string PostDsc { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        public virtual JobMajor JobMajor { get; set; }

        public virtual LevelChart LevelChart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganPost> OrganPost { get; set; }
    }
}
