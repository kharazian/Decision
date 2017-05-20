namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Finuser")]
    public partial class Finuser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Finuser()
        {
            Finuser1 = new HashSet<Finuser>();
            FinUsrAccess = new HashSet<FinUsrAccess>();
        }

        [Required]
        [StringLength(2)]
        public string Zonecod { get; set; }

        [Key]
        [StringLength(10)]
        public string OprCod { get; set; }

        [Required]
        [StringLength(15)]
        public string UserId { get; set; }

        [MaxLength(10)]
        public byte[] Password { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string UserFamil { get; set; }

        [StringLength(6)]
        public string EmpNo { get; set; }

        [StringLength(7)]
        public string LevelNo { get; set; }

        [StringLength(8)]
        public string PostNo { get; set; }

        [StringLength(40)]
        public string Postname { get; set; }

        public DateTime? Entdate { get; set; }

        public int? NumUse { get; set; }

        [StringLength(1)]
        public string userStat { get; set; }

        [StringLength(1)]
        public string userTyp { get; set; }

        public byte? UserSubStat { get; set; }

        [StringLength(10)]
        public string OprCod1 { get; set; }

        [StringLength(1)]
        public string useStat { get; set; }

        public byte? talfigi { get; set; }

        [StringLength(1)]
        public string EblEmpNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finuser> Finuser1 { get; set; }

        public virtual Finuser Finuser2 { get; set; }

        public virtual Zone Zone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinUsrAccess> FinUsrAccess { get; set; }
    }
}
