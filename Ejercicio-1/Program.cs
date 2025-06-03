using System;
namespace Guia8
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static void MostrarPantallaIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando las variables\n\n");
            servicio = new Servicio();
            Console.WriteLine("Precione una tecla para continuar");
            Console.ReadKey();
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones.");
            Console.WriteLine("1- Procesar un solo numero.");
            Console.WriteLine("2- Procesar varios números.");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaCalcularYmostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("Pantalla de promedio\n");
            if (servicio.Contador > 0)
            {
                Console.WriteLine($"Promedio: {servicio.CalcularPromedio():f2}");
            }
            else
            {
                Console.WriteLine("Promedio: no se han ingresado numeros.");
            }

            Console.WriteLine("Precione una tecla para volver al menu principal.");
            Console.ReadKey();
        }
        static void MostrarPantallaSolcitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número:\n");
            int valor = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(valor);
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese cuantos numeros va a ingresar\n");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                MostrarPantallaSolcitarNumero();
            }
        }
        static void MostrarPantallaMaximoMinimo()
        {
            Console.Clear();
            Console.WriteLine("Maximo y Minimo");
            Console.WriteLine($"Maximo: {servicio.Maximo}");
            Console.WriteLine($"Minimo: {servicio.Minimo}");
            Console.WriteLine("Precione una tecla para volver al menu principal.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MostrarPantallaIniciarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opcion menu
            while (op != -1)
            {
                #region verificar opcion
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolcitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYmostrarPromedio();
                        break;
                    default:
                        op = -1;
                        break;
                }
                #endregion
                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }
            #endregion
        }   
    }
}