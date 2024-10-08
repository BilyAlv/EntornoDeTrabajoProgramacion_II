using System;

namespace Excepciones;

    // Excepción personalizada para un nombre de usuario inválido
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message) : base(message)
        {
        }
    }

    // Excepción personalizada para una contraseña inválida
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el nombre de usuario: ");
                string username = Console.ReadLine();

                Console.Write("Ingrese la contraseña: ");
                string password = Console.ReadLine();

                ValidarCredenciales(username, password);
                Console.WriteLine("Credenciales válidas. ¡Bienvenido!");
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("El proceso de validación ha finalizado.");
            }
        }

        static void ValidarCredenciales(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new InvalidUsernameException("El nombre de usuario no debe estar vacío.");
            }

            if (password.Length < 8)
            {
                throw new InvalidPasswordException("La contraseña debe tener al menos 8 caracteres.");
            }
        }
    }
