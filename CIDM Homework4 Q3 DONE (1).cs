namespace Homework4Q3;

class Program
{
    static void Main(string[] args)
    {
        // createAccount () method 
        createAccount();
        Console.ReadKey(true);
    }
    public static bool checkAge(int birth_year)
{
    //calculate age
    int age=2022-birth_year;
    //if age is greater than or equal to 18, then return true
    if(age>=18)
        return true;
    //otherwise return false
    else
        return false;
}
public static void createAccount()
{
    //declare string variables userName, password and retypedPassword
    String userName,password,retypedPassword;
    //declare interger variable birthyear
    int birthYear;
    //prompt user to enter user name
    Console.WriteLine("Enter Your Username:");
    //read userName
    userName=Console.ReadLine();
    //prompt user to enter password
    Console.WriteLine("Enter Your Password:");
    //read password
    password=Console.ReadLine();
    //prompt user to enter password again
    Console.WriteLine("Enter Your Password Again:");
    //read retypedPassword
    retypedPassword=Console.ReadLine();
    //prompt user to enter birth year
    Console.WriteLine("Enter Your Birthyear:");
    //read birthYear
    birthYear=Convert.ToInt32(Console.ReadLine());
    //if checkAge() return true, then
    if (checkAge(birthYear))
    {
        //if password and retypedPassword are equal, then displays
        //"Account is created successfully"
        if (password==retypedPassword)
            Console.WriteLine("Account is created successfully");
            //otherwise display "Wrong password"
            else
                Console.WriteLine("Wrong password");
    }
    //otherwise display "Could not create an account."
    else
        Console.WriteLine("Could not create an account.");
    }

}
