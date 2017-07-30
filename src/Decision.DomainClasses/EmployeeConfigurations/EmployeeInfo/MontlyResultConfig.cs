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
    class MontlyResultConfig : EntityTypeConfiguration<MontlyResult>
    {
        public MontlyResultConfig()
        {
            HasKey(e => new { e.Empno, e.ResultYear, e.ResultMonth, e.seq});
            //HasRequired(e => e.Place).WithRequiredDependent().WillCascadeOnDelete(false);
            //HasRequired(e => e.Semat).WithMany().HasForeignKey(e => e.SematCod).WillCascadeOnDelete(false);
        }
    }
}
