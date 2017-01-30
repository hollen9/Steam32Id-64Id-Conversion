using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_SteamIDConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string steam64id = "";
            Console.Write("Input Steam64ID: ");
            while (String.IsNullOrWhiteSpace(steam64id))
                steam64id = Console.ReadLine();
            //bool is64EvenNotOdd;
            int Steam32IdArgY;
            string Steam32IdArgZ;

            char char_steam64id_unitdigit = steam64id[steam64id.Length - 1];
            byte byte_steam64id_unitdigit = (byte)Char.GetNumericValue(char_steam64id_unitdigit);

            /*if (byte_steam64id_unitdigit % 2 == 1) Steam32IdArgY = 1;
            else Steam32IdArgY = 0;*/

            Steam32IdArgY = (byte_steam64id_unitdigit % 2 == 1) ? 1 : 0; 

            ulong ulong_steam64id_skip3 = ulong.Parse(steam64id.Substring(3));

            Steam32IdArgZ = ((ulong_steam64id_skip3 - 61197960265728 - (ulong)Steam32IdArgY) / 2).ToString();

            string Steam32id = "";
            Steam32id = "STEAM_1:" + Steam32IdArgY + ":" + Steam32IdArgZ;

            Console.WriteLine("Steam 32 ID is {0}", Steam32id);

            Console.Write("Program Ended. Press ANY key to quit... ");
            Console.ReadKey();
        }
    }
}
