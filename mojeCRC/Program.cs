using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojeCRC
{
    public static class Crc8
    {
        static byte[] table = new byte[256]; //talica llookup

        // x8 + x7 + x6 + x4 + x2 + 1
        const byte poly = 0xd5;

        public static byte ComputeChecksum(params byte[] bytes)
        {
            byte crc = 0;
            if (bytes != null && bytes.Length > 0)
            {
                foreach (byte b in bytes)
                {
                    crc = table[crc ^ b];
                    //Console.WriteLine(b);
                    //szukam ktory wynik o danym indeksie
                }
            }
            return crc;
          
        }

        static Crc8()
        {
            for (int i = 0; i < 256; ++i)
            {
                int temp = i;
                for (int j = 0; j < 8; ++j)
                {
                    if ((temp & 0x80) != 0)
                    {
                        temp = (temp << 1) ^ poly;
                    }
                    else
                    {
                        temp <<= 1;
                    }
                }
                table[i] = (byte)temp;
                //Console.WriteLine(table[i]);
            }
        }




        static void Main(string[] args)
        {
            
            byte crc = Crc8.ComputeChecksum(2);
            Console.WriteLine("CRC wynosi :");
            Console.WriteLine(crc);

            byte check = Crc8.ComputeChecksum(3, crc);
            Console.WriteLine("Check wynosi wynosi :");
            Console.WriteLine(check);
    
            if (check != 0)
            {
                Console.WriteLine("Error in the checksum");
            }
            if (check == 0)
            {
                Console.WriteLine("OK");
            }

           
        }
    }
}
