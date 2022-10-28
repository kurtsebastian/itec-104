using System.Collections;

namespace midtermkurt
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(10);

            Console.WriteLine("Stack MENU");
            Console.WriteLine("1. Add an Element");
            Console.WriteLine("2. See the Top ELement");
            Console.WriteLine("3. Remove the Top Element");
            Console.WriteLine("4. Display Stack Elements");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter the element: ");
                    s.Push(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Item Pushed Successfully!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("The top of the element is " + s.Peek());
                }
                else if (choice == 3)
                {
                    s.Pop();
                    Console.WriteLine("Top of s is removed!!");
                    Console.WriteLine("New Top of s is " + s.Peek());
                }
                else if (choice == 4)
                {
                    foreach (int ss in s)
                    {
                        Console.WriteLine(ss);
                    }
                }
                else if (choice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }

                Console.WriteLine();
            }
        }
    }
}
