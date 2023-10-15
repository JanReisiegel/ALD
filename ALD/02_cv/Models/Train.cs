using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _02_cv.Models
{
    public class Train
    {
        Wagon? first, last;
        public Train()
        {
            first = null;
            last = null;
        }
        class Wagon
        {
            public string id;
            public Wagon? prev, next;
            public int weight;
            public Wagon()
            {
                prev = null;
                next = null;
            }
            public override string ToString()
            {
                return $"{id}:{weight}";
            }
        }

        public string Push(string id, int wieght)
        {
            try
            {
                if (first == null)
                {
                    first = new Wagon();
                    first.id = id;
                    first.weight = wieght;
                }
                else if (last == null)
                {
                    last = new Wagon();
                    last.id = id;
                    last.weight = wieght;
                    last.prev = first;
                    first.next = last;
                }
                else
                {
                    Wagon wagon = new Wagon();
                    wagon.id = id;
                    wagon.weight = wieght;
                    wagon.prev = last;
                    last.next = wagon;
                    last = wagon;
                }
                return "ok";
            }
            catch
            {
                return "error";
            }
        }

        public string Pop(string id)
        {
            try
            {
                Wagon wagon = first;
                while (true)
                {
                    if (wagon.id.Equals(id))
                    {
                        if (wagon.Equals(first))
                        {
                            first = wagon.next;
                            first.prev = null;
                            return "ok";
                        }
                        if (wagon.Equals(last))
                        {
                            last = wagon.prev;
                            last.next = null;
                            return "ok";
                        }
                        wagon.next.prev = wagon.prev;
                        wagon.prev.next = wagon.next;
                        return "ok";
                    }
                    wagon = wagon.next;
                }
            }
            catch
            {
                return "error";
            }
        }

        public string Pop(int position)
        {
            if (first == null)
            {
                return "error";
            }
            try
            {
                Wagon wagon = first;
                for (int i = 1; i <= position; i++)
                {
                    if (wagon.next == null)
                    {
                        return "error";
                    }
                    wagon = wagon.next;
                }
                if (wagon.Equals(first))
                {
                    first = wagon.next;
                    first.prev = null;
                    return "ok";
                }
                if (wagon.Equals(last))
                {
                    last = wagon.prev;
                    last.next = null;
                    return "ok";
                }
                wagon.next.prev = wagon.prev;
                wagon.prev.next = wagon.next;
                return "ok";
            }
            catch { return "error"; }
        }

        public string Move(string id, int position) //nefunguje
        {
            try
            {
                Wagon? moved, positioned;
                moved = first;
                while (true)
                {
                    if (moved == null)
                    {
                        return "error";
                    }
                    if (moved.id.Equals(id))
                    {
                        break;
                    }
                    moved = moved.next;
                }

                positioned = first;
                for (int i = 1; i < position; i++)
                {
                    if (positioned == null)
                    {
                        return "error";
                    }
                    positioned = positioned.next;
                }
                
                Wagon? temp;
                if(positioned.next == moved)
                {
                    temp = positioned;
                    positioned.next = moved.next;
                    if(moved.next != null)
                    {
                        moved.next.prev = positioned;
                    }
                    positioned.prev = moved;
                    moved.prev = temp.prev;
                    if(temp.prev != null)
                    {
                        temp.prev.next = moved;
                    }
                    moved.next = positioned;
                }
                else if(moved.next == positioned)
                {
                    temp = positioned;
                    positioned.next = moved;
                    positioned.prev = moved.prev;
                    if(moved.prev != null)
                    {
                        moved.prev.next = positioned;
                    }
                    moved.prev = positioned;
                    moved.next = temp.next;
                    if(temp.next != null)
                    {
                        temp.next.prev = positioned;
                    }
                }
                else
                {
                    temp = positioned;
                    positioned.next = moved.next;
                    if(moved.next!=null)
                    {
                        moved.next.prev = positioned;
                    }
                    positioned.prev = moved.prev;
                    if (moved.prev != null)
                    {
                        moved.prev.next = positioned;
                    }
                    moved.next = temp.next;
                    if (temp.next != null)
                    {
                        temp.next.prev = moved;
                    }
                    moved.prev = temp.prev;
                    if(moved.prev != null)
                    {
                        moved.prev.next = moved;
                    }
                }

                return "ok";
            }
            catch { return "error"; }
        }

        public string GetTotalWeight()
        {
            if (first == null)
            {
                return "empty";
            }
            int totalWeight = 0;
            Wagon wagon = first;
            while (true)
            {
                if (wagon == null)
                {
                    return totalWeight.ToString();
                }
                totalWeight += wagon.weight;
                wagon = wagon.next;
            }
        }

        public string PrintTrain()
        {
            if (first == null)
            {
                return "empty";
            }
            StringBuilder sb = new StringBuilder();
            Wagon wagon = first;
            while (true)
            {
                if (wagon == null)
                {
                    return sb.ToString();
                }
                sb.AppendLine(wagon.ToString());
                wagon = wagon.next;
            }
        }
    }
}
