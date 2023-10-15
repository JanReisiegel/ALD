using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_cv.Models
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        Node root;
        public class Node
        {
            public T value;
            public Node left, right;
            public Node(T input)
            {
                value = input;
            }
        }
        /// <summary>
        /// Přidá nový prvek
        /// </summary>
        /// <param name="input">Hodnota přidávaného prvku</param>
        public void Add(T input)
        {
            if (root == null)
            {
                root = new Node(input);
                return;
            }
            AddRek(root, input);
        }
        private void AddRek(Node temporaryRoot, T input)
        {
            if (input.CompareTo(temporaryRoot.value) <= 0)
            {
                if (temporaryRoot.left != null)
                {
                    AddRek(temporaryRoot.left, input);
                }
                else
                {
                    temporaryRoot.left = new Node(input);
                }
            }
            else
            {
                if (temporaryRoot.right != null)
                {
                    AddRek(temporaryRoot.right, input);
                }
                else
                {
                    temporaryRoot.right = new Node(input);
                }
            }
        }
        /// <summary>
        /// Vypíše Strom do konzole, tak ja vypadá
        /// </summary>
        public void PrintTree()
        {
            PrintF(root);
        }
        /// <summary>
        /// Vypíše prvky stromu
        /// </summary>
        /// <returns>string</returns>
        public string Print()
        {
            return root == null ? "Tree is empty" : PrintRek(root);
        }
        private string PrintRek(Node temporaryRoot)
        {
            string result = "";
            if (temporaryRoot.left != null)
            {
                result = PrintRek(temporaryRoot.left);
            }
            if (temporaryRoot.right != null)
            {
                result = PrintRek(temporaryRoot.right);
            }
            return temporaryRoot.value + " " + result;
        }
        /// <summary>
        /// Vrátí maximální hloubku stromu
        /// </summary>
        /// <returns></returns>
        public int MaxDepth()
        {
            return root == null ? 0 : DepthRek(root);
        }
        private int DepthRek(Node temporaryRoot)
        {
            if (temporaryRoot == null)
                return 1;
            int left = DepthRek(temporaryRoot.left) + 1;
            int right = DepthRek(temporaryRoot.right) + 1;
            return left > right ? left : right;
        }
        /// <summary>
        /// Vrátí počet prvků ve stromu
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return root == null ? 0 : CountRek(root) - 1;
        }
        private int CountRek(Node temporaryRoot)
        {
            if (temporaryRoot == null)
                return 1;
            int left = CountRek(temporaryRoot.left);
            int right = CountRek(temporaryRoot.right);
            return left + right;
        }
        /// <summary>
        /// Vrátí počet prvků s hodnotou
        /// </summary>
        /// <param name="inputValue">Hodnota prků</param>
        /// <returns></returns>
        public int CountItemsWithValue(T inputValue)
        {
            return root == null ? 0 : CountItemsWithValueRek(root, inputValue);
        }
        private int CountItemsWithValueRek(Node temporaryRoot, T inputValue)
        {
            if (temporaryRoot != null)
            {
                int count = inputValue.CompareTo(temporaryRoot.value) == 0 ? 1 : 0;
                int left = CountItemsWithValueRek(temporaryRoot.left, inputValue);
                int right = CountItemsWithValueRek(temporaryRoot.right, inputValue);
                return count + left + right;
            }
            return 0;
        }
        /// <summary>
        /// Smaže prvek s udanou hodnotou
        /// </summary>
        /// <param name="value">Hodnota mazaného prvku</param>
        public void DeleteNode(T value)
        {
            if (root == null)
                return;
            DeleteNodeRek(root, value);
        }
        private Node? DeleteNodeRek(Node temporaryRoot, T deleteValue)
        {
            if (temporaryRoot == null)
                return null;
            if (deleteValue.CompareTo(temporaryRoot.value) < 0)
            {
                temporaryRoot.left = DeleteNodeRek(temporaryRoot.left, deleteValue);
            }
            else if (deleteValue.CompareTo(temporaryRoot.value) > 0)
            {
                temporaryRoot.right = DeleteNodeRek(temporaryRoot.right, deleteValue);
            }
            else
            {
                if (temporaryRoot.left == null)
                {
                    return temporaryRoot.right;
                }
                else if (temporaryRoot.right == null)
                {
                    return temporaryRoot.left;
                }
                temporaryRoot.value = MinValue(temporaryRoot.right);
                temporaryRoot.right = DeleteNodeRek(temporaryRoot.right, temporaryRoot.value);
            }
            return temporaryRoot;
        }
        private T MinValue(Node temporaryRoot)
        {
            T result = temporaryRoot.value;
            while (temporaryRoot.left != null)
            {
                result = temporaryRoot.left.value;
                temporaryRoot = temporaryRoot.left;
            }
            return result;
        }
        class NodeInfo
        {
            public Node Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }


        private void PrintF(Node root, int topMargin = 2, int leftMargin = 2)
        {
            if (root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.value.ToString() };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + 1;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.left)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos);
                    }
                }
                next = next.left ?? next.right;
                for (; next == null; item = item.Parent)
                {
                    Print(item, rootTop + 2 * level);
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos;
                        next = item.Parent.Node.right;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos;
                        else
                            item.Parent.StartPos += (item.StartPos - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(NodeInfo item, int top)
        {
            SwapColors();
            Print(item.Text, top, item.StartPos);
            SwapColors();
            if (item.Left != null)
                PrintLink(top + 1, "┌", "┘", item.Left.StartPos + item.Left.Size / 2, item.StartPos);
            if (item.Right != null)
                PrintLink(top + 1, "└", "┐", item.EndPos - 1, item.Right.StartPos + item.Right.Size / 2);
        }

        private static void PrintLink(int top, string start, string end, int startPos, int endPos)
        {
            Print(start, top, startPos);
            Print("─", top, startPos + 1, endPos);
            Print(end, top, endPos);
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }

        private static void SwapColors()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }
    }
}
