using EjercicioPolimorfismo;

PrestamoPorMes prestamoPorMes = new PrestamoPorMes();
PrestamoTrimestre prestamoTrimestre= new PrestamoTrimestre();
PrestamoPorSemestre prestamoPorSemestre= new PrestamoPorSemestre();
 int opcion;


        Console.WriteLine("******************************************");
        Console.WriteLine("*                  MENU                  *");
        Console.WriteLine("* 1.  Calcular interes de un prestamo    *");
        Console.WriteLine("* 2.      Por Mes                        *");
        Console.WriteLine("* 3.      Por trimestre                  *");
        Console.WriteLine("* 4.      por Semestre                   *");
        Console.WriteLine("* 5.      Por año                        *");
        Console.WriteLine("******************************************");
        Console.WriteLine("Escoja la opción:");
        opcion = Convert.ToInt32(Console.ReadLine());


switch (opcion){


    case 1:
        Console.WriteLine("Calculo de Interes Mensual");
    Console.WriteLine("Ingrese el monto del Capital");
prestamoPorMes.Capital = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la tasa de interes");
prestamoPorMes.TasaInteres = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el Plazo");
prestamoPorMes.Plazo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
prestamoPorMes.Imprimir();
break;



    case 2:
        Console.WriteLine("Calculo de Interes Trimestral");
        Console.WriteLine("Ingrese el monto del Capital");
        prestamoPorMes.Capital = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la tasa de interes");
        prestamoPorMes.TasaInteres = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el Plazo");
        prestamoPorMes.Plazo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        prestamoPorMes.Imprimir();
        break;


    case 3:
        Console.WriteLine("Calculo de Interes Semestral");
        Console.WriteLine("Ingrese el monto del Capital");
        prestamoPorMes.Capital = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la tasa de interes");
        prestamoPorMes.TasaInteres = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el Plazo");
        prestamoPorMes.Plazo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        prestamoPorMes.Imprimir();
        break;
}





      