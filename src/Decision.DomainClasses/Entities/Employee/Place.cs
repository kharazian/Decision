namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public partial class Place
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Place()
        {
            HokmRasmy = new HashSet<HokmRasmy>();
        }

        [Key]
        [StringLength(6)]
        public string Code { get; set; }

        [Required]
        [StringLength(40)]
        public string DscPlace { get; set; }

        [StringLength(1)]
        public string UpdtTag { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HokmRasmy> HokmRasmy { get; set; }
    }
}
