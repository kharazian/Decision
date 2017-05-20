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
    class EmpRelativeConfig : EntityTypeConfiguration<EmpRelative>
    {
        public EmpRelativeConfig()
        {
            HasKey(e => new { e.Empno, e.ReltypeCod, e.RelSequence });
        }
    }
}
