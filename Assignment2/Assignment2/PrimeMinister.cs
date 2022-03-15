using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
     class PrimeMinister
    {
        static void Main(string[] args)
        {
            
            SortedDictionary<int, String> pm = new SortedDictionary<int, string>();
            pm.Add(1998, "Atal Bihari Vajpayee");
            pm.Add(2014, "Narendra Modi");
            pm.Add(2004, "Manmohan Singh");

            Console.WriteLine("Prime Minister of the year 2004 is "+ pm[2004]);
            pm.Add(2019, "Narendra Modi");

            foreach(var items in pm.Keys)
            {
                Console.WriteLine(items +"  "+pm[items]);
            }
           

            Console.ReadLine();
        }
    }
}
