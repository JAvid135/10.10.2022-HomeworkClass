using System;
using System.Collections.Generic;
using System.Text;

namespace _10._10._2022_HomeworkClass
{
    class Calculator
    {
        public static void CalculatorResult()
        {
            Console.Write("Birinci Reqemi daxil edin : ");
            float num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Simvolu daxil edin : ");
            string symbol = Console.ReadLine();
            Console.Write("Ikinci reqemi daxil edin : ");
            float num2 = Int32.Parse(Console.ReadLine());
            

            float result = 0;
            
            switch (symbol)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            Console.Write("Cavab : ");
            Console.WriteLine(result);
            
        }
    }
}
