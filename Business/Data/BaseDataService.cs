using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Data
{
    public class BaseDataService<T> : IDataService<T> where T : IdentityBase, new()
    {
        protected ProductoDbContext Db;

        public BaseDataService()
        {
            this.Db = new ProductoDbContext();
        }

        public T Create(T entity)
        {
            Db.Set<T>().Add(entity);
            Db.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            Db.Set<T>().Attach(entity);
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            this.Delete(entity);
        }

        public List<T> Get(Expression<Func<T, bool>> whereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeModels = "")
        {
            IQueryable<T> query = Db.Set<T>();

            if (whereExpression != null)
                query = query.Where(whereExpression);

            var entity = includeModels.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            query = entity.Aggregate(query, (current, model) => current.Include(model));

            if (orderFunction != null)
                query = orderFunction(query);

            return query.ToList();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().SingleOrDefault(o => o.Id == id);
        }

        public void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public List<ValidationResult> ValidateModel(T model)
        {
            throw new NotImplementedException();
        }
    }
}