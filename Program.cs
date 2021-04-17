using System;
namespace OnlineShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string N, P;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("WELCOME TO LAZASHOP 11.11!!!");
            Console.WriteLine("Please Login");
            Console.Write("Enter Your Username: ");
            N = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            P = Console.ReadLine();

            if (P == "Ringon")
            {
                Console.WriteLine(" Login Successful!!!");
                Console.WriteLine("*********************************************************");
                Console.ReadLine();

                Console.WriteLine("Categories");

                Console.WriteLine("Gadgets: ");
                Console.WriteLine("Sony PS4 Controller V2 DualShock 4 Wireless Controller Original Brand New for PlayStation 4 : $64.12");
                Console.WriteLine("Replacement PS4 Wireless Controller for PlayStation 4 : $16.11");
                Console.WriteLine("PS4 DualShock 4 Wireless Controller Working on PS4, PC Windows 7, 8, and 10 : $14.21");

                Console.WriteLine("Accessories: ");
                Console.WriteLine("Fantech Mousepad Basic XL MP64 Gaming Extended Mouse Pad : $1.96");
                Console.WriteLine("70x30cm Extra Large Super Gaming Mousepad Professional Computer Mouse Pad Grande Keyboard Mat : $2.27");
                Console.WriteLine("Extended Gaming Mouse Pad Large Mat Gaming Mat Keyboard and mouse pad (assorted designs) :$2.66");

                Console.WriteLine("Home Entertainment: ");
                Console.WriteLine("PORTABLE KARAOKE SPEAKER FREE MICROPHONE FREE USB : $18.36");
                Console.WriteLine("KTS Portable Karaoke Speaker with FREE Microphone FREE USB : $12.18");
                Console.WriteLine("New Megapro FPA-1106 Dual Speaker Portable multifunction Karaoke Free wired microphone : $22.70");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
            
        }
    }
}