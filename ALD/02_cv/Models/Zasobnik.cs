using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_cv.Models
{
    public class Zasobnik<T>
    {
        private Prvek? top;
        class Prvek
        {
            public T value;
            public Prvek? before;
        }
        public void Push(T value)
        {
            Prvek prvek = new Prvek();
            prvek.value = value;
            if (top != null)
            {
                prvek.before = top;
            }
            top = prvek;
        }
        public T? Pop()
        {
            T result = top.value;
            if (top.before != null)
            {
                top = top.before;
            }
            else
            {
                top = null;
            }
            return result;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
