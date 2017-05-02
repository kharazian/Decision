namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LimitSum")]
    public partial class LimitSum
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Years { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Mont { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ManagNo2 { get; set; }

        [StringLength(50)]
        public string ZoneName { get; set; }

        [StringLength(50)]
        public string UnitName { get; set; }

        [StringLength(40)]
        public string NamManagement { get; set; }

        [StringLength(40)]
        public string Moaven { get; set; }

        public int? Number { get; set; }

        public int? NumJanbaz { get; set; }

        public int? Karmand { get; set; }

        public int? KargarKarmand { get; set; }

        public int? KargarKargar { get; set; }

        public int? Manager { get; set; }

        public int? NumTypist { get; set; }

        public int? NumServices { get; set; }

        public int? NumServant { get; set; }

        [Column(TypeName = "money")]
        public decimal? Karaee { get; set; }

        [Column(TypeName = "money")]
        public decimal? OfferKaraee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MidEzafehKar { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OfferEzafehKar { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RemEzafehKar { get; set; }

        public int? HoliDay { get; set; }

        public int? NightPay { get; set; }

        public int? BadazZohr { get; set; }

        public int? SahmPlus { get; set; }

        [Column(TypeName = "money")]
        public decimal? KaraPer { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemKaraee { get; set; }

        public int? RemHoliDay { get; set; }

        public int? RemNight { get; set; }

        public int? RemBadazZohr { get; set; }

        public int? RemSahmPlus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RemCurrentEzafehKar { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemCurrentKaraee { get; set; }
    }
}
