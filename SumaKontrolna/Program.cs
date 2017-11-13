using System;
using System.Collections.Generic;
using System.Text;

namespace SumaKontrolna
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            Console.Write("Wpisz :  ");
            String st = "";
            st = Console.ReadLine();
            byte[] bytes = Encoding.ASCII.GetBytes(st);
            byte checksum = 0;
            foreach (var Cdata in bytes )
            {
                checksum += Cdata;
            }

            checksum &= 0x0001;
            Console.WriteLine(checksum.ToString(("x2")));
                
                 
            
                
                
 
            
        }




    }
}
