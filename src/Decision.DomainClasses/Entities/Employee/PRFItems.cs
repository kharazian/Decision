namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRFItems
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string empno { get; set; }

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
        public string ItemCode { get; set; }

        public long? Amount { get; set; }

        public short? HowMany { get; set; }

        public long? Reminder { get; set; }

        [StringLength(30)]
        public string ItemDsc { get; set; }
    }
}
