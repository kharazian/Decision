namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NumberHokm")]
    public partial class NumberHokm
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string HokmYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Required]
        [StringLength(3)]
        public string CodeType { get; set; }

        [StringLength(8)]
        public string IssueDate { get; set; }

        [Required]
        [StringLength(8)]
        public string BasePayLawDate { get; set; }

        [Required]
        [StringLength(8)]
        public string HokmPayItemsLawDate { get; set; }

        [Required]
        [StringLength(8)]
        public string SpecialItemLawDate { get; set; }

        [StringLength(8)]
        public string HokmLawDate { get; set; }

        [Required]
        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(10)]
        public string DabirNo { get; set; }

        [StringLength(8)]
        public string DabirDate { get; set; }

        [Required]
        [StringLength(1)]
        public string Permanent { get; set; }

        //public virtual CodeFile CodeFile { get; set; }

        //public virtual Eblagh Eblagh { get; set; }

        //public virtual Gharardad Gharardad { get; set; }

        //public virtual HokmKargary HokmKargary { get; set; }

        //public virtual HokmRasmy HokmRasmy { get; set; }

        //public virtual Mamoriat Mamoriat { get; set; }

        //public virtual Morakhasi Morakhasi { get; set; }

        //public virtual PlaceEmp PlaceEmp { get; set; }
    }
}
