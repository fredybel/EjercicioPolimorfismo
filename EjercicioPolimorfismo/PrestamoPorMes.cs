using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class PrestamoPorMes
    {

            //Variables
        public double Capital;
        public double TasaInteres;
        public double Plazo;
        public double Interes;
        public double Cuota;



        public double Mes()
        {
            TasaInteres = 0.03;

            return Interes= Capital * TasaInteres * Plazo / 100;
            
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"El Interes Mensual a pagar es: { Mes()}");
        }
    }
}
