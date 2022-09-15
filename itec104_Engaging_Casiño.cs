public class Engaging {
    struct Employee
    {
        public string FirstName;
        public string LastName;
        public int age;
        public string CompletedTraining;
    }
    public static void Main(string[] args){

        Employee emp;

        Console.WriteLine("What is your First Name?");
        emp.FirstName = Console.ReadLine( );
        Console.WriteLine("Your Last Name?");
        emp.LastName = Console.ReadLine( );
        Console.WriteLine("Your Age?");
        emp.age = int.Parse(Console.ReadLine( ));
        Console.WriteLine("Are you Completed the training?");
        emp.CompletedTraining =Console.ReadLine( );

        Console.WriteLine();
        Console.WriteLine("ENTER TO SEE RESULTS");
        Console.ReadLine();

        Console.WriteLine("You entered");
        Console.WriteLine();

        Console.WriteLine("FIRST NAME : "+ emp.FirstName);
        Console.WriteLine("LAST NAME : "+ emp.LastName);
        Console.WriteLine("AGE : "+ emp.age);
        Console.WriteLine("COMPLETED TRAINING: "+ emp.CompletedTraining);
        }
}
