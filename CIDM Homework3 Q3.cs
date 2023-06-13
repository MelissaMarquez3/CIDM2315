namespace Homework3Q3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0;i<n;i++) {
        for(int j = 0;j<n;j++){
            Console.Write("#");
        }
            Console.WriteLine();
        }
    }
}
