using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Cuota : Prestamos
    {
        public Cuota() { }

       



        public override double Mes()
        {
            TasaInteres = 0.03;
            Interes = (Capital * TasaInteres)*12;
            return (Capital + Interes)/12;
        }

        public override double Trimestre()
        {
            TasaInteres = 0.09;
            Interes = (Capital * TasaInteres) * 4;
            return (Capital + Interes) / 4;
        }

        public override double Semestre()
        {
            TasaInteres = 0.18;
            Interes = (Capital * TasaInteres) * 2;
            return (Capital + Interes) / 2;
        }
        public override double Año()
        {
            TasaInteres = 0.36;
            Interes = Capital * TasaInteres;
            return (Capital + Interes) / Plazo;
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
    
