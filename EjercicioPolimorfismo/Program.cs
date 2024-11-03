using EjercicioPolimorfismo;

PrestamoPersonal prestamoPersonal = new PrestamoPersonal();
Cuota cuota = new Cuota();
ValorTotal valorTotal = new ValorTotal();
int opcion;


        Console.WriteLine("******************************************");
        Console.WriteLine("*                  MENU                  *");
        Console.WriteLine("* 1.      Calcular interes               *");
        Console.WriteLine("* 2.      Calcular cuota                 *");
        Console.WriteLine("* 3.      Valor a pagar total            *");
        Console.WriteLine("******************************************");
        Console.WriteLine("Escoja la opción:");
        opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine();
        Console.WriteLine("Ingrese el capital del Prestamo");
        prestamoPersonal.Capital = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el plazo en años");
        prestamoPersonal.Plazo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        prestamoPersonal.Imprimir();
        break; 


    case 2:
        Console.WriteLine();
        Console.WriteLine("Ingrese el capital del Prestamo");
        cuota.Capital = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el plazo en años");
        cuota.Plazo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        cuota.Imprimir();
        break;

    case 3:
        Console.WriteLine();
        Console.WriteLine("Ingrese el capital del Prestamo");
        valorTotal.Capital = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el plazo en años");
        valorTotal.Plazo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        valorTotal.Imprimir();
        break;
}








      