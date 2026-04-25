using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
/*


List<int> usuario = new List<int>();
int total1 = 0;
int total2 = 0;
int total3 = 0;
int total4 = 0;
int total5 = 0;

int calificacion = -1;

do
{
    Console.WriteLine("ingrese calificacion del servicio 1-5 o 0 para salir: ");
    calificacion = int.Parse(Console.ReadLine());

    if (calificacion == 1)
    {
        usuario.Add(calificacion);
        total1++;
    }
    else if (calificacion == 2)
    {
        usuario.Add(calificacion);
        total2++;
    }
    else if (calificacion == 3)
    {
        usuario.Add(calificacion);
        total3++;
    }
    else if (calificacion == 4)
    {
        usuario.Add(calificacion);
        total4++;
    }
    else if (calificacion == 5)
    {
        usuario.Add(calificacion);
        total5++;
    }
    else if (calificacion != 0) // 0 es la señal para salir, no mostrar "inválida"
    {
        Console.WriteLine("calificacion invalida, por favor ingrese un numero entre 1 y 5.");
    }
} while (calificacion != 0);

int total = usuario.Count;

Console.WriteLine("\nPorcentajes:");

if (total > 0)
{
    Console.WriteLine("1: " + (total1 * 100.0 / total) + "%");
    Console.WriteLine("2: " + (total2 * 100.0 / total) + "%");
    Console.WriteLine("3: " + (total3 * 100.0 / total) + "%");
    Console.WriteLine("4: " + (total4 * 100.0 / total) + "%");
    Console.WriteLine("5: " + (total5 * 100.0 / total) + "%");
}
else
{
    Console.WriteLine("No se ingresaron datos.");
}
*/

List<int> usuarios = new List<int>();
int calificacion = 0;

Console.WriteLine("Ingresá la calificación de cada usuario (1-5).");
Console.WriteLine("Presioná 0 para terminar.\n");

do
{
    Console.Write($"Usuario {usuarios.Count + 1} - Calificación: ");
    calificacion = int.Parse(Console.ReadLine());

    if (calificacion == 0)
        break;

    if (calificacion >= 1 && calificacion <= 5)
        usuarios.Add(calificacion);
    else
        Console.WriteLine("Calificación inválida, tiene que ser entre 1 y 5.");

} while (calificacion != 0);

if (usuarios.Count > 0)
{

    for (int i = 1; i <= 5; i++)
    {
        int c = 0;
        for (int j = 0; j < usuarios.Count; j++)
        {
            if (usuarios[j] == i)
                c++;
        }

        int p = c * 100 / usuarios.Count;
        Console.WriteLine($"{numero}: {p}%");
    }
}

