using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorMerinovLidovskoi
{
    public class CalcChecker
    {
        public static int summ(int nums, int num2)
        {
            
            return nums+num2+1;
            

        }
        public static bool summ2(int nums, int num2)
        {

            return false;


        }
        public static int razn(int nums3, int num4)
        {

            return nums3 - num4;


        }
        public static int proizv(int num11, int num22)
        {

            return num11 * num22;


        }
        public static float delenie(float num12, float num23)
        {
            string result = "";
            try
            {
                return num12 / num23;
            }
            catch(DivideByZeroException)
            {
                result = "Divide by zero";
            }
            
                return num12 / num23;
            
                
            
            


        }
        public static double sqrt(double a)
        {

            return Math.Sqrt(a);


        }
        public static double square(double a)
        {

            return Math.Pow(a, 2.0);


        }
        public static double factorial(double a)
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f *= (double)i;
            return f;
        }

    }
}
