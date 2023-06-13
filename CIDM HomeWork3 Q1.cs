namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        bool flag = true;
        Console.WriteLine("Input an integer:  "); //Prompt User to enter integer 
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input); //Converting input of sting to interger type 
        for(int i=2;i<number/2;i++) //For loop for cheaking prime number 
        {
            if(number%i==0)
            {
                flag = false;
                break;
            }
        }
        if (flag) //If flag is true then input is prime else number is non-prime 
        {
            Console.WriteLine(input +" is prime");
        }
        else{
            Console.WriteLine(input+" is non-prime");
        }
    }
}


        

          
        

    
