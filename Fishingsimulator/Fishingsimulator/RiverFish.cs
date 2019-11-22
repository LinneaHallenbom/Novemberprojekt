using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class RiverFish : Fish
    {
        public void RandomizeCommonriver(int FishesCaught)
        {
           
            //tog hjälp ifrån https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
            var random = new Random();
            var CommonRiverFish = new List<string> { "Rainbow trout", "Brown trout", "Channel catfish", "Black crappie", "Buffalo" };
            int index = random.Next(CommonRiverFish.Count);
            Console.WriteLine(CommonRiverFish[index]);
            Console.ReadLine();
            Program.Level(FishesCaught);




        }
        public void RandomizeRareriver(int FishesCaught)
        {
            var random = new Random();
            var RareRiverFish = new List<string> { "Eel", "Bullhead", "Spined loach", "Twaite shad", "Crucian carp" };
            int index = random.Next(RareRiverFish.Count);
            Console.WriteLine(RareRiverFish[index]);
            Console.ReadLine();
            Program.Level(FishesCaught);

        }




    }

}
