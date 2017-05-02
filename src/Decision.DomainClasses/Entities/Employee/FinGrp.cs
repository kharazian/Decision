namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinGrp")]
    public partial class FinGrp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinGrp()
        {
            FinGrpAccess = new HashSet<FinGrpAccess>();
            FinGrpMem = new HashSet<FinGrpMem>();
        }

        [Key]
        [StringLength(2)]
        public string GrpNo { get; set; }

        [Required]
        [StringLength(40)]
        public string GrpName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinGrpAccess> FinGrpAccess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinGrpMem> FinGrpMem { get; set; }
    }
}
