using System;

namespace ParametroArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] calificaciones = new int[] {8,7,9,3,10,5,4,7 };
            double promedioResultado = ObtenerPromedio(calificaciones);


            foreach (int nota in calificaciones)
            {
                Console.WriteLine("{0}",nota);

            }

            Console.WriteLine("El promedio es {0}", promedioResultado);
            Console.Read();
        }

        static double ObtenerPromedio(int [] arrayDePuntajes)
        {
            int cantidad = arrayDePuntajes.Length;
            double promedio;
            int suma = 0;

            for (int i = 0; i < cantidad; i++)
            {
                suma += arrayDePuntajes[i];
            }

            promedio = (double)suma / cantidad;

            return promedio;

        }
    }
}
