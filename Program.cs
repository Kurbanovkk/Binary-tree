namespace Binary_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                BinaryTree tree = new BinaryTree();

                Console.WriteLine("Введите информацию о сотрудниках:");
                while (true)
                {
                    Console.Write("Имя сотрудника (пустая строка для завершения): ");
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        break;
                    }

                    Console.Write("Зарплата: ");
                    if (int.TryParse(Console.ReadLine(), out int salary))
                    {
                        tree.Insert(name, salary);
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат зарплаты. Попробуйте снова.");
                    }
                }

                Console.WriteLine("\nИмена сотрудников и их зарплаты в порядке возрастания зарплат:");
                tree.InOrderTraversal();

                Console.Write("\nВведите зарплату для поиска сотрудника: ");
                if (int.TryParse(Console.ReadLine(), out int searchSalary))
                {
                    string employee = tree.FindEmployeeBySalary(searchSalary);
                    Console.WriteLine(employee);
                }
                else
                {
                    Console.WriteLine("Неверный формат зарплаты.");
                }

                Console.Write("Введите 0 для завершения или 1 для повторного поиска: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    continueProgram = (choice == 1);
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Завершение программы.");
                    continueProgram = false;
                }
            }
        }
    }
}