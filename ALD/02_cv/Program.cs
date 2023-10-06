using _02_cv.Models;

Zasobnik<string> zs = new Zasobnik<string>();
Fronta<string> fr = new Fronta<string>();
while (true)
{
    string input = Console.ReadLine();
    if (String.IsNullOrEmpty(input))
    {
        break;
    }
    string radek = "";
    foreach (string item in input.Split(" "))
    {
        char[] pole = item.ToArray();
        radek += pole[0].ToString().ToUpper();
        for (int i = 1; i < pole.Length; i++)
        {
            radek += pole[i];
        }
        radek += " ";
    }
    fr.Push(radek);
}
while (true)
{
    if (fr.IsEmpty())
    {
        break;
    }
    Console.WriteLine(fr.Pop());
}