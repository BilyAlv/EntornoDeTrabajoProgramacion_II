using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionProductos.DAL
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Product Get(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
    }
}

