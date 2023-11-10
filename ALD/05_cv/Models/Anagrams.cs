using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_cv.Models
{
    class Anagrams
    {

        public static string IsAnagram(string a, string b)
        {
            List<char> listA = ListFromString(a);
            List<char> listB = ListFromString(b);
            Dictionary<char, int> dictA = GetDictionaryFromList(listA);
            Dictionary<char, int> dictB = GetDictionaryFromList(listB);
            int isAnagram = 0;
            return "true";
        }

        private static List<char> ListFromString(string a)
        {
            List<char> result = a.ToLower().ToCharArray().ToList();
            return result.Where(x=>x!=' ').ToList();
        }
        private static Dictionary<char, int> GetDictionaryFromList(List<char> list)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char s in list)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            dict.OrderByDescending(x => x.Key);
            return dict;
        }
        private static Anagram IsEqual(int isAnagram, int listCount)
        {
            if(Math.Abs(isAnagram - listCount) / 2 >= 1)
            {
                return Anagram.NearAnagram;
            }
            return (Anagram)Math.Abs(isAnagram - listCount);
        }
    }

    public enum Anagram
    {
        [Display(Name = "ANAGRAMS")]
        Anagram = 0,
        [Display(Name = "NOT ANAGRAMS")]
        NotAnagram = 1,
        [Display(Name = "NEAR ANAGRAMS")]
        NearAnagram = 2

    }
}
