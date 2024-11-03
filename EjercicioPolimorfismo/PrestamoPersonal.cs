using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class PrestamoPersonal : Prestamos
    {
        public PrestamoPersonal() { }



        public override double Mes()
        {
            TasaInteres = 0.36;
            return Interes = (Capital * TasaInteres * Plazo)/12;

        }
        public override double Trimestre()
        {
            TasaInteres = 0.36;
            return Interes = (Capital * TasaInteres * Plazo)/4;
        }
        public override double Semestre()
        {
            TasaInteres = 0.36;
            return Interes = (Capital * TasaInteres * Plazo )/2;
        }
        public override double Año()
        {
            TasaInteres = 0.36;
            return Interes = (Capital * TasaInteres * Plazo );
        }

        public new void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"el interes Mensual a pagar es: {Mes()}");
            Console.WriteLine($"Trimestral a pagar es: {Trimestre()}");
            Console.WriteLine($"Semestral a pagar es: {Semestre()}");
            Console.WriteLine($"Anual a pagar es:  {Año()}");


        }
    }
}