
namespace Binary_tree
{
    internal class BinaryTree
    {
        private Node root;


        public void Insert(string name, int salary)
        {
            root = InsertRec(root, name, salary);
        }
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        private Node InsertRec(Node root, string name, int salary)
        {
            if (root == null)
            {
                return new Node(name, salary);
            }

            if (salary < root.Salary)
            {
                root.Left = InsertRec(root.Left, name, salary);
            }
            else if (salary > root.Salary)
            {
                root.Right = InsertRec(root.Right, name, salary);
            }

            return root;
        }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.WriteLine($"{root.Name} - {root.Salary}");
                InOrderTraversal(root.Right);
            }
        }

        public string FindEmployeeBySalary(int salary)
        {
            return FindEmployeeBySalary(root, salary);
        }

        private string FindEmployeeBySalary(Node root, int salary)
        {
            if (root == null)
            {
                return "такой сотрудник не найден";
            }

            if (salary == root.Salary)
            {
                return root.Name;
            }

            if (salary < root.Salary)
            {
                return FindEmployeeBySalary(root.Left, salary);
            }
            else
            {
                return FindEmployeeBySalary(root.Right, salary);
            }
        }
    }
}
