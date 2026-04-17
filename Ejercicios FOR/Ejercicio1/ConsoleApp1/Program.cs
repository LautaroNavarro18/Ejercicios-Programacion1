int suma = 0;
for (int i =0; i < 5; i++)
{     Console.WriteLine("Ingrese un numero: ");
    int numero = int.Parse(Console.ReadLine());
    suma += numero;
}
Console.WriteLine($"La suma de los numeros es: {suma}");