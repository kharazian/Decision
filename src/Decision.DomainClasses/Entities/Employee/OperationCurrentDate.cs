namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationCurrentDate")]
    public partial class OperationCurrentDate
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string OpCurYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string OpCurMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Required]
        [StringLength(1)]
        public string PayTag { get; set; }

        [Required]
        [StringLength(8)]
        public string RunDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(5)]
        public string EmpTyp { get; set; }

        public virtual Zone Zone { get; set; }
    }
}
