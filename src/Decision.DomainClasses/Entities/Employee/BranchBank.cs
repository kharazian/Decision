namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BranchBank")]
    public partial class BranchBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BranchBank()
        {
            MontlyResult = new HashSet<MontlyResult>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string BankNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string BrnchNo { get; set; }

        [Required]
        [StringLength(20)]
        public string BranchNam { get; set; }

        [StringLength(30)]
        public string Addr { get; set; }

        [StringLength(11)]
        public string TelNo { get; set; }

        [StringLength(11)]
        public string FaxNo { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual Bank Bank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MontlyResult> MontlyResult { get; set; }
    }
}
