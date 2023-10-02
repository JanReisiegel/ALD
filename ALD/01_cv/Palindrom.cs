using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_cv
{
    static class Palindrom
    {
        public static void IsPalinrdomWord()
        {
            while (true)
            {
                string slovo = Console.ReadLine();
                if (String.IsNullOrEmpty(slovo))
                    return;
                char[] slovo2 = slovo.Reverse().ToArray();
                string slovo3 = "";
                foreach (char c in slovo2)
                {
                    slovo3 += c;
                }
                if (slovo.ToLower() == slovo3.ToLower())
                    Console.WriteLine("ano");
                else Console.WriteLine("ne");

            }
        }

        public static void NextNumberPalindrom()
        {
            while (true)
            {
                Stopwatch sw = new Stopwatch();
                
                BigInteger num = BigInteger.Parse(Console.ReadLine());
                sw.Start();
                if (num == -1)
                {
                    return;
                }
                num++;
                string nums = $"{num}";
                if (string.IsNullOrEmpty(nums))
                    return;

                char[] snum = nums.ToCharArray(); //nums.Split("");
                int lichy = nums.Length % 2;
                int[] ints = new int[nums.Length / 2 + lichy];
                int[] vysledek = new int[snum.Length];
                for (int i = 0; i < snum.Length; i++)
                {
                    vysledek[i] = Int32.Parse(snum[i].ToString());
                    if (i < (nums.Length / 2) + lichy)
                    {
                        ints[i] = Int32.Parse(snum[i].ToString());
                    }
                }
                BigInteger palindrom = GetBigInteger(ints, lichy);

                while (palindrom < num)
                {
                    BigInteger helpInts = GetBigInteger(ints) + 1;
                    nums = $"{helpInts}";
                    snum = nums.ToCharArray();
                    for (int i = 0; i < ints.Length; i++)
                    {
                        ints[i] = Int32.Parse(snum[i].ToString());
                    }
                    palindrom = GetBigInteger(ints, lichy);
                }
                sw.Stop();
                Console.WriteLine(palindrom);
                Console.WriteLine(sw.Elapsed);
            }
            
        }

        private static BigInteger GetBigInteger(int[] firstHalf, int modulo2)
        {
            if(modulo2 == 0)
            {
                string cislo = string.Join("", firstHalf) + string.Join("", firstHalf.Reverse().ToArray());
                return BigInteger.Parse(cislo);
            }
            else
            {
                string cislo = string.Join("", firstHalf); //+ string.Join("",firstHalf.Reverse().ToArray(),1,firstHalf.Length-1);
                for (int i = firstHalf.Length - 2; i >= 0; i--)
                {
                    cislo += firstHalf[i];
                }
                return BigInteger.Parse(cislo);
            }
        }
        private static BigInteger GetBigInteger(int[] cisla)
        {
            return BigInteger.Parse(string.Join("", cisla));
        }

    }
}
