using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{


    class Fish
    {
        Random generator = new Random();
        int FishesCaught = 0;
        int level = 0;

        public bool Willyoucatchfish(string answercheck)
        {
            bool FishorTrash = false;
            int Randomfishornot = generator.Next(101);
            
            if (Randomfishornot + level >= 40)
            {
               
                Console.WriteLine("You will catch a fish");
                Console.ReadLine();
                Rareity(answercheck);
            }
            else
            {
                Console.WriteLine("You didn't catch anything");
                Console.ReadLine();

                return false;
            }

            //level
            if (FishorTrash == true)
            {
                FishesCaught = FishesCaught + 1;
            }

            if (FishesCaught > 5)
            {
                level = level + 1;
                FishesCaught = 0;
                Console.WriteLine("You went up a level, now you are level: " + level);
                Console.ReadLine();
            }


            return true;
        }

        public void Rareity(string answercheck)
        {
            int Rarity = generator.Next(101);
            if (Rarity + level >= 70)
            {
                Console.WriteLine("You caught a rare fish");
                Console.ReadLine();

                if(answercheck == "RIVER")
                {
                    RiverFish whatrareriverfish = new RiverFish();
                    whatrareriverfish.RandomizeRare();

                }
                else if(answercheck == "OCEAN")
                {
                    RiverFish whatcommonriverfish = new RiverFish();
                    whatcommonriverfish.RandomizeCommon();
                }
            }
            else
            {
                Console.WriteLine("You caught a common fish");
                Console.ReadLine();
            }
            
        }

        void Catchingfish()
        {


        }

    }
}
