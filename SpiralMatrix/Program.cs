using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the no of row: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the no of column: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
           
            generateSpiralPattern(num,num2);
            Console.ReadKey();
        }

        private static void generateSpiralPattern(int num,int  num2)
        {
            int row = 0, col = 0, lowerLimit = 0, upperLimit = num2;
            int startValue = 1;
            int maxValue = num * num2;

            int[,] storeValue = new int[num,num2];

            //Main outerloop
            while(startValue <= maxValue)
            {
                while (col < upperLimit && startValue<=maxValue) {

                   storeValue[row,col]= startValue++;
                    col++;
                } // row will changed and column will be increnmented
                col--;
                row++;




                while (row < upperLimit && startValue <= maxValue) {
                    storeValue[row, col] = startValue++;
                    row++;
                }// row will be same column will be decremented
                row--;
                col--;


                while (col>lowerLimit && startValue <= maxValue) {
                    storeValue[row, col] = startValue++;
                    col--;
                }//row will change and column will be same


                while (row > lowerLimit && startValue <= maxValue)
                {
                    storeValue[row, col] = startValue++;
                    row--;
                }
                row++;
                col++;
                lowerLimit++;
                upperLimit--;
            }
            Console.WriteLine("output pattern is:");

                for(int i = 0; i < num; i++)
                {
                    for(int j = 0; j < num2; j++)
                    {
                        Console.Write(storeValue[i, j] + "\t");
                    }
                    Console.WriteLine();
                }   
        }

    }
}
