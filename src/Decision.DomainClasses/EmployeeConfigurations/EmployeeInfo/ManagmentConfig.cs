using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;

namespace Decision.DomainClasses.EmployeeConfigurations
{
    /// <summary>
    /// نشان دهنده مپینگ مربوط به کلاس ارگان
    /// </summary>
    public class ManagementConfig : EntityTypeConfiguration<Management>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public ManagementConfig()
        {
            HasKey(u => new
            {
                u.Manage1No,
                u.Manage2No
            });
        }
    }
}
