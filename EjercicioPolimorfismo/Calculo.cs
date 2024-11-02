                                //CLASE Derivada
namespace EjercicioPolimorfismo
{



    public class Calculo : Prestamos   //Herencia
    {


        //Variables
        public double Capital;
        public double TasaInteres;
        public double Plazo;
        public double Interes;
        public double Cuota;



        public double Mes()
        {

            return Interes= Capital * TasaInteres * Plazo / 100;
            
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"El Interes a pagar es: { Mes()}");
        }
    }
}
