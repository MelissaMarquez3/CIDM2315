namespace Homework3Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N; ");
        int N=Convert.ToInt16(Console.ReadLine());
        //i will run from 0 to N-1 i represent row number
        for (int i=0;i<N;i++) {
            //j will run from 0 to N-1, j reprsent column number 
            for (int j=0;j<N;j++) {
                // if row number is less than column number print space else print *
                if (i<j)
                    Console.WriteLine(" ");
                else
                    Console.Write("*");

            }
            Console.Write("\n");
        }
    }
}
