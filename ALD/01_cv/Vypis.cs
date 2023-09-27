using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_cv
{
    static class Vypis
    {
        public static void SayHelloWorld()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Hello world!");
            }
        }

        public static void AnswerIs42()
        {
            while (true)
            {
                int num = Int32.Parse(Console.ReadLine());
                if (num == 42)
                    return;
                Console.WriteLine(num);
            }
        }
    }
}
