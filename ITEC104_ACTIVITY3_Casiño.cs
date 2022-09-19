using System;
  namespace ACT3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "kurt@gmail.com","seb@gmail.com","tian@gmail.com"};
            string[] username = { "kurt14", "seb15", "tian16" };
            string[] password = { "kurt1234", "seb4321", "tian5678" };

            Console.Write("INDEX : ");
            int INDEX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("EMAIL : " + emails[INDEX]);
            Console.WriteLine("USENAME : " + username[INDEX]);
            Console.WriteLine("PASSWORD : " + password[INDEX]);
        }
    }
}
