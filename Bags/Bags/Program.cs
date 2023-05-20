using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bag = 0;
            int smallbox = 0, mediumbox = 0, largebox = 0;
            double bagcost = 0, totalprice = 0;
            Console.Write("Number of Bags Ordered: ");
            bag = int.Parse(Console.ReadLine());
            bagcost = (double)bag * 5.50;
            Console.WriteLine("Boxes Used:");
            if (bag >= 20)
            {
                largebox = bag / 20;
                mediumbox = (bag%20) / 10;
                smallbox = bag % 10;
                if (smallbox > 5)
                    smallbox = 2;
                else
                    smallbox = 1;
                totalprice = (largebox * 3.00) + (mediumbox * 2.50) + (smallbox * 2.00);
            }
            else if (bag < 20 && bag >= 10)
            {
                mediumbox = bag / 10;
                smallbox = bag % 10;
                if (smallbox > 5)
                    smallbox = 2;
                else
                    smallbox = 1;
                totalprice = (mediumbox * 2.50) + (smallbox * 2.00);
            }
            else
            {
                if (smallbox > 5)
                    smallbox = 2;
                else
                    smallbox = 1;
                totalprice = smallbox * 2.00;
                
            }
            Console.WriteLine($"Large - {largebox}");
            Console.WriteLine($"Medium - {mediumbox}");
            Console.WriteLine($"Small - {smallbox}");
            double totalcost = (double)bagcost + totalprice;
            Console.WriteLine($"Your total cost is: ${totalcost:N2}");
            Console.ReadLine();
        }
    }
}
