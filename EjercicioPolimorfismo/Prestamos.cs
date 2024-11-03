                                    //CLASE Base
namespace EjercicioPolimorfismo
{

    //Metodos
    public abstract class Prestamos
    {

        //Variables
        public double Capital;
        public double TasaInteres;
        public double Plazo;
        public double Interes;
        public double PagoCuota;

        public abstract double Mes();
        public abstract double Trimestre();
        public abstract double Semestre();
        public abstract double Año();
        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Mensual a pagar es: {Mes()}");
            Console.WriteLine($"Trimestral a pagar es: {Trimestre()}");
            Console.WriteLine($"Semestral a pagar es: {Semestre()}");
            Console.WriteLine($"Anual a pagar es:  {Año()}");
        }

    }
}
