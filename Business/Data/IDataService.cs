using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Data
{
    public interface IDataService<T>
    {
        List<ValidationResult> ValidateModel(T model);
        List<T> Get(
            Expression<Func<T, bool>> whereExpression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null,
            string includeModels = "");
        T GetById(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}