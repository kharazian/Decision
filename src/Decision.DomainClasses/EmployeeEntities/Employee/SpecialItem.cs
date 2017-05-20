namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialItem")]
    public partial class SpecialItem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string LawDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        public short ChildMax { get; set; }

        [Column(TypeName = "money")]
        public decimal MinPayMnth { get; set; }

        public float? PercentKhazaneh { get; set; }

        public float MorakhasiSaveMnth { get; set; }

        public float MorakhasiSaveYear { get; set; }

        public float DayToHour { get; set; }

        public int? MamoriatPrice { get; set; }

        public int? SingleBonPrice { get; set; }

        public int? MarridBonPrice { get; set; }

        [StringLength(1)]
        public string CalcBackPay { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public float? InStateMamoriat { get; set; }

        public float? OutStateMamoriat { get; set; }

        [Column(TypeName = "money")]
        public decimal? TrainingReward { get; set; }

        public virtual CodeFile CodeFile { get; set; }
    }
}
