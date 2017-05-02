namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MontlyDeductBoss")]
    public partial class MontlyDeductBoss
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
        [StringLength(4)]
        public string DeductCod { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }

        public virtual MontlyResult MontlyResult { get; set; }
    }
}
