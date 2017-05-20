namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string LoantypCod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string LoanYear { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string LoanMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal NextAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal Reminder { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountCurr { get; set; }

        [StringLength(1)]
        public string Calck { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(2)]
        public string BankCod { get; set; }

        [StringLength(4)]
        public string BranchCod { get; set; }

        [StringLength(26)]
        public string AccNo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }
    }
}
