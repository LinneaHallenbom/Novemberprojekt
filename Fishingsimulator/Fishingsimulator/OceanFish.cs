using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class OceanFish : Fish
    {
        public void Randomizecommon()
        {
          
            var random = new Random();
            var CommonOceanFish = new List<string> { "Dab", "Flounder", "Cod", "Red cod", "Sea bass", "Coalfish" };
            int index = random.Next(CommonOceanFish.Count);
            Console.WriteLine(CommonOceanFish[index]);
            Console.ReadLine();

        }
        public void Randomizerare()
        {
            String[] RareOceanFish = { "Seahorse", "Whiteshark", "Knifejawshark", "Jellyfish" }
        }

       
    }
}
