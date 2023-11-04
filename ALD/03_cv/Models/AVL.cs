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
            public Node(T value)
            {
                this.value = value;
            }
            public override string ToString()
            {
                return $"{value}";
            }
        }

        /// <summary>
        /// Přidá nový prvek
        /// </summary>
        /// <param name="value">Hodnota přidávaného prvku</param>
        public void Add(T value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }
            AddRek(root, value);
        }
        private void AddRek(Node tempRoot, T value)
        {
            if (value.CompareTo(tempRoot.value) <= 0)
            {
                if (tempRoot.left != null)
                {
                    AddRek(tempRoot.left, value);
                }
                else
                {
                    tempRoot.left = new Node(value);
                }
            }
            else
            {
                if (tempRoot.right != null)
                {
                    AddRek(tempRoot.right, value);
                }
                else
                {
                    tempRoot.right = new Node(value);
                }
            }
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
    }
}
