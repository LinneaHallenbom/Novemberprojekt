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
        

        public bool Willyoucatchfish(string answercheck, int level, int FishesCaught)
        {
            bool FishorTrash = false;
            int Randomfishornot = generator.Next(101);
            
            if (Randomfishornot + level >= 40)
            {
                FishorTrash = true;
                FishesCaught++;
                Console.WriteLine("You will catch a fish");
                Console.ReadLine();
                Rarity(answercheck, level, FishesCaught);
                
            }
            else
            {
                Console.WriteLine("You didn't catch anything");
                Console.ReadLine();

                return false;
            }

           


            return true;
        }

        public void Rarity(string answercheck, int level, int FishesCaught)
        {
            int Rarity = generator.Next(101);
            if (Rarity + level >= 70)
            {
                Console.WriteLine("You caught a rare fish");
                Console.ReadLine();

                if(answercheck == "RIVER")
                {
                    RiverFish whatrareriverfish = new RiverFish();
                    whatrareriverfish.RandomizeRareriver(FishesCaught);

                }
                else if(answercheck == "OCEAN")
                {
                    OceanFish whatrareoceanfish = new OceanFish();
                    whatrareoceanfish.Randomizerareocean(FishesCaught);
                }
            }
            else
            {
                Console.WriteLine("You caught a common fish");
                Console.ReadLine();

                if (answercheck == "RIVER")
                {
                    RiverFish whatcommonriverfish = new RiverFish();
                    whatcommonriverfish.RandomizeCommonriver(FishesCaught);

                }
                else if (answercheck == "OCEAN")
                {
                    OceanFish whatcommonoceanfish = new OceanFish();
                    whatcommonoceanfish.Randomizecommonocean(FishesCaught);
                }
            }
            
        }

       
    }
}
