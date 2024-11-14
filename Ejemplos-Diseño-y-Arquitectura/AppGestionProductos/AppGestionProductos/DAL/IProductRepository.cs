using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionProductos.DAL
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int id);
        IEnumerable<Product> GetAll();
    }
}

