using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample
{
    // Define el modelo de datos (entidad)
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }

    // Define el contexto de datos
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Al-hp;Database=TestDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contexto de datos
            using (var context = new MyDbContext())
            {
                // Ejemplo de insertar un nuevo cliente
                var newCustomer = new Customer { CustomerName = "John Doe" };
                context.Customers.Add(newCustomer);
                context.SaveChanges();
                Console.WriteLine($"Nuevo cliente agregado: {newCustomer.CustomerName}");

                // Ejemplo de leer todos los clientes
                var customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"CustomerId: {customer.CustomerId}, CustomerName: {customer.CustomerName}");
                }

                // Ejemplo de actualizar un cliente
                var customerToUpdate = context.Customers.FirstOrDefault(c => c.CustomerName == "John Doe");
                if (customerToUpdate != null)
                {
                    customerToUpdate.CustomerName = "Jane Doe";
                    context.SaveChanges();
                    Console.WriteLine($"Cliente actualizado: {customerToUpdate.CustomerName}");
                }

                // Ejemplo de eliminar un cliente
                var customerToDelete = context.Customers.FirstOrDefault(c => c.CustomerName == "Jane Doe");
                if (customerToDelete != null)
                {
                    context.Customers.Remove(customerToDelete);
                    context.SaveChanges();
                    Console.WriteLine($"Cliente eliminado: {customerToDelete.CustomerName}");
                }
            }
        }
    }
}
