using System;
using System.Reflection.Metadata.Ecma335;

namespace _10._10._2022_HomeworkClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Account.LoginPassword("cavid123@gmail.com","Cavid1993");

            Faktorial faktorial = new Faktorial();
            Console.WriteLine(Faktorial.Fack(5));

            Calculator calculator = new Calculator();
            Calculator.CalculatorResult();
        }
    }
}
