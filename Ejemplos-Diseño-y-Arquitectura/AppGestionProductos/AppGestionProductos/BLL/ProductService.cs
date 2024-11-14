using AppGestionProductos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionProductos.BLL
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        // Inyección de dependencias mediante el constructor
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.Name) || product.Price <= 0)
            {
                throw new ArgumentException("Producto inválido");
            }

            _repository.Add(product);
            Console.WriteLine("Producto añadido correctamente.");
        }

        public Product GetProduct(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }
    }
}
