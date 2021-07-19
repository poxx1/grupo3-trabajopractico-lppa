using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Marketplace.Entities.Models;

namespace Marketplace.Data.Services
{
    public class BaseDataServices<T> : IDataService<T> where T: IdentityBase, new()
    {
        protected MarketDbContext Db;
        public BaseDataServices()
        {
            this.Db = new MarketDbContext();
        }

        public T Create(T entity)
        {
            Db.Set<T>().Add(entity); // hago un db.set del tipo y lo adjunto
            Db.SaveChanges(); // lo almaceno
            return entity; // guardo el valor
        }

        public void Delete(T entity)
        {
            Db.Entry(entity).State = EntityState.Deleted;
            Db.SaveChanges();
            //Db.Set<T>().Remove(entity);
            //Db.SaveChanges();
        }

        public List<T> Get(Expression<Func<T, bool>> whereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeModels = "")
        {

            IQueryable<T> query = Db.Set<T>();

            // si where es distinto de null le pone la whereExpression a la query
            if (whereExpression != null)
                query = query.Where(whereExpression);
            // busca en includeModels si tengo entidades para relacionar, incluyento todos los modelos que necesite
            var entity = includeModels.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            // incluye en la entidad que estoy utilizando todos los modelos adicionales que se necesiten en la query
            query = entity.Aggregate(query, (current, model) => current.Include(model));
            // si no es null le pasa el criterio de ordenamiento
            if (orderFunction != null)
                query = orderFunction(query);
            // retorna la lista devuelta
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