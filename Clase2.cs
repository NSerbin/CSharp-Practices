// Ex 2: Crea un programa que diga el resultado de sumar 200 y 56.

using System;

namespace Ex2
{
public class Suma
    {
        public static void Main( string[] args)
        {
            int suma = 200 + 56;
            Console.WriteLine("El resultado es: " + suma);
        }
    }
}


// Ex 3: Haz un programa que calcule el producto de los números 13 y 12.

using System;

namespace Ex3
{
    public class Producto
    {
        public static void Main(string[] args)
        {
            int producto = 13 * 12;
            Console.WriteLine("El Producto de los numeros 13 y 12 es: " + producto);
        }
    }
}


// Ex 4: Un programa que calcule la diferencia (resta) entre 321 y 213

using System;

namespace Ex4
{
    public class Resta
    {
        public static void Main(string[] args)
        {
            int resta = 312 - 213;
            Console.WriteLine("La Diferencia entre 312 y 213 es: " + resta);
        }
    }
}


// Ex 5: Calcular el resultado de(20+5) % 6

using System;

namespace Ex5
{
    public class Division
    {
        public static void Main(string[] args)
        {
            int suma = 20 + 5;
            int resultado = suma % 6;
            Console.WriteLine("El resultado final es: " + resultado);
        }
    }
}


// Ex 6: Crea un programa que calcule el producto de los números 12 y 102, usando
// variables.

using System;

namespace Ex6
{
public class Producto
    {
        public static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 102;
            int producto = num1 * num2;
            Console.WriteLine("El Producto es: " + producto);
        }
    }
}


// Ex 7: Crea un programa que calcule la suma de 200 y 1111, usando variables.

using System;

namespace Ex7
{
public class Suma
    {
        public static void Main(string[] args)
        {
            int num1 = 200;
            int num2 = 1111;
            int suma = num1 + num2;
            Console.WriteLine("La Suma es de: " + suma);
        }
    }
}


// Ex 8: Crea un programa que calcule el producto de los números 10 y 25, usando
// variables llamadas "numero1" y "numero2"

using System;

namespace Ex8
{
public class MainClass
    {
        public static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 25;
            int producto = numero1 + numero2;
            Console.WriteLine("El Producto es: " + producto);
        }
    }
}


// Ex 9: Crea un programa que calcule el producto de dos números introducidos por 
// el usuario.

using System;

namespace Ex9
{
 public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Número: ");
            int num2 = int.Parse(Console.ReadLine());
            int producto = num1 * num2;
            Console.WriteLine("El producto de:" + num1 + "*" + num2 + "es" + producto)
        }
    }
}


// Ex 10: Crea un programa que pida al usuario un número entero y diga si es par 
// (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es 
// cero: if (x % 2 == 0) …).

using System;

namespace Ex10
{
public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Es un número Par");
            }
            else
            {
                Console.WriteLine("Es un número Impar");
            }
        }
    }
}


// Ex 11: Crea un programa que pida al usuario dos números enteros y diga cuál es
// el mayor de ellos.

using System;

namespace Ex11
{
public class Mayor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Primer Numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es" + numero1);
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("El numero mayor es " + numero2);
            }
            else
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}


// Ex 12: Crea un programa que pida al usuario dos números enteros. Si el segundo 
// no es cero, mostrará el resultado de dividir entre el primero y el segundo.
// Por el contrario, si el segundo número es cero, escribirá 
// "Error: No se puede dividir entre cero"

using System;

namespace Ex12
{
public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            int division = numero1 / numero2;
            if (numero2 != 0)
            {
                Console.WriteLine("El resultado es: " + division);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
        }
    }
}


// Ex 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
// nombre de ese número, usando "switch" 
// (por ejemplo, si introduce "1", el programa escribirá "uno").

using System;

namespace Ex13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 5");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
            }
        }
    }
}


// Ex 14: Crea un programa que escriba en pantalla los números del 1 al 10, usando
// "While"

using System;

namespace Ex14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (i <11)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}


// Ex 15: Crea un programa que escriba en pantalla los números del 1 al 10, usando
// "do..while"

using System;

namespace Ex15
{
public class DoWhile
    {
        public static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 11);
        }
    }
}


// Ex 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos,
// usando “for".

using System;

namespace Ex16
{
public class MainClass
    {
        public static void Main(string[] args)
        {
            for (int x = 10; x <= 20; x++);
            {
                Console.WriteLine(x);
            }
        }
    }
}