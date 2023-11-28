using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_cv.Models
{
    public class RegularExpresions
    {
        public string Text { get; private set; }

        public RegularExpresions(string path)
        {
            Text = File.ReadAllText(path);
        }
    }
}
