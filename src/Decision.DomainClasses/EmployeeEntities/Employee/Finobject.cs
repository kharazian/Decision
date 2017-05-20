namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Finobject")]
    public partial class Finobject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Finobject()
        {
            FinClass = new HashSet<FinClass>();
        }

        [Key]
        [StringLength(4)]
        public string ObjNo { get; set; }

        [Required]
        [StringLength(40)]
        public string ObjName { get; set; }

        [Required]
        [StringLength(40)]
        public string ObjForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinClass> FinClass { get; set; }
    }
}
