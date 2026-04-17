int suma = 0;
int prom = 0;
for (int i = 0; i < 8; i++)
{ Console.WriteLine("Ingrese un numero: ");
    int num = int.Parse(Console.ReadLine());
    suma = suma + num;
    prom = i;
}
prom = suma / prom;
Console.WriteLine($"El promedio es : {prom}");

