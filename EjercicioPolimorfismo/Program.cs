using EjercicioPolimorfismo;

Calculo calculo = new Calculo();


Console.WriteLine("Ingrese el monto del Capital");
calculo.Capital = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la tasa de interes");
calculo.TasaInteres = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el Plazo");
calculo.Plazo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
calculo.Imprimir();

