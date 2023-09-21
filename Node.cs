using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    internal class Node
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string name, int salary)
        {
            Name = name;
            Salary = salary;
            Left = null;
            Right = null;
        }
    }
}
