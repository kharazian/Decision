using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;

namespace Decision.DomainClasses.EmployeeConfigurations.EmployeeInfo
{
    class OtherBimeConfig : EntityTypeConfiguration<OtherBime>
    {
        public OtherBimeConfig()
        {
            HasKey(e => new { e.Empno, e.RelTypeCod, e.RelSequence, e.BimeCod, e.StartYear, e.StartMonth });
            HasRequired(e => e.RelType).WithMany().HasForeignKey(e => e.RelTypeCod).WillCascadeOnDelete(false);
            HasRequired(e => e.Bime).WithMany().HasForeignKey(e => e.BimeCod).WillCascadeOnDelete(false);

        }
    }
}
