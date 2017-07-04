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
    class HokmPayKargaryConfig : EntityTypeConfiguration<HokmPaysKargary>
    {
        public HokmPayKargaryConfig()
        {
            HasKey(e => new { e.HokmYear, e.Seq, e.PayCod });
            HasRequired(e => e.Pay).WithMany().HasForeignKey(e => e.PayCod).WillCascadeOnDelete(false);
        }
    }
}
