using System;

// Producto: La interfaz común para todos los vehículos
public interface IVehiculo
{
    void Conducir();
}

// Producto concreto: Carro
public class Carro : IVehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo un carro.");
    }
}

// Producto concreto: Motocicleta
public class Motocicleta : IVehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo una motocicleta.");
    }
}

// Creador: La clase abstracta con el método de fábrica
public abstract class Creador
{
    public abstract IVehiculo CrearVehiculo();
}

// Creador concreto: Creador de carros
public class CreadorCarro : Creador
{
    public override IVehiculo CrearVehiculo()
    {
        return new Carro();
    }
}

// Creador concreto: Creador de motocicletas
public class CreadorMotocicleta : Creador
{
    public override IVehiculo CrearVehiculo()
    {
        return new Motocicleta();
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Creador de carros
        Creador creadorCarro = new CreadorCarro();
        IVehiculo carro = creadorCarro.CrearVehiculo();
        carro.Conducir();  // Salida: Conduciendo un carro.

        // Creador de motocicletas
        Creador creadorMotocicleta = new CreadorMotocicleta();
        IVehiculo motocicleta = creadorMotocicleta.CrearVehiculo();
        motocicleta.Conducir();  // Salida: Conduciendo una motocicleta.

        Console.ReadLine();
    }
}
