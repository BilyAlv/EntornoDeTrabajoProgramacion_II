using System;
using System.Data.SqlClient;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;
    private SqlConnection _connection;
    private string _connectionString = "Server=AL-HP; Database=MiBaseDeDatos; Integrated Security=True;";

    // Constructor privado para evitar la creación directa de instancias
    private DatabaseConnection()
    {
        // Inicialización de la conexión a la base de datos
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
        Console.WriteLine("Conexión a la base de datos establecida.");
    }

    // Método para obtener la instancia única
    public static DatabaseConnection GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DatabaseConnection();
        }
        return _instance;
    }

    // Método para realizar una consulta a la base de datos
    public void QueryDatabase()
    {
        try
        {
            // Consulta SQL de ejemplo
            string query = "SELECT COUNT(*) FROM Usuarios";  
            SqlCommand command = new SqlCommand(query, _connection);
            int count = (int)command.ExecuteScalar();
            Console.WriteLine($"Número de usuarios en la base de datos: {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al consultar la base de datos: {ex.Message}");
        }
    }

    // Método para cerrar la conexión cuando ya no se necesite
    public void CloseConnection()
    {
        _connection.Close();
        Console.WriteLine("Conexión cerrada.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Obtener la instancia única de la clase DatabaseConnection
        DatabaseConnection connection = DatabaseConnection.GetInstance();
        connection.QueryDatabase();

        // Intentar obtener otra instancia (será la misma)
        DatabaseConnection connection2 = DatabaseConnection.GetInstance();
        connection2.QueryDatabase();

        // Confirmar que ambas instancias son la misma
        Console.WriteLine(ReferenceEquals(connection, connection2)); // Debería imprimir 'True'

        // Cerrar la conexión cuando ya no se necesite
        connection.CloseConnection();
    }
}
