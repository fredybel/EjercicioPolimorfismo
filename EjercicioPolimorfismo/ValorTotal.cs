using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class ValorTotal : Prestamos
    {
        public ValorTotal() { }

        public override double Mes()
        {
            TasaInteres = 0.03;
            Interes = (Capital * TasaInteres)* 12 ;
            PagoCuota = (Capital + Interes) /12;
            return PagoCuota * 12;
        }

        public override double Trimestre()
        {
            TasaInteres = 0.09;
            Interes = (Capital * TasaInteres) * 4;
            PagoCuota = (Capital + Interes) / 4;
            return PagoCuota * 4;
        }

        public override double Semestre()
        {
            TasaInteres = 0.18;
            Interes = (Capital * TasaInteres)*2;
            PagoCuota =( Capital + Interes)/2;
            return PagoCuota * 2;
        }

        public override double Año()
        {
            TasaInteres = 0.36;
            Interes = Capital * TasaInteres;
            PagoCuota = Capital + Interes;
            return PagoCuota * Plazo;
        }

        public new void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"La cuota Mensual a pagar es: {Mes()}");
            Console.WriteLine($"La cuotaTrimestral a pagar es: {Trimestre()}");
            Console.WriteLine($"La cuota Semestral a pagar es: {Semestre()}");
            Console.WriteLine($"La cuota Anual a pagar es:  {Año()}");


        }
    }
}
