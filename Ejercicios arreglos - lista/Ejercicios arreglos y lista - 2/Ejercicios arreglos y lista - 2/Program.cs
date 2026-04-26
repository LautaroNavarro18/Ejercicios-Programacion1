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
/
EJERCICIO 1

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

EJERCICIO 2

List<string> alumnos = new List<string>();
string curso = "";

Console.WriteLine("Registrá alumnos ingresando el curso A, B o C.");
Console.WriteLine("Presioná Enter sin escribir nada para terminar.\n");

do
{
    Console.Write($"Alumno {alumnos.Count + 1} - Curso: ");
    curso = Console.ReadLine();

    if (curso == "")
        break;

    if (curso == "A" || curso == "a" || curso == "B" || curso == "b" || curso == "C" || curso == "c")
        alumnos.Add(curso);
    else
        Console.WriteLine("Curso inválido, tiene que ser A, B o C.");

} while (curso != "");

if (alumnos.Count > 0)
{
    int A = 0;
    int B = 0;
    int C = 0;
    for (int i = 0; i < alumnos.Count; i++)
    {
        if (alumnos[i] == "A" || alumnos[i] == "a") 
            A++;
        if (alumnos[i] == "B" || alumnos[i] == "b")
            B++;
        if (alumnos[i] == "C"|| alumnos[i] == "c")  
            C++;
    }
    Console.WriteLine($"Curso A: {A}");
    Console.WriteLine($"Curso B: {B}");
    Console.WriteLine($"Curso C: {C}");
}

EJERCICIO 3 


int[] num = new int[7];

for (int i = 0; i < 7; i++)
{
    Console.Write($"Ingrese el número en la posición {i}: ");
    num[i] = int.Parse(Console.ReadLine());
}

bool verificacion = true;

for (int i = 0; i < num.Length/2; i++)
{
    if (num[i] != num[num.Length - 1 - i])
    {
        verificacion = false;
        break;
    }
}

if (verificacion == true)
{
    Console.WriteLine("El arreglo se lee igual de izquierda a derecha que de derecha a izquierda");
}
else
{
    Console.WriteLine("El arraeglo no se lee igual");
}

EJERCICIO 4

List<int> num = new List<int>();
string num1 = "";

Console.WriteLine("Ingresá números enteros.");
Console.WriteLine("Presioná Enter sin escribir nada para terminar.\n");

do
{
    Console.Write($"Número {num.Count + 1}: ");
    num1 = Console.ReadLine();

    if (num1 == "")
        break;

    num.Add(int.Parse(num1));

} while (num1 != "");

Console.WriteLine("Lista sin valores duplicados: \n");

for (int i = 0; i < num.Count; i++)
{
    for (int j = i+1; j < num.Count; j++)
    {
        if (num[i] == num[j])
        {
            num.Remove(num[j]);
            j--; 
        }
    }
}

for (int i = 0; i < num.Count; i++)
    Console.WriteLine(num[i]);

EJERCICIO 5

List<int> num = new List<int>();
string num1 = "";

Console.WriteLine("Ingresá números enteros.");
Console.WriteLine("Presioná Enter sin escribir nada para terminar.\n");

do
{
    Console.Write($"Número {num.Count + 1}: ");
    num1 = Console.ReadLine();

    if (num1 == "")
        break;

    num.Add(int.Parse(num1));

} while (num1 != "");

for (int i = 0; i < num.Count - 1; i++)
{
    for (int j = 0; j < num.Count - i - 1; j++)
    {
        if (num[j] > num[j + 1])
        {
            int aux = num[j];
            num[j] = num[j + 1];
            num[j + 1] = aux;
        }
    }
}
for (int i = 0; i < num.Count; i++)
{
    Console.WriteLine(num[i]);
}

EJERCICIO 6

List<int> num = new List<int>();
string num1 = "";

Console.WriteLine("Ingresá números enteros.");
Console.WriteLine("Presioná Enter sin escribir nada para terminar.\n");

do
{
    Console.Write($"Número {num.Count + 1}: ");
    num1 = Console.ReadLine();

    if (num1 == "")
        break;

    num.Add(int.Parse(num1));

} while (num1 != "");

