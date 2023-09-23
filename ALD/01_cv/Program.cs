/*while (true)
{
    int num = Int32.Parse(Console.ReadLine());
    if (num == 42)
        return;
    Console.WriteLine(num);
}*/

/*while (true)
{
    string slovo = Console.ReadLine();
    if (String.IsNullOrEmpty(slovo))
        return;
    char[] slovo2 = slovo.Reverse().ToArray();
    string slovo3 = "";
    foreach (char c in slovo2)
    {
        slovo3 += c;
    }
    if (slovo.ToLower() == slovo3.ToLower())
        Console.WriteLine("ano");
    else Console.WriteLine("ne");

}*/

using System.Numerics;

while (true)
{
    BigInteger num = BigInteger.Parse(Console.ReadLine());
    if (num == -1) return;
    num++;
    string nums = $"{num}";
    int[] ints = new int[nums.Length];
    string[] snum = nums.Split();
    int lichy = nums.Length % 2;
    int[] vysledek = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        vysledek[i] = Int32.Parse(snum[i]);
        if (i < (nums.Length / 2) + lichy)
            ints[i] = Int32.Parse(snum[i]);
    }
}