namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zone")]
    public partial class Zone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zone()
        {
            BonKargary = new HashSet<BonKargary>();
            Finuser = new HashSet<Finuser>();
            OperationCurrentDate = new HashSet<OperationCurrentDate>();
            Padash = new HashSet<Padash>();
            Eidy = new HashSet<Eidy>();
        }

        [Key]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Required]
        [StringLength(40)]
        public string Dsc { get; set; }

        [Required]
        [StringLength(1)]
        public string ZoneType { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(30)]
        public string State { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(10)]
        public string KargahSerial { get; set; }

        public bool? InsRep { get; set; }

        public bool? NoRunPay { get; set; }

        [StringLength(4)]
        public string OrganCod { get; set; }

        [StringLength(13)]
        public string OrganCod1 { get; set; }

        [StringLength(2)]
        public string BankCod { get; set; }

        [StringLength(4)]
        public string BranchCod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonKargary> BonKargary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finuser> Finuser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationCurrentDate> OperationCurrentDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Padash> Padash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eidy> Eidy { get; set; }
    }
}
