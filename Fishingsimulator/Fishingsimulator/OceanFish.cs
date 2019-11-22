using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class OceanFish : Fish
    {
        
        public void Randomizecommonocean(int FishesCaught, bool levelcheck)
        {
            var random = new Random();

            var CommonOceanFish = new List<string> { "Dab", "Flounder", "Cod", "Red cod", "Sea bass", "Coalfish" };
            int index = random.Next(CommonOceanFish.Count);
            Console.WriteLine(CommonOceanFish[index]);
            Console.ReadLine();
            Program.Level(FishesCaught, levelcheck);

        }
        public void Randomizerareocean(int FishesCaught, bool levelcheck)
        {
            var random = new Random();
            var RareOceanFish = new List<string> { "Seahorse", "Whiteshark", "Knifejawshark", "Jellyfish" };
            int index = random.Next(RareOceanFish.Count);
            Console.WriteLine(RareOceanFish[index]);
            Console.ReadLine();
            Program.Level(FishesCaught, levelcheck);

        }

       
    }
}
