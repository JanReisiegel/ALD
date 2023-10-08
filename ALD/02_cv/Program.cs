using _02_cv.Models;

/*Zasobnik<string> zs = new Zasobnik<string>();
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
*/

Train train = new Train();
while (true)
{
    string input = Console.ReadLine();
    string[] inputArgs = input.Split(' ');
    switch(inputArgs[0])
    {
        case "push":
            Console.WriteLine(train.Push(inputArgs[1], Int32.Parse(inputArgs[2])));
            break;
        case "pop":
            if (inputArgs[1].StartsWith("id"))
            {
                string id = inputArgs[1].Split(":")[1];
                Console.WriteLine(train.Pop(id));
            }
            else if (inputArgs[1].StartsWith("pos"))
            {
                int pos = 0;
                try
                {
                    pos = Int32.Parse(inputArgs[1].Split(":")[1]);
                }
                catch(FormatException)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(train.Pop(pos));
            }
            break;
        case "move":
            Console.WriteLine(train.Move(inputArgs[1], Int32.Parse(inputArgs[2])));
            break;
        case "total_weight":
            Console.WriteLine(train.GetTotalWeight());
            break;
        case "print":
            Console.WriteLine(train.PrintTrain());
            break;
        default: 
            Console.WriteLine("error");
            break;
    }
}