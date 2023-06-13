namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Please input letter grade: ");
        string letter = Console.ReadLine();
        if(letter == "A"){
            Console.WriteLine("GPA Point: 4");
        }
        else if (letter =="B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if (letter == "C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if (letter == "D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if (letter == "F"){
            Console.WriteLine("GPA Point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }
        

        //Q2
        // get three numbers from keyboard
        Console.WriteLine ("Please input number 1");
        int num1 =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine ("Please input number 2");
        int num2 =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine ("Please input number 3");
        int num3 =Convert.ToInt16(Console.ReadLine());

        int smallest = 0;
        // assume num1 = 21; num2 = 12; num3 = 3
        if(num1<=num2)//21<=12: False
        { 
            if(num1<=num3)//11<=3: False
            {
                //num1<=num2 && num1<=num3:True
                smallest = num1;
            }
            else{//num1<=num2 and num3<num1 3<11
                smallest = num3;
            }
        }
        else{//num2<num1: 12<21: True
            if (num2<=num3) //12<3: False
            {
                smallest = num2;
            }
            else  //  num3<num2: 3<12: True
            {
                smallest = num3;
            }
        }
        Console.WriteLine($"The smallest number is {smallest}");


        }
   
        
     }



    
    
    

