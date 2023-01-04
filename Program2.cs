using System;

namespace firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Console.Write("What is your name?: ");
        String strName = Console.ReadLine();
        Console.Write("contactnumber?: ");
        String strcontactnumber = Console.ReadLine();
        Console.WriteLine("Welcome to the C# Tutorial! {0},{1}", strName,strcontactnumber);*/
        string myInput;
        int myInt;
                
        Console.Write ("Please enter a number: ");
        myInput = Console.ReadLine();
        myInt = Int32.Parse(myInput);
    if (myInt > 10)
    {
        Console.WriteLine ("Your number {0} is greater than ten.", myInt);
    }
    else if (myInt < 10)
        Console.WriteLine ("Your number {0} is less than ten.", myInt);
    else
        Console.WriteLine ("Your number {0} is equal to ten.",myInt);
        
        }
    }
}
