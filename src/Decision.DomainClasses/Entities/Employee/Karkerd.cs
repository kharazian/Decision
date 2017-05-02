namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Karkerd")]
    public partial class Karkerd
    {
        public long ID { get; set; }

        [StringLength(4)]
        public string Sal { get; set; }

        [StringLength(2)]
        public string Month { get; set; }

        [StringLength(6)]
        public string EmpNo { get; set; }

        public int? MorDay { get; set; }

        [StringLength(10)]
        public string MorTime { get; set; }

        [StringLength(10)]
        public string MorEst3Day { get; set; }

        [StringLength(10)]
        public string MorEst3Day1 { get; set; }

        [StringLength(10)]
        public string Takhir { get; set; }

        [StringLength(10)]
        public string Taghil { get; set; }

        [StringLength(10)]
        public string HozorGMAR { get; set; }

        [StringLength(10)]
        public string HozorMA { get; set; }

        [StringLength(10)]
        public string AHozorMA { get; set; }

        [StringLength(10)]
        public string KasrKar { get; set; }

        [StringLength(10)]
        public string KolHozor { get; set; }

        [StringLength(10)]
        public string MamoriyatB { get; set; }

        [StringLength(10)]
        public string MamoriyatNB { get; set; }

        [StringLength(10)]
        public string MamoriyatSaat { get; set; }

        [StringLength(10)]
        public string TatilKari { get; set; }

        [StringLength(10)]
        public string EzafeKar { get; set; }

        [StringLength(10)]
        public string MorNotPay { get; set; }

        [StringLength(10)]
        public string MorZayman { get; set; }

        public byte Active { get; set; }
    }
}
