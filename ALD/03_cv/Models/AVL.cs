using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_cv.Models
{
    public class AVL<T> where T : IComparable<T>
    {
        Node? root;
        class Node
        {
            public T value;
            public Node left, right;
            public int height;
            public Node(T value)
            {
                this.value = value;
                this.height = 0;
            }
            public int GetBallance()
            {
                return (this.left == null ? 0 : this.left.GetHeight()) - (this.right == null ? 0 : this.right.GetHeight());
            }
            public int GetHeight()
            {
                if(this == null)
                    return 0;
                return height;
            }
            public override string ToString()
            {
                return $"{value}";
            }
        }

        public void Add(T value)
        {
            if(root == null)
            {
                root = new Node(value);
                return;
            }

            if(value.CompareTo(root.value) <= 0)
            {
                root.left = AddRek(root.left,value);
            }
            else
            {
                root.right = AddRek(root.right,value);
            }
            UpdateHeight(root);

        }
        private Node AddRek(Node node, T value)
        {
            if(node == null)
            {
                return new Node(value);
            }
            if (value.CompareTo(node.value) <= 0)
            {
                node.left = AddRek(node.left,value);
            }
            else
            {
                node.right = AddRek(node.right,value);
            }

            UpdateHeight(node);

            return BalanceTree(node, value);
        }

        public string Preorder()
        {
            if (root == null)
            {
                return string.Empty;
            }
            string sb = "";
            sb += "preorder";
            sb += $"\n{root.ToString()}";
            if (root.left != null)
            {
                sb += $"{PreorderRek(root.left)}";
            }
            if (root.right != null)
            {
                sb += $"{PreorderRek(root.right)}";
            }
            return sb;
        }

        private string PreorderRek(Node node)
        {
            string sb = "";
            sb += $"\n{node.ToString()}";
            if (node.left != null)
            {
                sb += $"{PreorderRek(node.left)}";
            }
            if (node.right != null)
            {
                sb += $"{PreorderRek(node.right)}";
            }
            return sb.ToString();
        }

        public string Inorder()
        {
            if (root == null)
            {
                return String.Empty;
            }
            string sb = "inorder";
            if (root.left != null)
            {
                sb += $"{InorderRek(root.left)}";
            }
            sb += $"\n{root.ToString()}";
            if (root.right != null)
            {
                sb += $"{InorderRek(root.right)}";
            }
            return sb;
        }

        private string InorderRek(Node node)
        {
            string sb = "";
            if (node.left != null)
            {
                sb += $"{InorderRek(node.left)}";
            }
            sb += $"\n{node.ToString()}";
            if (node.right != null)
            {
                sb += $"{InorderRek(node.right)}";
            }
            return sb;
        }

        public string Postorder()
        {
            if (root == null)
            {
                return String.Empty;
            }
            string sb = "postorder";
            if (root.left != null)
            {
                sb += $"{PostorderRek(root.left)}";
            }
            if (root.right != null)
            {
                sb += $"{PostorderRek(root.right)}";
            }
            sb += $"\n{root.ToString()}";
            return sb;
        }

        private string PostorderRek(Node node)
        {
            string sb = "";
            if (node.left != null)
            {
                sb += $"{PostorderRek(node.left)}";
            }
            if (node.right != null)
            {
                sb += $"{PostorderRek(node.right)}";
            }
            sb += $"\n{node.ToString()}";
            return sb;
        }

        private void UpdateHeight(Node node)
        {
            if (node == null)
            {
                return;
            }
            node.height = Math.Max(node.right == null ? 0: node.right.GetHeight(), node.left == null ? 0 : node.left.GetHeight()) + 1;
        }

        
        private Node BalanceTree(Node node, T value)
        {
            if(node.GetBallance() > 1)
            {
                if (node.left.GetBallance() >= 1 )
                {
                    return RotateRight(node);
                }
                else if(node.left.GetBallance() <= -1 )
                {
                    node.left = RotateLeft(node.left);
                    return RotateRight(node);
                }
            }
            if(node.GetBallance() < -1)
            {
                if(node.right.GetBallance() >= 1)
                {
                    return RotateLeft(node);
                }
                else if(node.right.GetBallance() <= -1)
                {
                    node.right = RotateRight(node.right);
                    return RotateLeft(node);
                }
            }
            return node;
        }
        private Node RotateRight(Node node) 
        {
            Node temp = node.left;
            node.left = temp.right;
            temp.right = node;
            UpdateHeight(temp);
            UpdateHeight(node);
            return temp;
        }

        private Node RotateLeft(Node node)
        {
            Node temp = node.right;
            node.right = temp.left;
            temp.left = node;
            UpdateHeight(temp);
            UpdateHeight(node);
            return temp;
        }






        public void PrintTree()
        {
            PrintF(root);
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
