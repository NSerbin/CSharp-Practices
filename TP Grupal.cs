using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[*] Bienvenido al servicio de Atencion al cliente de Personal...");
            Console.WriteLine("[*] Por favor, ingrese su numero de línea para continuar...");
            Console.WriteLine("[*] Ingrese el Código de área + número sin el 15.");
            string user = Console.ReadLine();
            string salir = "";
            while (salir != "si")
            {
                if (user.Length >= 10 && user[0] > '0' && user[1] != '5')
                {
                    Console.WriteLine("[*] Su número ingresado es {0}, si es correcto presione 1, caso contrario presione 2.", user);
                    int UserData = int.Parse(Console.ReadLine());
                    if (UserData == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido {0}, elija la opcion deseada...", user);
                        Console.WriteLine("[*] Por saldos y vencimientos de la cuenta, Marque 1");
                        Console.WriteLine("[*] Consultar Unidades de Internet, Voz o SMS, Marque 2");
                        Console.WriteLine("[*] Pagar tu linea con tarjeta de credito o debito, Marque 3");
                        Console.WriteLine("[*] Otras Consultas, Marque 4");
                        int subMenu = int.Parse(Console.ReadLine());
                        switch (subMenu)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("[*] El saldo de tu cuenta es de $350, tu proxima factura vence el día 10/11/2020 con un importe de $500");
                                Console.WriteLine("[*] Muchas gracias por confiar en PERSONAL.");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("[*] En tu linea tenes disponible:");
                                Console.WriteLine("[*]    |   1GB de Internet 4G.                  |");
                                Console.WriteLine("[*]    |   100 min de mensajes de VOZ.          |");
                                Console.WriteLine("[*]    |   500 SMS para todas las compañias.    |");
                                Console.WriteLine("[*] Muchas gracias por confiar en PERSONAL.");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("[*] Para pagar su plan ahora, marque 1...");
                                Console.WriteLine("[*] Para escucharlo nuevamente, marque 2...");
                                Console.WriteLine("[*] Para informar un pago, marque 3...");
                                Console.WriteLine("[*] Para finalizar, marque 4...");
                                int op3 = int.Parse(Console.ReadLine());
                                switch (op3)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("[*] Para abonar con Tarjeta de Credito o Debito, marque 1");
                                        int op3abonar = int.Parse(Console.ReadLine());
                                        switch (op3abonar)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("[*] Para CONFIMAR el pago con tu tarjeta asociada confirma tu número de teléfono: ");
                                                int op3abonarConf = int.Parse(Console.ReadLine());
                                                switch (op3abonarConf)
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        Console.WriteLine("[*] Su PAGO fue aprobado.");
                                                        Console.WriteLine("[*] Muchas gracias por confiar en PERSONAL.");
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("[*] El saldo de tu cuenta es de: ");
                                        Console.WriteLine("[*]    |   1GB de Internet 4G.                  |");
                                        Console.WriteLine("[*]    |   100 min de mensajes de VOZ.          |");
                                        Console.WriteLine("[*]    |   500 SMS para todas las compañias.    |");
                                        Console.WriteLine("[*] Muchas gracias por confiar en PERSONAL.");
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("[*] Si acaba de realizar un pago y aún no lo puede vizualisar en su cuenta marque 1:");
                                        int op3abonarConfirmar = int.Parse(Console.ReadLine());
                                        switch (op3abonarConfirmar)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("[*] ________________________________");
                                                Console.WriteLine("[*] |                              |");
                                                Console.WriteLine("[*] |  Su PAGO a sido CONFIRMADO   |");
                                                Console.WriteLine("[*] |______________________________|");
                                                break;
                                        }
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("[*] Muchas gracias por confiar en PERSONAL");
                                        Console.WriteLine("[*] PERSONAL la red 4G más rápida del PAÍS");
                                        break;
                                }
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("[*] Para conocer medios de pago, marque 1...");
                                Console.WriteLine("[*] Para adquirir un plan con mas gb o consultar sobre beneficios club personal, marque 2...");
                                Console.WriteLine("[*] Si te robaron o perdiste el celular, marque 3...");
                                Console.WriteLine("[*] Para comunicarte con un representante de atencion al cliente, marque 4...");
                                int op4 = int.Parse(Console.ReadLine());
                                switch (op4)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("[*] Puede pagar su factura con Tarjetas de Credito y Debito");
                                        Console.WriteLine("[*] VISA, MASTERCARD, AMERICAN EXPRESS");
                                        Console.WriteLine("[*] Puede pagar su factura con PAGOMISCUENTAS");
                                        Console.WriteLine("[*] Puede pagar su factura con LINK PAGOS");
                                        Console.WriteLine("[*] Puede pagar su factura con TODOPAGO");
                                        Console.WriteLine("[*] Puede pagar su factura con RAPIPAGO");
                                        Console.WriteLine("[*] Puede pagar su factura con PAGOFACIL");
                                        Console.WriteLine("[*] Puede pagar su factura con COBRO EXPRESS");
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("[*] Para adquirir el plan 3 GB, marque 1");
                                        Console.WriteLine("[*] Para adquirir el plan 5 GB, marque 2");
                                        Console.WriteLine("[*] Para adquirir el plan 10 GB, marque 3");
                                        int op4bis = int.Parse(Console.ReadLine());
                                        switch (op4bis)
                                        {
                                            case 1:
                                                Console.WriteLine("[*] Desea adquirir el plan de 3 GB? marque 1, caso contrario, Marque 2");
                                                int operacion1 = int.Parse(Console.ReadLine());
                                                if (operacion1 == 1)
                                                {
                                                    Console.WriteLine("[*] Su plan fue cambiado con éxito");
                                                    Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("[*] Su plan no fue modificado.");
                                                    Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                                }
                                                break;
                                            case 2:
                                                Console.WriteLine("[*] Desea adquirir el plan de 5 GB? marque 1, caso contrario, Marque 2");
                                                int operacion2 = int.Parse(Console.ReadLine());
                                                if (operacion2 == 1)
                                                {
                                                    Console.WriteLine("[*] Su plan fue cambiado con éxito");
                                                    Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("[*] Su plan no fue modificado.");
                                                    Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                                }
                                                break;
                                            case 3:
                                                Console.WriteLine("[*] Desea adquirir el plan de 10 GB? marque 1, caso contrario, Marque 2");
                                                int operacion3 = int.Parse(Console.ReadLine());
                                                if (operacion3 == 1)
                                                {
                                                    Console.WriteLine("[*] Su plan fue cambiado con éxito");
                                                    Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("[*] Su plan no fue modificado.");
                                                    Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                                }
                                                break;
                                        }
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("[*] Muchas gracias por informar el robo o perdida de su telefono");
                                        Console.WriteLine("[*] A continuación vamos a bloquer su línea telefónica y el IMEI");
                                        Console.WriteLine("[*] El IMEI es el código de identificación de cada celular");
                                        Console.WriteLine("[*] Presione 1 para continuar");
                                        Console.WriteLine("[*] Presione 2 para cancelar");
                                        int operacion3robo = int.Parse(Console.ReadLine());
                                        if (operacion3robo == 1)
                                        {
                                            Console.WriteLine("[*] Hemos bloqueado el celular y el IMEI con éxito.");
                                            Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                        }
                                        else
                                        {
                                            Console.WriteLine("[*] Cualquier consulta que tenga, no dude en contactarse con nosotros.");
                                            Console.WriteLine("[*] Gracias por comunicarse con PERSONAL");
                                        }
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("[*] Muchas gracias por comunicarse con nuestro Centro de Atencíón al Cliente");
                                        Console.WriteLine("[*] A la brevedad uno de nuestros especialistas se pondra en contacto con usted");
                                        Console.WriteLine("[*] Personal, la red 4G más rápida del País.");
                                        break;
                                }
                                break;
                            
                        }
                        Console.WriteLine("Desea salir? SI / NO");
                        salir = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("[*] A continuación será redirigido al MENU PRINCIPAL");
                        Console.WriteLine("[*] Muchas gracias por confiar en PERSONAL, siempre con vos.");
                        Console.WriteLine("[*] Presione ENTER para continuar ... ");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[*] Bienvenido al servicio de Atencion al cliente de Personal...");
                        Console.WriteLine("[*] Por favor, ingrese su numero de línea para continuar...");
                        Console.WriteLine("[*] Ingrese el Código de área + número sin el 15.");
                        user = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("[*] Su número es incorrecto.. Por favor, Ingrese el Código de área + número sin el 15.");
                    user = Console.ReadLine();
                }
            }
        }
    }
}
