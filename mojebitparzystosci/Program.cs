using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojebitparzystosci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[8] { 1, 1, 1, 0, 1, 0, 0, 1 };
            int[] array2 = new int[8];
            array2[1] = array1[0];

            for (int i = 0; i < 7; i++)
            {

                array2[1] = array2[1] ^ array1[i + 1];
            }

            Console.Write(array2[1]);
            System.Console.ReadKey();


        }
    }
}