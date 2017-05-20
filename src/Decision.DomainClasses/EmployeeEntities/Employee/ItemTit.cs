namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemTit")]
    public partial class ItemTit
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Itemcode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Emptype { get; set; }

        [StringLength(3)]
        public string TitkNo { get; set; }

        [StringLength(3)]
        public string Titmno { get; set; }

        [StringLength(3)]
        public string titTno { get; set; }

        [StringLength(3)]
        public string TitjNo { get; set; }

        [StringLength(3)]
        public string crtitkNo { get; set; }

        [StringLength(3)]
        public string crtitmNo { get; set; }

        [StringLength(3)]
        public string crTitTNo { get; set; }

        [StringLength(2)]
        public string BankNo { get; set; }

        [StringLength(4)]
        public string BrnchNo { get; set; }
    }
}
