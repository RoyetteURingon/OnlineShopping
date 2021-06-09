using System;
using System.Collections.Generic;

namespace OnlineShopping
{
    class Program
    {
       
        // dito po ang main class ko na kung saan nacacall ang login
        //at display elements.
        private static void Main(string[] args)
        {

            login log = new login();

            log.DisplayElements();

        }
    }
}