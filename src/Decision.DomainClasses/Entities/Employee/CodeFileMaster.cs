namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodeFileMaster")]
    public partial class CodeFileMaster
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SysGroup { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SysCod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string MainCod { get; set; }

        [Required]
        [StringLength(30)]
        public string Dsc { get; set; }
    }
}
