using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class PrestamoTrimestre
    {
        //Variables
        public double Capital;
        public double TasaInteres;
        public double Plazo;
        public double Interes;
        public double Cuota;



        public double Trimestre()
        {

            return Interes = Capital * TasaInteres * Plazo / 100;

        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"El Interes Trimestral a pagar es: {Trimestre()}");
        }
    }
}
