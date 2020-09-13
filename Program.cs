using System;

namespace bai1
{
    class Program
  {
        static void Main(string[] args)
        {
             Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console . WriteLine ( " Enter a: " );
            float a = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console . WriteLine ( " a must be different from 0 " );
            }
            else
            {
                Console . WriteLine ( " Enter b: " );
                float b = float.Parse(Console.ReadLine());

                float x = -b / a;
                Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b, x);
            }
            Console.ReadKey();
        }
    }
}