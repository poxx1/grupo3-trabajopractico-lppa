using Marketplace.Data.Services;
using Marketplace.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Business
{
    public class LoginBiz
    {
        /// <summary>
        /// Listar entidades Category generando el contexto con Data/BaseDataServices.cs indicandole el nombre de la entidad (T) con la que voy a trabajar
        /// </summary>
        /// <returns>Llama el método Get que retorna una lista de entidades, en este caso Categories</returns>
        public LogInModel Get(int id)
        {
            var db = new BaseDataServices<LogInModel>();
            return db.GetById(id);
        }

        public List<LogInModel> List()
        {
            var db = new BaseDataServices<LogInModel>();
            var lista = db.Get();
            return lista;
        }

        /// <summary>
        /// Crear una nueva Category pasandola por parametro.
        /// TODO: Agregar validaciones correspondientes.
        /// </summary>
        /// <param name="model"></param>
        public void Create(LogInModel model)
        {
            var db = new BaseDataServices<LogInModel>();
            db.Create(model);
        }

        public void Edit(LogInModel model)
        {
            var db = new BaseDataServices<LogInModel>();
            db.Update(model);
        }

        public void Delete(LogInModel model)
        {
            var db = new BaseDataServices<LogInModel>();
            db.Delete(model);
        }
    }
}
