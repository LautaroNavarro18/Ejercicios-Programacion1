using System;  
using System.Collections.Generic;
using System.Linq;
/*
EJERCICIO 1
 * 
int[] numero = new int[5];
numero[0] = 10;
numero[1] = 20;
numero[2] = 30;
numero[3] = 40;
numero[4] = 50;

int suma = 0;

for (int i=0; i < 5; i++)
{
    suma += numero[i];
}   

Console.WriteLine($"La suma es: {suma}" );   

EJERCICIO 2

List<int> notas = new List<int>();
int p = 0;
int s = 0;
for (int i = 0; i < 10; i++)
{     Console.WriteLine("Ingrese una nota: ");
    int nota = int.Parse(Console.ReadLine());
    notas.Add(nota);
    s += nota; 
}
p = s / 10;

Console.WriteLine($"El promedio es: {p}");

*/

int[] numero = new int[5];
numero[0] = 10;
numero[1] = 20;
numero[2] = 30;
numero[3] = 40;
numero[4] = 50;


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    int num = int.Parse(Console.ReadLine());
    if (num == numero[i])
    {
        Console.WriteLine($"El numero {num} se encuentra en el arreglo");

    }
    else
    {
        Console.WriteLine($"El numero {num} no se encuentra en el arreglo");
    }
}

