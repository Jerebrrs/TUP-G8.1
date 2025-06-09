namespace Guia8
{
    class Program
    {
        static Service service = new Service();

        static void MostrarPantallaIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando las variables\n\n");
            service = new Service();
            Console.WriteLine("Precione una tecla para continuar");
            Console.ReadKey();
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {


            Console.Clear();

            Console.WriteLine("Ingrese una Opcion a ejecutar:");
            Console.WriteLine("1- Solicitar monto a repartir.");
            Console.WriteLine("2- Solicitar edades de las niñas.");
            Console.WriteLine("3- Mostrar resultados.");
            Console.WriteLine("(-1) Salir del programa.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            service.RegistrarMontoARepartir(monto);
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese la Edad de la {i + 1} niña: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                service.RegistrarEdadNiña(edad, i);

            }
            
        }
        static void MostrarPantallaCalcularMostarMontoYPorcentajeNiña()
        {
            if (service.Monto <= 0)
            {
                Console.WriteLine("Error: No se ha ingresado un monto válido. Por favor, ingrese el monto (opción 1).");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                return;
            }

            if (service.edad1 <= 0 || service.edad2 <= 0 || service.edad3 <= 0 || service.edad4 <= 0)
            {
                Console.WriteLine("Error: No se han ingresado todas las edades correctamente. Por favor, ingrese las edades (opción 2).");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                return;
            }

            service.CalcularPorcentajeXNiña();
            Console.WriteLine($"La niña de {service.edad1} años le corresponde un pocentaje de {service.Porcentaje0:f2} % y su monto es: ${service.Monto0:f2} . ");
            Console.WriteLine($"La niña de {service.edad2} años le corresponde un pocentaje de {service.Porcentaje1:f2} % y su monto es: ${service.Monto1:f2} . ");
            Console.WriteLine($"La niña de {service.edad3} años le corresponde un pocentaje de {service.Porcentaje2:f2} % y su monto es: ${service.Monto2:f2} . ");
            Console.WriteLine($"La niña de {service.edad4} años le corresponde un pocentaje de {service.Porcentaje3:f2} % y su monto es: ${service.Monto3:f2} . ");
           
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
        static void Main(String[] args)
        {
            MostrarPantallaIniciarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostarMontoYPorcentajeNiña();
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta, ingrese una valida.");
                        break;
                }
                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }
            
        }
        
    }
    
}