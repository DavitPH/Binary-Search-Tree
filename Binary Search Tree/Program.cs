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

        static void Main(string[] args)
        {
        }
    }
}
