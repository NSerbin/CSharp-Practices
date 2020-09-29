// Ex 1: Crea un programa que pida al usuario su identificador y su contraseña 
// (ambos numéricos), y no le permita seguir hasta que introduzca como 
// identificador "1234" y como contraseña "1111".

using System;

namespace EDDClase3
{
    class Identificador
    {
        public static void Main(string[] args)
        {
            int id = 1234;
            int val1;
            int pwd = 1111;
            int val2;

            do
            {
                Console.WriteLine("Ingrese su Identificador numérico: ");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su contraseña: ");
                val2 = Convert.ToInt32(Console.ReadLine());
            } while (id != val1 || pwd != val2);

            Console.WriteLine("Identificador Aceptado.");
            Console.WriteLine("Contraseña Aceptada.");
            Console.ReadKey();

        }
    }
}

// Ex 2: Crea un programa calcule cuantas cifras tiene un número entero positivo 
// (pista: se puede hacer dividiendo varias veces entre 10).

using System;

namespace EDDClase3
{
    class ContadorCifras
    {
        public static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            while (contador > 0)
            {
                numero = numero / 10;
                contador = contador++;
            }

            Console.WriteLine("El numero {0} tiene {1} digitos", numero, contador);
            Console.ReadKey();
        }
    }
}


// Ex 3: Crea un programa que muestre la tabla de multiplicar del 9.

using System;

namespace EDDClase3
{
    class TablaMultiplicar
    {
        public static void Main(string[] args)
        {
            int numero = 9;
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine(numero + " * " + x + "=" + (x + numero));
                Console.ReadKey();
            }
        }
    }

// Ex 4: Crea un programa que contenga un bucle sin fin que muestre los números 
// enteros positivos a partir del uno. 

    using System;

    namespace EDDClase3
    {
        class BucleNumPositivos
        {
            public static void Main(string[] args)
            {
                for (int x = 0; ; x++)
                {
                    Console.WriteLine(x);
                    Console.ReadKey();
                };
            }
        }
    }


// Ex 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en 
// pantalla, sin avanzar de línea.

    using System;

    namespace EDDClase3
    {
        class BucleHola
        {
            public static void Main(string[] args)
            {
                for (; ; )
                {
                    Console.Write("Hola");
                    Console.ReadKey();
                }
        }
    }
    }


// Ex 6: ¿Cuál sería el resultado de las siguientes operaciones? 
// a=5; b=++a; c=a++; b=b*5; a=a*2; Crea un programa que lo resuelva.

using System;

namespace EDDClase3
{
    class OperacionesUno
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = ++a;
            c = a++;
            b = b * 5;
            a = a * 2;
            Console.WriteLine("Los resultados son" + a + " "+ b + " " + c);
            Console.ReadKey();

        }
    }
    }


// Ex 7: ¿Cuál sería el resultado de las siguientes operaciones? 
// a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.

using System;

namespace EDDClase3
{
    class OperacionesDos
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = a + 2;
            b -= 3;
            c = -3;
            c *= 2;
            ++c;
            a *= b;
            Console.WriteLine("Los resultados son" + a + b + c);
            Console.ReadKey();
            }
    }
    }


// Ex 8: Crea un programa que pida una letra al usuario y diga si se trata de una 
// vocal.

using System;

namespace EDDClase3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra: ");
            string vocal = Console.ReadLine();
            if (vocal == "a" || vocal == "e" || vocal == "i" || vocal == "o" || vocal == "u");
            {
                Console.WriteLine(vocal + "Es una vocal");
                Console.ReadKey();
                }
            else
            {
                Console.WriteLine(vocal + "NO Es una vocal");
                Console.ReadKey();
                }

        }
    }
    }


// Ex 9: Crear un programa que pida al usuario un nombre y una contraseña. 
// La contraseña se debe introducir dos veces. Si las dos contraseñas no son 
// iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas.

using System;

namespace EDDClase3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Ingrese su usuario:");
                string user = Console.ReadLine();
                while (passwd != passwd2)
            {
                Console.WriteLine("Ingrese su contraseña: ");
                int passwd = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.WriteLine("Ingrese nuevamente su contraseña: ");
                int passwd2 = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.WriteLine("Contraseña incorrecta, ingrese nuevamente ");
                }
        }
    }
    }


// Ex 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se 
// llama "Martín", o bien le diga "No te conozco" si teclea otro nombre

using System;

namespace EDDClase3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Usiario: ");
            string user = Console.ReadLine();
            if (user == "Martín");
                {
                    Console.WriteLine("Hola", user);
                    Console.ReadKey();
                }
            else
                {
                    Console.WriteLine("No te conozco", user);
                    Console.ReadKey();
                }

            }
    }
}


