using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace Marketplace.Data.Services
{
    public interface IDataService<T> // Tipo T puede tomar cualquier tipo de entidad que va implementar c/u de los metodos
    {
        List<ValidationResult> ValidateModel(T model);
        List<T> Get(
            Expression<Func<T, bool>> whereExpression = null, //le paso una expresion where con los filtros, por default es null
            Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, // si quiero que venga ordenado por un criterio, por defaul es null
            string includeModels = ""); // le digo con que otro modelo esta incluido para nevegar a otros objetos y poder recuperar sus valores
        T GetById(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
