namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Karkerd_Sherkaty
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Years { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string Months { get; set; }

        [StringLength(5)]
        public string MamorType { get; set; }

        [StringLength(3)]
        public string MamorPlace { get; set; }

        public int? Karkerd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EzafeKar { get; set; }

        public int? ShabKari { get; set; }

        public int? TatilKari { get; set; }

        public int? Gheibat { get; set; }

        public int? Bimari { get; set; }

        public int? Mamoriat { get; set; }

        public long? Karaneh { get; set; }

        public int? NobatKari { get; set; }

        public int? Estelaji { get; set; }

        public int? Estehgagi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Takhir { get; set; }

        public int? other { get; set; }

        public int? Reserv5 { get; set; }

        [StringLength(1)]
        public string Confirmed { get; set; }

        [StringLength(2)]
        public string ZoneNo { get; set; }
    }
}
