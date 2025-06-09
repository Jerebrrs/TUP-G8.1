namespace Ejercicio3
{
    class Service
    {

        public string nombre1, nombre2, nombre3;
        public int libreta1, libreta2, libreta3;


        public void RegistrarNombreLibreta(string nombre, int libreta, int i)
        {
            if (i == 0)
            {
                nombre1 = nombre;
                libreta1 = libreta;
            }
            else if (i == 1)
            {
                nombre2 = nombre;
                libreta2 = libreta;
            }
            else
            {
                nombre3 = nombre;
                libreta3 = libreta;
            }
        }


        public void ListaOrdenada()
        {
            if (libreta1 > libreta2)
            {
                if (libreta3 > libreta2)
                {
                    if (libreta3 > libreta1)
                    {
                        Console.WriteLine($"1- {nombre3} con libreta {libreta3}");
                        Console.WriteLine($"2- {nombre1} con libreta {libreta1}");
                        Console.WriteLine($"3- {nombre2} con libreta {libreta2}");
                    }
                    else
                    {
                        Console.WriteLine($"1- {nombre1} con libreta {libreta1}");
                        Console.WriteLine($"2- {nombre3} con libreta {libreta3}");
                        Console.WriteLine($"3- {nombre2} con libreta {libreta2}");
                    }
                }
                else
                {
                    Console.WriteLine($"1- {nombre1} con libreta {libreta1}");
                    Console.WriteLine($"2- {nombre2} con libreta {libreta2}");
                    Console.WriteLine($"3- {nombre3} con libreta {libreta3}");

                }
            }
            else
            {
                if (libreta3 > libreta1)
                {
                    if (libreta3 > libreta2)
                    {
                        Console.WriteLine($"1- {nombre3} con libreta {libreta3}");
                        Console.WriteLine($"2- {nombre2} con libreta {libreta2}");
                        Console.WriteLine($"3- {nombre1} con libreta {libreta1}");
                    }
                    else
                    {
                        Console.WriteLine($"1- {nombre2} con libreta {libreta2}");
                        Console.WriteLine($"2- {nombre3} con libreta {libreta3}");
                        Console.WriteLine($"3- {nombre1} con libreta {libreta1}");
                    }
                }
                else
                {
                    Console.WriteLine($"1- {nombre2} con libreta {libreta2}");
                    Console.WriteLine($"2- {nombre1} con libreta {libreta1}");
                    Console.WriteLine($"3- {nombre3} con libreta {libreta3}");
                }
            }
        }
    }
    
}