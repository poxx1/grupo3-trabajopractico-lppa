using Marketplace.Data.Services;
using Marketplace.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Business
{
    public class CategoryBiz
    {        
        /// <summary>
        /// Listar entidades Category generando el contexto con Data/BaseDataServices.cs indicandole el nombre de la entidad (T) con la que voy a trabajar
        /// </summary>
        /// <returns>Llama el método Get que retorna una lista de entidades, en este caso Categories</returns>
        public Category Get(int id)
        {
            var db = new BaseDataServices<Category>();
            return db.GetById(id);
        }

        public List<Category> List()
        {
            var db = new BaseDataServices<Category>();
            var lista = db.Get();
            return lista;
        }

        /// <summary>
        /// Crear una nueva Category pasandola por parametro.
        /// TODO: Agregar validaciones correspondientes.
        /// </summary>
        /// <param name="model"></param>
        public void Create(Category model)
        {
            var db = new BaseDataServices<Category>();
            db.Create(model);
        }

        public void Edit(Category model)
        {
            var db = new BaseDataServices<Category>();
            db.Update(model);
        }

        public void Delete(Category model)
        {
            var db = new BaseDataServices<Category>();
            db.Delete(model);
        }
    }
}
