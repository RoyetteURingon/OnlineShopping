using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
    class login
    {
        //dito naman po yung login ko na kung saan maglalog in ang user
        public void DisplayElements()
        {
            shopping itemcall = new shopping();

            string u, p;
            string user = "username";
            string pass = "password";
            string address = "Binan Laguna";


            Console.WriteLine("******************************");
            Console.WriteLine("Please Login");
            Console.Write("Enter Your Username: ");
            u = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            p = Console.ReadLine();
            Console.Write("Enter Your Address:" + address);
            Console.WriteLine("");

            if (u == user && p == pass)
            {
                itemcall.Shopping();
            }

            else
            {
                Console.WriteLine("Wrong Password");
            }
        }        
    }
}
