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
    class ExperienceConfig : EntityTypeConfiguration<Experience>
    {
        public ExperienceConfig()
        {
            HasKey(e => new { e.Empno, e.StartDate});
        }
    }
}
