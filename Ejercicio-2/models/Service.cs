namespace Guia8
{
    internal class Service
    {
        public int edad1, edad2, edad3, edad4;
        public double Monto, Porcentaje0, Porcentaje1, Porcentaje2, Porcentaje3, Monto0, Monto1, Monto2, Monto3;
        public Service()
        {
            Monto = 0;
        }
        public void RegistrarMontoARepartir(double monto)
        {
            Monto = monto;
        }

        public void RegistrarEdadNiña(int edad, int nroNiña)
        {
            if (nroNiña == 0)
            {
                edad1 = edad;

            }
            else if (nroNiña == 1)
            {
                edad2 = edad;
            }
            else if (nroNiña == 2)
            {
                edad3 = edad;
            }
            else
            {
                edad4 = edad;
            }

        }

        public void CalcularPorcentajeXNiña()
        {
            int sumaEdades = edad1 + edad2 + edad3 + edad4;

            Porcentaje0 = (double)edad1 / sumaEdades;
            Porcentaje1 = (double)edad2 / sumaEdades;
            Porcentaje2 = (double)edad3 / sumaEdades;
            Porcentaje3 = (double)edad4 / sumaEdades;

            Monto0 = Monto * Porcentaje0;
            Monto1 = Monto * Porcentaje1;
            Monto2 = Monto * Porcentaje2;
            Monto3 = Monto * Porcentaje3;
        }

    }
}