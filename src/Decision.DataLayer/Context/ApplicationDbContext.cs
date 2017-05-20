using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EntityFramework.BulkInsert.Extensions;
using EntityFramework.DynamicFilters;
using RefactorThis.GraphDiff;

namespace Decision.DataLayer.Context
{
    public class ApplicationDbContext : BaseDbContext,
       IUnitOfWork
    {
        #region Field
        private EmployeeDbContext _employeeDbContext;
        #endregion
        #region Ctor
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            _employeeDbContext = new EmployeeDbContext();
        }

        #endregion

        #region IUnitOfWork
        public T Update<T>(T entity, Expression<Func<IUpdateConfiguration<T>, object>> mapping)
            where T : class, new()
        {
            return this.UpdateGraph(entity, mapping);
        }
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            if (_employeeDbContext.IsEntity(typeof(TEntity)))
                return _employeeDbContext.Set<TEntity>();
            return base.Set<TEntity>();
        }

        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }
        public void MarkAsDetached<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Detached;
        }
        public void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Added;
        }

        public void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public IList<T> GetRows<T>(string sql, params object[] parameters) where T : class
        {
            return Database.SqlQuery<T>(sql, parameters).ToList();
        }

        public void AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            ((DbSet<TEntity>)Set<TEntity>()).AddRange(entities);
        }
        public void ForceDatabaseInitialize()
        {
            Database.Initialize(force: true);
        }

        public void EnableFiltering(string name)
        {
            _employeeDbContext.EnableFilter(name);
        }

        public void EnableFiltering(string name, string parameter, object value)
        {
            _employeeDbContext.EnableFilter(name);
            _employeeDbContext.SetFilterScopedParameterValue(name, parameter, value);
        }

        public void DisableFiltering(string name)
        {
            _employeeDbContext.DisableFilter(name);
        }

        public void BulkInsertData<T>(IEnumerable<T> data)
        {
            this.BulkInsert(data);
        }

        public bool ValidateOnSaveEnabled
        {
            get { return Configuration.ValidateOnSaveEnabled; }
            set { Configuration.ValidateOnSaveEnabled = value; }
        }

        public bool ProxyCreationEnabled
        {
            get { return Configuration.ProxyCreationEnabled; }
            set { Configuration.ProxyCreationEnabled = value; }
        }

        bool IUnitOfWork.AutoDetectChangesEnabled
        {
            get { return Configuration.AutoDetectChangesEnabled; }
            set { Configuration.AutoDetectChangesEnabled = value; }
        }

        public bool ForceNoTracking { get; set; }
        #endregion
    }
  
}