int ultimo = num[num.Count - 1];

for (int i = num.Count - 1; i > 0; i--)
    num[i] = num[i - 1];

num[0] = ultimo;

for (int i = 0; i < num.Count; i++)
{
    Console.WriteLine(num[i]);
}

EJERCICIO 7

Console.Write("Ingresá una frase: ");
string frase = Console.ReadLine().ToLower(); // ToLower Convierte a minúsculas todal las letras para contar palabras sin importar mayúsculas o minúsculas

string[] palabras = frase.Split(' ');// .Split Divide la frase en palabras usando el espacio (' ') como separador

List<string> palabras1 = new List<string>();
List<int> cantidad = new List<int>();

for (int i = 0; i < palabras.Length; i++)
{
    bool repetida = false;

    for (int j = 0; j < palabras1.Count; j++)
    {
        if (palabras1[j] == palabras[i])
        {
            cantidad[j]++;
            repetida = true;
            break;
        }
    }

    if (repetida == false)
    {
        palabras1.Add(palabras[i]);
        cantidad.Add(1);
    }
}

for (int i = 0; i < palabras1.Count; i++) 
{
    Console.WriteLine($"{palabras1[i]}: {cantidad[i]}");
}

EJERCICIO 8

List<int> num = new List<int>();

Console.WriteLine("Ingresá 10 números entre 1 y 20 sin repetir.\n");

while (num.Count < 10)
{
    Console.Write($"Número {num.Count + 1}: ");
    int num1 = int.Parse(Console.ReadLine());

    if (num1 < 1 || num1 > 20)
    {
        Console.WriteLine("Tiene que ser entre 1 y 20.");
        continue;
    }

    bool encontrado = false;

    for (int i = 0; i < num.Count; i++)
    {
        if (num[i] == num1)
        {
            encontrado = true;
            break;
        }
    }

    if (encontrado)
        Console.WriteLine("Ese número ya fue ingresado.");
    else
        num.Add(num1);
}

for (int i = 0; i < num.Count; i++)
{
    Console.WriteLine($"{num[i]}");
}

EJERCICIO 9
*/
List<string> tareas = new List<string>();
List<string> estados = new List<string>();

int opcion = 0;

while (opcion != 5)
{
    Console.WriteLine("1. Ver tareas");
    Console.WriteLine("2. Agregar tarea");
    Console.WriteLine("3. Eliminar tarea");
    Console.WriteLine("4. Cambiar estado");
    Console.WriteLine("5. Salir");
    Console.Write("Elegí una opción: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas registradas.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
                Console.WriteLine($"{i + 1}. [{estados[i]}] {tareas[i]}");
        }
    }
    else if (opcion == 2)
    {
        Console.Write("Descripción de la tarea: ");
        string nueva = Console.ReadLine();
        tareas.Add(nueva);
        estados.Add("Pendiente");
        Console.WriteLine("Tarea agregada.");
    }
    else if (opcion == 3)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
                Console.WriteLine($"{i + 1}. [{estados[i]}] {tareas[i]}");

            Console.Write("Número de tarea a eliminar: ");
            int num = int.Parse(Console.ReadLine()) - 1;

            if (num >= 0 && num < tareas.Count)
            {
                Console.WriteLine($"Tarea '{tareas[num]}' eliminada.");
                tareas.RemoveAt(num);
                estados.RemoveAt(num);
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }
    else if (opcion == 4)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
                Console.WriteLine($"{i + 1}. [{estados[i]}] {tareas[i]}");

            Console.Write("Número de tarea a cambiar: ");
            int num = int.Parse(Console.ReadLine()) - 1;

            if (num >= 0 && num < tareas.Count)
            {
                if (estados[num] == "Pendiente")
                    estados[num] = "Completada";
                else
                    estados[num] = "Pendiente";

                Console.WriteLine($"Estado cambiado a: {estados[num]}");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }
    else if (opcion != 5)
    {
        Console.WriteLine("Opción inválida.");
    }
}
