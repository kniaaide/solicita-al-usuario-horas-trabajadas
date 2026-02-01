
using System;
class Program
{
    static void Main()
    {
       using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de Salario Neto");
        Console.Write("Ingrese la cantidad de horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el costo por hora: ");
        double costo = double.Parse(Console.ReadLine());

        double bruto = horas * costo;
        double neto = CalcularSalarioNeto(bruto);

        Console.WriteLine($"Salario Bruto: {bruto:C}");
        Console.WriteLine($"Salario Neto: {neto:C}");
        Console.ReadKey();
    }

    static double CalcularSalarioNeto(double bruto) =>
        bruto < 1000 ? bruto + 200 :
        bruto <= 2000 ? bruto * 0.95 :
        bruto <= 4000 ? bruto * 0.85 :
        bruto <= 6000 ? bruto * 0.82 :
        bruto <= 10000 ? bruto * 0.77 :
        bruto * 0.75;
    //kenia aide martinez vallesteros 
   
}
        
    }
}
