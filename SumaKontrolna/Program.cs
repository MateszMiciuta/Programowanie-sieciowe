using System;
using System.Collections.Generic;
using System.Linq;

namespace Bit_parzystości
{
    class program
    {
        static void Main(string[] args)
        {
            int parity = 0;
            int bit;
            int[] array1 = new int[8] { 1, 0, 1, 0, 1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("array1[{0}]={1}", i, array1[i]);
                if (array1[i] == 1)
                    parity++;
            }
            if (parity % 2 == 0)
                bit = 0;
            else
                bit = 1;
            Console.WriteLine("Bit parzystości ma wartość: {0}", bit);
            Console.ReadKey();
        }
    }

}
            



//using System;
//using System.Collections.Generic;
//using System.Text;
//
//namespace SumaKontrolna
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//           
//          
//            
//            byte checksum = 0;
//            
//            
//            foreach (var Data in bytes ) // sumuje bity z tablicy
//            {
//                checksum += Data;
//            }
//            Console.WriteLine(bytes);
            
//            checksum &= 0x0001; //maska 
//            Console.WriteLine(checksum.ToString());
               

            
//            
//                 Console.Beep();
//            
//                
//                
// 
//            
//        }
//
//
//
//
//    }
//}


