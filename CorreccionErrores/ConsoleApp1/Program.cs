/* IMAGEN 1 

public class Vehiculo
{
    public string Marca { get; set; }

    public Vehiculo(string marca)
    {
        Marca = marca;
    }
}

public class Auto : Vehiculo
{
    public int Puertas { get; set; }

    public Auto(string marca, int puertas) : base(marca) 
    {
        Puertas = puertas;
    }
}

IMAGEN 2

public class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public double Sumar(double x, double y)  
    {
        return x + y;
    }
}

IMAGEN 3

public class Trabajador
{
    public virtual void RealizarTarea()  
    {
        Console.WriteLine("El trabajador hace tareas generales.");
    }
}

public class Programador : Trabajador
{
    public override void RealizarTarea()
    {
        Console.WriteLine("El programador escribe código en C#.");
    }
}

IMAGEN 4

public class Termometro
{
    public double Temperatura { get; private set; }  

    public Termometro()
    {
        Temperatura = 20.0;
    }

    public void Actualizar(double lecturaSensor)
    {
        if (lecturaSensor >= -50.0 && lecturaSensor <= 100.0)
        {
            Temperatura = lecturaSensor;
        }
        else
        {
            Console.WriteLine("Error: Lectura extrema ignorada.");
        }
    }
}

IMAGEN 5

public interface INotificable
{
    void EnviarMensaje(string texto);
    void Resetear();
}

public class CorreoElectronico : INotificable
{
    public void EnviarMensaje(string texto)
    {
        Console.WriteLine($"Enviando mail: {texto}");
    }

    public void Resetear() 
    {
        Console.WriteLine("Correo reseteado.");
    }
}

IMAGEN 6

public class Motor
{
    public void Encender() { Console.WriteLine("Encendido!"); }
}

public class Coche
{
    public Motor MotorDelCoche { get; set; }

    public Coche()
    {
        MotorDelCoche = new Motor();  
    }

    public void Arrancar()
    {
        MotorDelCoche.Encender();
    }
}
