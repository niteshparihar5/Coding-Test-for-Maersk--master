using System;
using System.Collections.Generic;
using System.Linq;

namespace Maersk
{
    class Program
    {
        static void Main(string[] args)
        {          
            //A          
            Console.WriteLine("total number of Product A");
            int a = Convert.ToInt32(Console.ReadLine());           
            List<string> lstproduct = new List<string>();
            for (int i = 0; i < a; i++)
            {               
                    lstproduct.Add("a");
            }
            //B          
            Console.WriteLine("total number of Product B");
            int b = Convert.ToInt32(Console.ReadLine());                
            for (int i = 0; i < b; i++)
            {               
                    lstproduct.Add("b");
            }
            //C          
            Console.WriteLine("total number of Product C");
            int c = Convert.ToInt32(Console.ReadLine());            
            for (int i = 0; i < c; i++)
            {              
                    lstproduct.Add("c");
            }
            //D         
            Console.WriteLine("total number of Product D");
            int d = Convert.ToInt32(Console.ReadLine());            
            for (int i = 0; i < d; i++)
            {               
                   lstproduct.Add("d");
            }           
            int totalPrice = GetTotalPrice(lstproduct);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetTotalPrice(List<string> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int price3ofA = 130;
            int counterofB = 0;
            int priceofB = 30;
            int price2ofB = 45;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;

            int priceCandD = 30;

            foreach (string item in products)
            { 
                    if (item == "a")
                    {
                        counterofA = counterofA + 1;
                    }
                    if (item == "b")
                    {
                        counterofB = counterofB + 1;
                    }
                    if (item == "c")
                    {
                        CounterofC = CounterofC + 1;
                    }
                    if (item == "d")
                    {
                        CounterofD = CounterofD + 1;
                    }               
            }
            int totalPriceofA = 0;
            if (counterofA >= 3)
            {
                int reminderA = counterofA % 3;
                int divisionA = counterofA / 3;
                totalPriceofA = price3ofA * divisionA + reminderA * priceofA;
            }
            else
            {
                totalPriceofA = priceofA * counterofA;
            }

            int totalPriceofB = 0;
            if (counterofB >= 2)
            {
                int reminderB = counterofB % 2;
                int divisionB = counterofB / 2;
                totalPriceofB = price2ofB * divisionB + reminderB * priceofB;
            }
            else
            {
                totalPriceofB = priceofB * counterofB;
            }

            int totalPriceofC = 0;
            if (CounterofC >= 1)
            {
                totalPriceofC = priceofC;
            }

            int totalPriceofD = 0;
            if (CounterofD >= 1 && CounterofC >= 1)
            {
                totalPriceofD = priceCandD;
                totalPriceofC = 0;
            }
            else if (CounterofD >= 1)
            {
                totalPriceofD = priceofD;
              
            }
            int totalPrice = totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
            return totalPrice;
        }        
    }
}
