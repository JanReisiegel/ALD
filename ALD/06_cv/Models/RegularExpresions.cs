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
            text = text.Replace("&nbsp", "");
            text = Regex.Replace(text, @" +", String.Empty);
            text = Regex.Replace(text, @"<.{4,}?>", String.Empty);
            text = Regex.Replace(text, @"\n+", "\n");
            text = Regex.Replace(text, @"</?[^r]>", String.Empty);
            text = Regex.Replace(text, @"\n+", " ");
            text = Regex.Replace(text, @"</?t[hd]>", "");
            text = Regex.Replace(text, @"</?tr>","\n");
            text = Regex.Replace(text, @" {2,}", ";");
            //text = Regex.Replace(text, @" +", " ");
            text = Regex.Replace(text, @" ?[,;]+ ?", ";");
            //text = Regex.Replace(text, @"<.[^(tr)]?>", String.Empty);
            Console.ReadKey();
        }

    }
}
