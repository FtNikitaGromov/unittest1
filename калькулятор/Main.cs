using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorChecker
    {
        public static double ValidateCalculator(double a, double b, string oper)
        {
            if (oper == "+")
            {
                return (a + b);
            }

            if (oper == "-")
            {
                return a - b;

            }
            if (oper == "*")
            {
                return (a * b);

            }
            if (oper == "/")
            {
                
                
                try
                {


                    if (b == 0)
                    {
                        throw new DivideByZeroException();

                        
                    }
                    else
                    { Console.WriteLine("Результат :" + " " + a / b);
                        return (a / b); }
                       

                }
                catch (DivideByZeroException e )
                {
                    Console.WriteLine($"Oshibka: {e.Message}");
                    return 1;
                }


            }

            return 0;
        }
        static public void Main()
        {
            double a = 0;
            double b = 0;



            Console.WriteLine("Введите число 1");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToDouble(Console.ReadLine());
            double res = CalculatorChecker.ValidateCalculator(a, b, "/");
            Console.WriteLine("res" + res);
        }

    }
}
