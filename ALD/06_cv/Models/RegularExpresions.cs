using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_cv.Models
{
    public class MyRegularExpresions
    {
        private string _text;

        public string Text { get { return _text; } private set { _text = value; ParseText(); } }

        public List<SpecializationStudents> Specializations { get; set; } = new List<SpecializationStudents> 
        {
            new SpecializationStudents("AVI"),
            new SpecializationStudents("AI"),
            new SpecializationStudents("IS"),
            new SpecializationStudents("IT")
        };

        public MyRegularExpresions(string path)
        {
            var text = File.ReadAllText(path);
            Text = text.Replace("\r", string.Empty);
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
            text = Regex.Replace(text, @" ?\n +", "\n");

            var lines = text.Split('\n').Skip(2).ToList();
            foreach(string line in lines)
            {
                List<string> input = line.Split(';').ToList();
                foreach(var specialization in Specializations)
                {
                    if (input.Count() <= 1)
                    {
                        continue;
                    }
                    if (input[8].Split(" ").Contains(specialization.SpecializationName))
                    {
                        var studentName = input[0].Split(" ");
                        specialization.PutStudent(new Student(input[5], studentName[1], studentName[0]));
                    }
                }
            }
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            Specializations.Sort((SpecializationStudents s1, SpecializationStudents s2) =>
            {
                return s1.SpecializationName.CompareTo(s2.SpecializationName);
            });
            Specializations.ForEach(s =>
            {
                sb.AppendLine(s.PrintListOfStudents());
            });
            return sb.ToString();
        }

    }
}
