using System;

namespace CS133PROJECT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake<string, string> myCake = new Cake<string, string>();

            myCake.Flavor = "Vanilla";
            myCake.Type = "Wedding Cake";

            Cake<string, string> myCake2 = new Cake<string, string>();

            myCake2.Flavor = "Chocolate";
            myCake2.Type = "Party Cake";


            Console.WriteLine("My first Cake is for: " + myCake.Type); 

            Console.WriteLine("My flavor for this cake is: " +  myCake.Flavor);

            Console.WriteLine("");

            Console.WriteLine("My second Cake is for: " + myCake2.Type);

            Console.WriteLine("My flavor for this cake is: " + myCake2.Flavor);
            
        }
    }
}

public class Cake<C, W>
{
    public C Flavor { get; set; }
    public W Type { get; set; }
}