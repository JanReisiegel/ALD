using _05_cv.Models;
/*var words = await WordCount.ReadAll();
var wordDictionary = new Dictionary<string, int>();
words.ToList();
foreach (var word in words)
{
    if (wordDictionary.ContainsKey(word))
    {
        wordDictionary[word]++;
    }
    else
    {
        wordDictionary.Add(word, 1);
    }
}
var top10words = wordDictionary
    .OrderByDescending(x => x.Value)
    .Take(15)
    .ToList();
Console.WriteLine("Word Frequency:");
top10words.ForEach(x =>
{
    var freq = (double)x.Value / words.Length;
    Console.WriteLine( $"- {x.Key,-13} {freq,2:F}% ({x.Value})");
});
var frazeDictionary = new Dictionary<string, int>();
for(int i = 1; i < words.Length - 2; i++)
{
    string fraze = $"{words[i-1]} {words[i]}";
    if (frazeDictionary.ContainsKey(fraze))
    {
        frazeDictionary[fraze]++;
    }
    else
    {
        frazeDictionary.Add(fraze, 1);
    }
}

var top15Fraze = frazeDictionary
    .OrderByDescending(x => x.Value)
    .Take(15)
    .ToList();
Console.WriteLine("Phrase Frequency:");
top15Fraze.ForEach(x =>
{
    var freq = (double)x.Value / words.Length;
    Console.WriteLine($"- {x.Key,-22} {freq,2:P} ({x.Value})");
});*/

while (true)
{
    string a = Console.ReadLine();
    if (String.IsNullOrEmpty(a))
    {
        break;
    }
    string b = Console.ReadLine();
    Console.WriteLine(Anagrams.IsAnagram(a, b));
}