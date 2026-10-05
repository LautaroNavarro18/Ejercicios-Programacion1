using System.Diagnostics.CodeAnalysis;
using System.Timers;

List<float> temp = new List<float>();
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Ingrese la temperatura del día {i + 1} :");
    string num = Console.ReadLine();
    if( num.Contains ( "," ) )
    { 
        float num2 = float.Parse(num);
        temp.Add(num2);
    }
    else
    {
        Console.WriteLine("No ingresaste un numero con coma");
        i--;
    }
} 
Console.WriteLine($"El promedio de las temperaturas es: {temp.Average()}");
int Suma = 0;
int menor = 0;
for (int i = 0; i < temp.Count; i ++)
{
    if ( temp [i] > temp.Average())
    {
        Suma ++;
    }
    else
    {
        menor++;
    }

    }
Console.WriteLine($"La cantidad de días con temperatura mayor al promedio es: {Suma}");
Console.WriteLine($"La cantidad de días con temperatura menor al promedio es: {menor}");
