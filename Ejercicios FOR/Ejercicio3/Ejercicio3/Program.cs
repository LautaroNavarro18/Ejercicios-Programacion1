int costo = 0;
int cant = 0;
int total = 0;
for (int i = 0; i < 5; i++)
    {   Console.WriteLine("Ingrese el costo del producto: ");
    costo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad del producto: ");
    cant = int.Parse(Console.ReadLine());
    total = total + (costo * cant);
}
Console.WriteLine($"El total a pagar es: {total}");