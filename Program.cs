// See https://aka.ms/new-console-template for more information
public class ITEC104_ENGAGINGACT_ISORENA
{
    struct Employee
    {
        public string firstName;
        public string lastName;
        public int age;
        public string completedTraining;
    }
    public static void Main(string[] args)
    {

        Employee Employee1;

        Console.WriteLine("WHAT IS YOUR FIRSTNAME? ");
        Employee1.firstName = Console.ReadLine();

        Console.WriteLine("WHAT IS YOUR LASTNAME? ");
        Employee1.lastName = Console.ReadLine();

        Console.WriteLine("WHAT IS YOUR AGE? ");
        Employee1.age = int.Parse(Console.ReadLine());

        Console.WriteLine("ARE YOU COMPLETED IN TRAINING ? YES OR NO ");
        Employee1.completedTraining = Console.ReadLine();

        Console.WriteLine("--------------------------------------------------------------- ");

        Console.WriteLine("LOOK YOUR INFORMATION BELOW ");

        Console.WriteLine("FIRSTNAME             : " + Employee1.firstName);

        Console.WriteLine("LASTNAME              : " + Employee1.lastName);

        Console.WriteLine("AGE                   : " + Employee1.age);

        Console.WriteLine("COMPLETED IN TRAINING : " + Employee1.completedTraining);





    }
}
        
