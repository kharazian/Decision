namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SumPayDeduct")]
    public partial class SumPayDeduct
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ZoneCod { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string YearPay { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string MonThPay { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string ListType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeqOfSum { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string KindUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumAmount { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(8)]
        public string RunDate { get; set; }
    }
}
