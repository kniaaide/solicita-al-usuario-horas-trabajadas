//Solicitar al usuario la cantidad de horas trabajadas y el costo que se paga por hora. Y realizar los siguiente calculosSi la persona gana menos de 1000 se le seumará un subsidio de 200.Si la persona gana entre 1001 y 2000 se le cobrará un impuestro del 5%.Si la persona gana entre 2001 y 4000 se le cobrará un impuestro del 15%
//.Si la persona gana entre 4001 y 6000 se le cobrará un impuestro del 18%
//.Si la persona gana entre 6001 y 10000 se le cobrará un impuestro del 23%
//.Si la persona gana mas de 10000 se le cobrará un impuestro del 25%
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el costo por hora: ");
        double costoPorHora = Convert.ToDouble(Console.ReadLine());
        double salarioBruto = horasTrabajadas * costoPorHora;
        double salarioNeto = salarioBruto;
        if (salarioBruto < 1000)
        {
            salarioNeto += 200; // Subsidio
        }
        else if (salarioBruto <= 2000)
        {
            salarioNeto -= salarioBruto * 0.05; // Impuesto del 5%
        }
        else if (salarioBruto <= 4000)
        {
            salarioNeto -= salarioBruto * 0.15; // Impuesto del 15%
        }
        else if (salarioBruto <= 6000)
        {
            salarioNeto -= salarioBruto * 0.18; // Impuesto del 18%
        }
        else if (salarioBruto <= 10000)
        {
            salarioNeto -= salarioBruto * 0.23; // Impuesto del 23%
        }
        else 
        {
            salarioNeto -= salarioBruto * 0.25; // Impuesto del 25%
        }
        Console.WriteLine($"Salario Bruto: {salarioBruto}");
        Console.WriteLine($"Salario Neto: {salarioNeto}");
    }
}
