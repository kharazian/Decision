namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TitleSumPayDeduct")]
    public partial class TitleSumPayDeduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeqOfSum { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(80)]
        public string DscSum { get; set; }

        [StringLength(3)]
        public string crtitkNo { get; set; }

        [StringLength(3)]
        public string crtitmNo { get; set; }

        [StringLength(3)]
        public string crTitTNo { get; set; }

        [StringLength(3)]
        public string TitkNo { get; set; }

        [StringLength(3)]
        public string Titmno { get; set; }

        [StringLength(3)]
        public string titTno { get; set; }

        [StringLength(3)]
        public string TitjNo { get; set; }
    }
}
