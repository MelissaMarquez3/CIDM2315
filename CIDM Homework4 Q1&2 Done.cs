namespace Homework4Q1;



//Q1  method in Main()
public class Largest1
{
    public static int largest(int num1, int num2)
{
    if (num1 > num2)
{
        return num1;
}
else
{
        return num2;
    }
}
    static void Main(string[] args)
    {
        Console.Write("a= ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));
        
    }
}


//Q2 method in Main()
public class Largest2
{
    public static int largest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
}
public static int largest(int num1,int num2,int num3, int num4)
{
    return largest(largest(num1,num2), largest(num3, num4));
}
public  void Main(string[] args)
{
        Console.Write("a= ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("c= ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("d= ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
}    

//Q3
//create account method ()





