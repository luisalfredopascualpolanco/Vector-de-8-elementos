using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {
        int[] numeros = new int[8];

        public void Cargar() 
        {
            for (int i = 0; i < 8; i++)
            {
                int posicion = i + 1;
                Console.Write("Dame el numero de la posicion #"+posicion+": ");
                numeros[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("La sumatoria de todos los numeros es: "+Acumalado1());
            Console.WriteLine("La sumatoria de los numeros mayores a 36 es: "+Acumalado2());
            Console.WriteLine("La cantidad de numeros mayores a 50: "+Cantidad());
        }

        protected int Acumalado1() 
        {
            int sumatoria = 0;
            for (int i = 0; i < 8; i++)
            {
                sumatoria = sumatoria + numeros[i];
            }

            return sumatoria;
        }

        protected int Acumalado2()
        {
            int sumatoria = 0;
            for (int i = 0; i < 8; i++)
            {
                if (numeros[i] > 36)
                {
                    sumatoria = sumatoria + numeros[i];
                }               
            }
            return sumatoria;
        }

        protected int Cantidad()
        {
            int sumatoria = 0;
            for (int i = 0; i < 8; i++)
            {
                if (numeros[i] > 50)
                {
                    sumatoria = sumatoria + 1;
                }
            }
            return sumatoria;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Vector vector = new Vector();
                vector.Cargar();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido");
            }
            Console.ReadKey();
        }
    }
}
