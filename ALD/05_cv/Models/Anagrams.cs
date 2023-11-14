using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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
            if (dictA.Count >= dictB.Count)
            {
                foreach (var item in dictA)
                {
                    if (!dictB.ContainsKey(item.Key) || item.Value != dictB[item.Key])
                    {
                        isAnagram++;
                    }
                }
            }
            else
            {
                foreach (var item in dictB)
                {
                    if (!dictA.ContainsKey(item.Key) || item.Value != dictA[item.Key])
                    {
                        isAnagram++;
                    }
                }
            }
            

            return ((AnagramType)(isAnagram > 2 ? 2 : isAnagram)).GetDisplayName();
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
    }

    public enum AnagramType
    {
        [Display(Name = "ANAGRAMS")]
        Anagram = 0,
        [Display(Name = "NOT ANAGRAMS")]
        NotAnagram = 2,
        [Display(Name = "NEAR ANAGRAMS")]
        NearAnagram = 1
    }
    public static class AnagramHelper
    {
        public static string GetDisplayName(this Enum value)
        {
            return value.GetType().GetMember(value.ToString()).FirstOrDefault().GetCustomAttribute<DisplayAttribute>()?.GetName();
        }
    }
}
