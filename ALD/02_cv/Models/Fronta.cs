using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_cv.Models
{
    public class Fronta<T>
    {
        private Prvek? first;
        class Prvek
        {
            public T value;
            public Prvek? next;
        }
        public void Push(T value)
        {
            Prvek prvek = new Prvek();
            prvek.value = value;
            if (first == null)
            {
                first = prvek;
                return;
            }
            Prvek prvek1 = first;
            while (true)
            {
                if (prvek1.next == null)
                {
                    prvek1.next = prvek;
                    return;
                }
                prvek1 = prvek1.next;
            }
        }
        public T? Pop()
        {
            T result = first.value;
            if (first.next != null)
            {
                first = first.next;
            }
            else
            {
                first = null;
            }
            return result;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
