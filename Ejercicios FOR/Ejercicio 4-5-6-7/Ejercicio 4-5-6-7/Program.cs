/*
 * Ejercicio 4
 * 
 * int max = 0;
for (int i = 0; i < 8; i++)
{     Console.WriteLine("Ingrese un número:");
    int numero = int.Parse(Console.ReadLine());
    if (max < numero)
    {
        max = numero;
    }
}
Console.WriteLine($"El número mayor es: {max}");

Ejercicio 5

string n = "";
int max = 0;
for (int i =0; i < 5; i++)
{ Console.WriteLine("Ingrese el nombre del cliente: ");
    string nombre = Console.ReadLine();
   Console.WriteLine("Ingrese el monto de la compra: ");
    int num = int.Parse(Console.ReadLine());
    if (max < num)
    {
        max = num;
        n = nombre; 
    }
}
Console.WriteLine($"El cliente que gasto más es : {n}");

Ejercicio 6

Console.WriteLine("Ingrese un número: "); 
int n = int.Parse(Console.ReadLine());
int factorial = 1;
for (int i = 1; i < n + 1; i++)
{
    factorial = factorial * i;
}
Console.WriteLine($"El factorial de {n} es {factorial}");
/*
