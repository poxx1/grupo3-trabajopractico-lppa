using System.Collections.Generic;
using Marketplace.Entities.Models;

namespace Marketplace.Data.Services
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
    }
}

