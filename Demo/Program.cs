using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int No;
            Boolean isPrime = false;
            int[] intArray;
            Console.WriteLine("Enter number of elements ");
            No = Convert.ToInt32(Console.ReadLine());
            intArray = new int[No];
            for (int i = 0; i < No; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < intArray.Length-1; i++)
            {
                 isPrime = true;
                for (int j = 2; j < (intArray.Length / 2)-1; j++)
                {
                    if (intArray[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime == true)
                {
                    Console.WriteLine("It is Prime : {0} ", intArray[i]);
                }

            }
            Console.Read();

        }
    }
}