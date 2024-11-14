using System;
using System.Collections.Generic;

// Interfaz del Observador
public interface IObserver
{
    void Update(string message);
}

// Clase ConcreteObserver
public class ConcreteObserver : IObserver
{
    private string _name;

    public ConcreteObserver(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} ha recibido el mensaje: {message}");
    }
}

// Interfaz del Sujeto
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

// Clase ConcreteSubject
public class ConcreteSubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Notify();  // Notificar a los observadores cuando cambia el estado
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_state);
        }
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Crear el sujeto
        ConcreteSubject subject = new ConcreteSubject();

        // Crear los observadores
        ConcreteObserver observer1 = new ConcreteObserver("Observador 1");
        ConcreteObserver observer2 = new ConcreteObserver("Observador 2");

        // Adjuntar los observadores al sujeto
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Cambiar el estado del sujeto y notificar a los observadores
        subject.State = "El estado ha cambiado a 'ACTIVO'.";

        // Desvincular un observador y cambiar el estado
        subject.Detach(observer1);
        subject.State = "El estado ha cambiado a 'INACTIVO'.";

        Console.ReadLine();
    }
}
