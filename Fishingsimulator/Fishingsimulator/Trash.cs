using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class Trash : Fish
    {

        public void RandomizeTrash()
        {
            var random = new Random();
            var TrashFish = new List<string> { "Boots", "Algae", "Plastic bottle", "Pen", "Paper" };
            int index = random.Next(TrashFish.Count);
            Console.WriteLine(TrashFish[index]);
            Console.ReadLine();

          

        }



    }
}
