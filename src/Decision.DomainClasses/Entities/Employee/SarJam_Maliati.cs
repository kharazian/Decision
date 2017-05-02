namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SarJam_Maliati
    {
        [StringLength(12)]
        public string Dossier_NUM { get; set; }

        [StringLength(4)]
        public string Year_SH { get; set; }

        [StringLength(2)]
        public string Mahe_SH { get; set; }

        [StringLength(15)]
        public string Total_Salary_Pay { get; set; }

        [StringLength(15)]
        public string Total_Pay_Under_TAX { get; set; }

        [StringLength(15)]
        public string Total_Tax { get; set; }

        [StringLength(15)]
        public string Tax_Penalty_anunce { get; set; }

        [StringLength(15)]
        public string Tax_Penalty_Pay { get; set; }

        [StringLength(15)]
        public string Rest_Tax { get; set; }

        [StringLength(17)]
        public string YET_Total_Salary { get; set; }

        [StringLength(17)]
        public string YET_Totality_ALL { get; set; }

        [StringLength(17)]
        public string YET_Total_TAX { get; set; }

        [StringLength(17)]
        public string YET_Total_Penarty_anunce { get; set; }

        [StringLength(17)]
        public string YET_Total_Penalty_Pay { get; set; }

        [StringLength(17)]
        public string YET_Rest_Tax { get; set; }

        [StringLength(8)]
        public string Icorprate_Date { get; set; }

        [StringLength(6)]
        public string Total_Person { get; set; }

        [StringLength(4)]
        public string Total_Forin_Person { get; set; }

        [StringLength(1)]
        public string Pay_Method { get; set; }

        [StringLength(6)]
        public string Check_Serial { get; set; }

        [StringLength(10)]
        public string Check_Date { get; set; }

        [StringLength(2)]
        public string Bank_Name { get; set; }

        [StringLength(25)]
        public string BRanche_Name { get; set; }

        [StringLength(12)]
        public string Bank_ACC { get; set; }

        [StringLength(15)]
        public string Pay { get; set; }

        [StringLength(2)]
        public string Zone_CODE { get; set; }

        [Key]
        public int tt { get; set; }
    }
}
