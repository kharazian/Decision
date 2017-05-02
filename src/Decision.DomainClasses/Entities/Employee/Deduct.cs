namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deduct")]
    public partial class Deduct
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ResultYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ResultMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string DeductCod { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public short HowMany { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual MontlyResult MontlyResult { get; set; }
    }
}
