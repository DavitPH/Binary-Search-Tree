using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;


        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    class Program
    {
        public Node ROOT;
        public program()
        {
            ROOT = null;
        }

        public void search(string element, ref Node parent, ref Node currentNode)
        {
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }

        public void insert(string element)
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }

        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + "");
                inorder(ptr.rightchild);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
