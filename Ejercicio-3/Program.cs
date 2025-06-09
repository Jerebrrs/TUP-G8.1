namespace Ejercicio3
{
    class Program
    {
        static Service service = new Service();
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Eliga una opcion: ");
            Console.WriteLine("1- Ingrese los nombres y libertas de alumnos: ");
            Console.WriteLine("2- Solicitar lista ordenada.");
            Console.WriteLine("3- para finalizar el programa.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;

        }
        static void MostrarPantallaSolcitarAlumnos()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el nombre y libreta del {i + 1} alumno:");
                string nombre = Console.ReadLine();
                int libreta = Convert.ToInt32(Console.ReadLine());
                service.RegistrarNombreLibreta(nombre, libreta, i);
            }
        }
        static void MostrarPantallaMostarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("La lista ordenada de mayor a menor es: ");
            service.ListaOrdenada();
            Console.ReadKey(); 
        }


        static void Main(string[] args)
        {

            int op = MostrarPantallaSolicitarOpcionMenu();
            while (op != 3)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolcitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostarListaOrdenada();
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida.");
                        break;
                }
               if (op != 3)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }

        }
        
    }
    
}