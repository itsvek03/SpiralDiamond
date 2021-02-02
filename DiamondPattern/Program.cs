using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s, k, j;
            Console.Write("Enter the number of rows: ");
            int nrow = Convert.ToInt32(Console.ReadLine());
            

            for (i = 1; i <= nrow; i++) 
            {
                for (s = 1; s <= nrow - i; s++) 
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write(j); 
                }

                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write(k); 
                }

                Console.WriteLine(); 
            }



            for (i = nrow-1; i >= 1; i--) 
            {
                for (s = 1; s <= nrow - i; s++) 
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j); 
                }
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write(k); 
                }
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
