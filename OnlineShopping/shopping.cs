using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
    //eto naman po yung shopping ko dito po kinocall yung accessories gadgets at home entertainment.
    // nung last time po dito nakalagay lahat ng items ko pero sineparate ko na po sya ngayun
    // ginawa ko na po syang by class ngayon.
    class shopping
    {
        accessories accessoriescall = new accessories();
        Gadgets gadgetscall = new Gadgets();
        Homeentertainment hecall = new Homeentertainment();

        // display elements po eto po ung pinaka opening ng program ko na kung saan nacacall ko sya sa main class
        public void DisplayElements()
        {
            Console.WriteLine("Online Shopping Application System ");
            Console.WriteLine("WELCOME TO LAZASHOP ");
            Console.WriteLine("Discover Something New!");
        }
       //shopping method dito po nakalagay ang list ng items na pwede nila maview. 
        public void Shopping()
        {
            shopping itemcall = new shopping();
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
                           gadgetscall.getGadgets();
                            break;
                        case 'A':
                            accessoriescall.getAccessories();
                            break;
                        case 'H':
                            hecall.getHomeentertainment();
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }
            }

        }
    }
}
