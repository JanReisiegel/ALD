using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_cv.Models
{
    class WordCount
    {
        private static readonly char[] Separator = { '\n', '\r', ' ' };
        public static async Task<string[]> ReadAll(CancellationToken ct = default)
        {
            var input = await Console.In.ReadToEndAsync();
            var words = input
                .ToLower()
                .Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        
    }
}
