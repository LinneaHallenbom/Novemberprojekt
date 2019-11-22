using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class RiverFish : Fish
    {
        public void RandomizeCommonriver(int FishesCaught, bool levelcheck)
        {
           
            //tog hjälp ifrån https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
            //Randomerar en string från listan
            var random = new Random();
            var CommonRiverFish = new List<string> { "Rainbow trout", "Brown trout", "Channel catfish", "Black crappie", "Buffalo" };
            //ser hur lång listan är och randomerar siffran som count blir
            int index = random.Next(CommonRiverFish.Count);
            //skriver ut den fisken som är på nummret som det blec
            Console.WriteLine(CommonRiverFish[index]);
            Console.ReadLine();
            //kallar på level metoden för att gå upp i level nu nå
            Program.Level(FishesCaught, levelcheck);




        }
        public void RandomizeRareriver(int FishesCaught, bool levelcheck)
        {
            var random = new Random();
            var RareRiverFish = new List<string> { "Eel", "Bullhead", "Spined loach", "Twaite shad", "Crucian carp" };
            int index = random.Next(RareRiverFish.Count);
            Console.WriteLine(RareRiverFish[index]);
            Console.ReadLine();
            Program.Level(FishesCaught, levelcheck);

        }




    }

}
