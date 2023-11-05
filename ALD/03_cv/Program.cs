using _03_cv.Models;

/*BinaryTree<int> strom = new BinaryTree<int>();
strom.Add(7);
strom.Add(9);
strom.Add(11);
strom.Add(3);
Console.WriteLine("Prvky stromu: " + strom.Print());
Console.WriteLine("Vyska: " + strom.MaxDepth());
strom.PrintTree();
strom.DeleteNode(3);
Console.WriteLine("Prvky stromu: " + strom.Print());
Console.WriteLine("Vyska: " + strom.MaxDepth());
strom.PrintTree();*/

AVL<int> tree = new AVL<int>();
string input = "2 8 2 8 6 -1"; //Console.ReadLine();
foreach (string item in input.Split(" "))
{
    tree.Add(int.Parse(item));
}
tree.PrintTree();
Console.WriteLine(tree.Preorder());
Console.WriteLine(tree.Inorder());
Console.WriteLine(tree.Postorder());
