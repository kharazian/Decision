namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmPaysGharardad")]
    public partial class HokmPaysGharardad
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string HokmYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string PayCod { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Gharardad Gharardad { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }
    }
}
