namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganUnit")]
    public partial class OrganUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganUnit()
        {
            MontlyResult = new HashSet<MontlyResult>();
            PlaceEmp = new HashSet<PlaceEmp>();
        }

        [Key]
        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(6)]
        public string EmpNo { get; set; }

        [Required]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Required]
        [StringLength(2)]
        public string Manage1No { get; set; }

        [Required]
        [StringLength(2)]
        public string Manage2No { get; set; }

        [Required]
        [StringLength(50)]
        public string NamOrganUnit { get; set; }

        [StringLength(11)]
        public string TelNo { get; set; }

        [StringLength(90)]
        public string Addr { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(1)]
        public string Active { get; set; }

        [StringLength(1)]
        public string ManageOk { get; set; }

        public virtual Management Management { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MontlyResult> MontlyResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceEmp> PlaceEmp { get; set; }
    }
}
