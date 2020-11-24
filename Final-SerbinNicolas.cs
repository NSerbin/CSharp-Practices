using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace EDDatosFinal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int opcion = 0;
            int loop = 0;
            Stack MiPatentes = new Stack();
            do
            {
                Console.Clear();
                Console.WriteLine("[*] Bienvenido al Centro de Monitoreo de Patentes [*]");
                Console.WriteLine("[*] del Gobierno de la Ciudad de Buenos Aires...[*]");
                Console.WriteLine("[*] Para crear una Pila, Marque 1 [*]");
                Console.WriteLine("[*] Para borrar una Pila, Marque 2 [*]");
                Console.WriteLine("[*] Para Agregar Patente, Marque 3 [*]");
                Console.WriteLine("[*] Para Borrar Patente, Marque 4 [*]");
                Console.WriteLine("[*] Para Listar Todas las Patentes, Marque 5 [*]");
                Console.WriteLine("[*] Para Listar Última Patente, Marque 6 [*]");
                Console.WriteLine("[*] Para Listar Primera Patente, Marque 7 [*]");
                Console.WriteLine("[*] Para Ver Cantidad de Patentes, Marque 8 [*]");
                Console.WriteLine("[*] Para Salir, Marque 9 [*]");
                Console.WriteLine("[*] Para Buscar una Patente, Marque 10 [*]");
                Console.WriteLine("[*] Para Listar Primeras 3 Patentes, Marque 11 [*]");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Crearemos una Pila...[*]");
                        // PILA o LIFO
                        MiPatentes = new Stack();
                        Console.WriteLine("La Pila ya fue creada");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Borraremos una Pila...[*]");
                        // BORRADO DE LA PILA o LIFO
                        MiPatentes.Clear();
                        Console.WriteLine("La Pila Fue borrada, la cantidad de patentes es: {0}", MiPatentes.Count);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Agregaremos una Patente...[*]");
                        Console.WriteLine("Por Favor, Ingrese la patente: ");
                        string patente = Console.ReadLine();
                        // Sentencia que revisa si la patente contiene 3 digitos de la A-Z y 3 digitos de 0-9
                        if (!Regex.IsMatch(patente, "^[a-z-A-Z]{3}[0-9]{3}$"))
                        {
                            Console.WriteLine("Patente ingresada INCORRECTA. Debe tener 3 caracteres de A-Z y 3 Caracteres numericos de 0-9");
                        }
                        else
                        {
                            MiPatentes.Push(patente);
                            Console.WriteLine("La patente {0} fue agregada con éxito.", patente);
                        };
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Borraremos una Patente...[*]");
                        MiPatentes.Pop();
                        loop = 0;
                        foreach (string patentes in MiPatentes)
                        {
                            loop++;
                            Console.WriteLine("Ahora quedan disponibles:");
                            Console.WriteLine("{0} - {1}", loop, patentes); 
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Listaremos Todas Las Patentes...[*]");
                        loop = 0;
                        foreach (string patentes in MiPatentes)
                        {
                            loop++;
                            Console.WriteLine("Las patentes cargadas son:");
                            Console.WriteLine("{0} - {1}", loop, patentes);
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Listaremos La Última Patente...[*]");
                        //Sirve para Listar el Ultimo ELEMENTO sin necesidad de Borrarlo
                        Object[] arr = MiPatentes.ToArray();
                        Console.WriteLine("La última Patente es {0}", arr[arr.Length - 1]);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Listaremos La Primera Patente...[*]");
                        //Sirve para Listar 1er elemento SIN necesidad de borrarlo
                        Console.WriteLine("La primer Patente es {0}", MiPatentes.Peek());
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Listaremos el Total de Patentes...[*]");
                        // Sirve para contar la cantidad de elementos dentro de la Pila
                        Console.WriteLine("La cantidad de Patentes Almacenadas es {0}", MiPatentes.Count);
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("[*] Que tenga un Buen dia !!! [*]");
                        Environment.Exit(0);
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Buscaremos una Patente especifica...[*]");
                        Console.WriteLine("Ingrese los parametros a buscar: ");
                        // Sirve para buscar elementos con caracteres especificos dentro de la Pila
                        string valor = Console.ReadLine();
                        Console.WriteLine("Las patentes encontradas son {0}", MiPatentes.Contains(valor));
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("[*] A continuación Listaremos Las Primeras 3 Patentes...[*]");
                        Object[] arr2 = MiPatentes.ToArray();
                        Console.WriteLine("La Primer Patente es {0}", arr2[0]);
                        Console.WriteLine("La última Patente es {0}", arr2[1]);
                        Console.WriteLine("La última Patente es {0}", arr2[2]);
                        Console.ReadKey();
                        break;
                } 
            } while (opcion != 9);
        }
    }

}