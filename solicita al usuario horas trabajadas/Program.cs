//Solicitar al usuario la cantidad de horas trabajadas y el costo que se paga por hora. Y realizar los siguiente calculosSi la persona gana menos de 1000 se le seumará un subsidio de 200.Si la persona gana entre 1001 y 2000 se le cobrará un impuestro del 5%.Si la persona gana entre 2001 y 4000 se le cobrará un impuestro del 15%
//.Si la persona gana entre 4001 y 6000 se le cobrará un impuestro del 18%
//.Si la persona gana entre 6001 y 10000 se le cobrará un impuestro del 23%
//.Si la persona gana mas de 10000 se le cobrará un impuestro del 25%
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
