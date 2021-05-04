using System;
using System.Collections.Generic;

namespace OnlineShopping
{
    class Program
    {
        static void DisplayElements()
        {
            Console.WriteLine("Online Shopping Application System ");
            Console.WriteLine("WELCOME TO LAZASHOP ");
            Console.WriteLine("Discover Something New!");
        }
        static void shopping()
        {
            List<string> items = new List<string>();
            Console.WriteLine("These Are The Available Items : ");
            Console.WriteLine("");
            items.Add("Categories");
            items.Add("Gadgets ");
            items.Add("Accessories ");
            items.Add("Home Entertainment ");
            foreach (string list in items)
            {
                Console.WriteLine(list);

                {
                    Console.WriteLine("Press G To view Gadgets");
                    Console.WriteLine("Press A To view Accessories");
                    Console.WriteLine("Press H To view Home Entertainment");
                    char select = Convert.ToChar(Console.ReadLine());
                    select = char.ToUpper(select);

                    switch (select)
                    {
                        case 'G':
                            gadgets();
                            break;
                        case 'A':
                            accessories();
                            break;
                        case 'H':
                            homeentertainment();
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }
            }
            static void gadgets()
            {
                Console.WriteLine("");
                Console.WriteLine("Gadgets: ");
                Console.WriteLine("Sony PS4 Controller V2 DualShock 4 Wireless Controller Original Brand New for PlayStation 4 : $64.12");
                Console.WriteLine("Replacement PS4 Wireless Controller for PlayStation 4 : $16.11");
                Console.WriteLine("PS4 DualShock 4 Wireless Controller Working on PS4, PC Windows 7, 8, and 10 : $14.21");
                Console.WriteLine("");
            }
            static void accessories()
            {
                Console.WriteLine("");
                Console.WriteLine($"Accessories: ");
                Console.WriteLine("Fantech Mousepad Basic XL MP64 Gaming Extended Mouse Pad : $1.96");
                Console.WriteLine("70x30cm Extra Large Super Gaming Mousepad Professional Computer Mouse Pad Grande Keyboard Mat : $2.27");
                Console.WriteLine("Extended Gaming Mouse Pad Large Mat Gaming Mat Keyboard and mouse pad (assorted designs) :$2.66");
                Console.WriteLine("");
            }
            static void homeentertainment()
            {
                Console.WriteLine("");
                Console.WriteLine($"Home Entertainment: ");
                Console.WriteLine("PORTABLE KARAOKE SPEAKER FREE MICROPHONE FREE USB : $18.36");
                Console.WriteLine("KTS Portable Karaoke Speaker with FREE Microphone FREE USB : $12.18");
                Console.WriteLine("New Megapro FPA-1106 Dual Speaker Portable multifunction Karaoke Free wired microphone : $22.70");
                Console.WriteLine("");
                Console.ReadLine();
            }
        }

        private static void Main(string[] args)
        {
            DisplayElements();
            string u, p;
            string user = "username";
            string pass = "password";


            Console.WriteLine("*********************************************************");
            Console.WriteLine("Please Login");
            Console.Write("Enter Your Username: ");
            u = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            p = Console.ReadLine();
            Console.WriteLine("");

            if (u == user && p == pass)
            {
                shopping();
            }

            else
            {
                Console.WriteLine("Wrong Password");
            }



        }
    }
}