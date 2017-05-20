
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace Decision.DomainClasses.EmployeeEntities
{
    [Table("EmpImage")]
    public partial class EmpImage
    {
        public EmpImage()
        {
            Photo = BitConverter.GetBytes(0);
        }
        [Key]
        [StringLength(6)]
        public string Empno { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Signature { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

    }
}
