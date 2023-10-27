using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_cv.Models
{
    internal class Bogosort<T> where T : IComparable<T>
    {
        public int Counter { get; private set; }
        public Bogosort()
        {
            Counter = 0;
        }

        private static Random rng = new Random();
        private List<T> Shuffle(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        private bool IsOrdered(List<T> list)
        {
            for(int i = 0;i < list.Count-1; i++)
            {       
                if (list[i].CompareTo(list[i + 1]) >0)
                {
                    return false;
                }
            }
            return true;
        }
        public List<T> BogoSort(List<T> list)
        {
            Counter = 0;
            while (!IsOrdered(list))
            {
                Counter++;
                list = Shuffle(list);
            }
            return list;
        }

    }
}
