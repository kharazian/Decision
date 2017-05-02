namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlInfo")]
    public partial class ControlInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Years { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Months { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        public int? EzafehKar_Pay { get; set; }

        public int? Night_Pay { get; set; }

        public int? Holiday_Pay { get; set; }

        public int? BadZohr_Pay { get; set; }

        [Column(TypeName = "money")]
        public decimal? Padash_Pay { get; set; }

        public int? EzafehKar_Rem { get; set; }

        public int? Night_Rem { get; set; }

        public int? Holiday_Rem { get; set; }

        public int? BadZohr_Rem { get; set; }

        [Column(TypeName = "money")]
        public decimal? Padash_Rem { get; set; }

        public int? Limit_EzafeKar { get; set; }

        public int? Limit_Night { get; set; }

        public int? Limit_Holiday { get; set; }

        public int? Limit_BadZohr { get; set; }

        [Column(TypeName = "money")]
        public decimal? Limit_Padash { get; set; }

        public int? LimitOldEzafeh { get; set; }

        public int? LimitOldNight { get; set; }

        public int? LimitOldHoliday { get; set; }

        public int? LimitOldBadZohr { get; set; }

        public int? LimitOldPadash { get; set; }

        public int? MidEzafehKar { get; set; }
    }
}
