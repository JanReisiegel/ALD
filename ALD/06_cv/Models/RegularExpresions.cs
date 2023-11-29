using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_cv.Models
{
    public class RegularExpresions
    {
        private string _text;
        private List<string> _parsedText;

        public string Text { get { return _text; } private set { _text = value; ParseText(); } }

        public List<string> ParsedText { get { return _parsedText; } private set { _parsedText = value; } }

        public RegularExpresions(string path)
        {
            Text = File.ReadAllText(path);
        }

        private void ParseText()
        {
            string text = Text;//.Replace("\n", String.Empty);
            string patern = @"<.{3,}?>";
            text = Regex.Replace(text, patern, String.Empty);
            patern = @"\n+\W*";
            text = Regex.Replace(text, patern, "\n");
            Console.ReadKey();
        }

    }
}
