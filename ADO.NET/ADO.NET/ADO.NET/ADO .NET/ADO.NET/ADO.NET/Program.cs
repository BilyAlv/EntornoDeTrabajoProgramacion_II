using System;
using Microsoft.Data.SqlClient;

namespace AdoNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cadena de conexión con la base de datos "TestDB"
            string connectionString = @"server=Al-hp; database=TestDB; integrated security=true; TrustServerCertificate=True;";

            // Conectar a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión abierta con éxito.");

                    // Ejemplo de lectura de datos (consulta SELECT)
                    string query = "SELECT CustomerId, CustomerName FROM Customers";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Leer los resultados de la consulta
                    while (reader.Read())
                    {
                        Console.WriteLine($"CustomerId: {reader["CustomerId"]}, CustomerName: {reader["CustomerName"]}");
                    }

                    reader.Close();

                    // Ejemplo de inserción de datos (comando INSERT)
                    string insertQuery = "INSERT INTO Customers (CustomerName) VALUES ('John Doe')";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine($"Filas insertadas: {rowsAffected}");

                    // Ejemplo de actualización de datos (comando UPDATE)
                    string updateQuery = "UPDATE Customers SET CustomerName = 'Jane Doe' WHERE CustomerName = 'John Doe'";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    int rowsUpdated = updateCommand.ExecuteNonQuery();
                    Console.WriteLine($"Filas actualizadas: {rowsUpdated}");

                    // Ejemplo de eliminación de datos (comando DELETE)
                    string deleteQuery = "DELETE FROM Customers WHERE CustomerName = 'Jane Doe'";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    int rowsDeleted = deleteCommand.ExecuteNonQuery();
                    Console.WriteLine($"Filas eliminadas: {rowsDeleted}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                }
            }

            Console.WriteLine("Conexión cerrada.");
        }
    }
}
