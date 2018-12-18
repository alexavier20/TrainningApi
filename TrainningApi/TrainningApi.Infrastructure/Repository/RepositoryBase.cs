using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TrainningApi.Domain.Interfaces.Repository;
using TrainningApi.Infrastructure.Context;

namespace TrainningApi.Infrastructure.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected TrainningApiContext Db;
        protected DbSet<TEntity> DbSet;

        bool disposed = false;

        public RepositoryBase(TrainningApiContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public TEntity Add(TEntity obj)
        {
            var objreturn = DbSet.Add(obj);
            //Db.SaveChanges();
            return objreturn.Entity;
        }

        public void AddRange(List<TEntity> obj)
        {
            DbSet.AddRange(obj);
            Db.SaveChanges();
        }

        public List<TEntity> ComboBox()
        {
            using (var transaction = Db.Database.BeginTransaction())
            {
                return DbSet.AsNoTracking().ToList();
            }
        }

        public void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void DeleteRange(List<TEntity> entity)
        {
            Db.RemoveRange(entity);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = true, IList<string> eagerLoads = null, int take = 0)
        {
            var q = DbSet.Where(predicate);

            if (eagerLoads != null)
            {
                foreach (String eager in eagerLoads)
                {
                    q = q.Include(eager);
                }
            }

            var result = new List<TEntity>();

            if (take > 0)
            {
                q = q.Take(take);
            }

            if (@readonly)
            {
                using (var tran = Db.Database.BeginTransaction())
                {
                    result = q.AsNoTracking().ToList();
                    return result;
                }
            }
            else
            {
                result = q.ToList();

                foreach (var item in result)
                {
                    Db.Entry<TEntity>(item).Reload();
                }

                return result;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var transaction = Db.Database.BeginTransaction())
            {
                return DbSet.ToList();
            }
        }

        public IQueryable<TEntity> GetAllAsNoTracking()
        {
            using (var transaction = Db.Database.BeginTransaction())
            {
                return DbSet.AsNoTracking();
            }
        }

        public TEntity GetById(int id)
        {
            using (var transaction = Db.Database.BeginTransaction())
            {
                var entity = DbSet.Find(id);
                return entity;
            }
        }

        public void RejectChanges()
        {
            foreach (var entry in Db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        public int SaveChanges()
        {
            var teste = Db.SaveChanges();
            return teste;
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
            Db.ChangeTracker.AutoDetectChangesEnabled = false;
            //Db.SaveChanges();
        }

        public void UpdateBatch(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<TEntity> obj)
        {
            Db.UpdateRange(obj);
            Db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }
    }
}
