using Marketplace.Data.Services;
using Marketplace.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Business
{
    public class ProductBiz
    {        
        /// <summary>
        /// Listar entidades Product generando el contexto con Data/BaseDataServices.cs indicandole el nombre de la entidad (T) con la que voy a trabajar
        /// </summary>
        /// <returns>Llama el método Get que retorna una lista de entidades, en este caso Categories</returns>
        public Product Get(int id)
        {
            var db = new BaseDataServices<Product>();
            return db.GetById(id);
        }

        public List<Product> List()
        {
            var db = new BaseDataServices<Product>();
            var lista = db.Get();
            return lista;
        }

        /// <summary>
        /// Crear un nuevo producto pasandola por parametro.
        /// TODO: Agregar validaciones correspondientes.
        /// </summary>
        /// <param name="model"></param>
        public void Create(Product model)
        {
            var db = new BaseDataServices<Product>();
            db.Create(model);
        }

        public void Edit(Product model)
        {
            var db = new BaseDataServices<Product>();
            db.Update(model);
        }

        public void Delete(Product model)
        {
            var db = new BaseDataServices<Product>();
            db.Delete(model);
        }
    }
}
