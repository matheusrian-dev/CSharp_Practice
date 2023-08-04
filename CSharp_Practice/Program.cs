// See https://aka.ms/new-console-template for more information
//var numberOne = 23f;
//var numbertwo = 23.45;
//Console.WriteLine(numberOne);
//Console.WriteLine("Say somenthing:");
//var message = Console.ReadLine();
//Console.WriteLine(SimpleMath.Add(numberOne, numbertwo));
using CSharp_Practice.Classes;


// Utilizando o Overload do método Add da classe SimpleMath
double[] numbers = new double[] { 1, 2, 3, 42, 42154, };
var result = SimpleMath.Add(numbers);
Console.WriteLine("Resultado:" + result);

double numberOne = 13f;
BankAccount bankAccount = new BankAccount(1000); // Instanciação de classes não estáticas
bankAccount.AddToBalance(numberOne);
Console.WriteLine(bankAccount.Balance);

ChildBankAccount childBankAccount = new ChildBankAccount();
childBankAccount.AddToBalance(10);

Console.WriteLine(childBankAccount.Balance);

class SimpleMath
{
    public static double Add(double n1, double n2) // Métodos e classes que não são estáticos (contém o static), precisam ser instanciados antes de serem utilizados
    {
        return n1 + n2;
    }

    public static double Add(double[] numbers)
    {
        double result = 0;
        foreach(double d in numbers)
        {
            result += d;
        }
        return result;
    }
}