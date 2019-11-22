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
        
        //Metod som kollar om du kommer fånga en fisk eller inte
        public bool Willyoucatchfish(string answercheck, int level, int FishesCaught, bool levelcheck)
        {
           //finns 0-100 som visar procent
            int Randomfishornot = generator.Next(101);
            //om generatorns tal adderat med leveln är under 50 kommer man inte fånga en fisk
            if (Randomfishornot + level >= 50)
            {
                levelcheck = true;
                
               
                Console.WriteLine("You will catch a fish");
                Console.ReadLine();
                //kallar rarity metoden
                Rarity(answercheck, level, FishesCaught, levelcheck);
                
            }
            //mellan 10-20 kan man fånga trash
            else if (Randomfishornot + level < 20 && Randomfishornot + level > 10)
            {
                Console.WriteLine("You will catch trash");
                Console.ReadLine();
                
                Trash whichtrash = new Trash();
                whichtrash.RandomizeTrash();
            }
            else 
            {
                Console.WriteLine("You didn't catch anything");
                Console.ReadLine();

                return false;
            }

           


            return true;
        }
        //bestämmer om spelaren fångar rare eller common
        public void Rarity(string answercheck, int level, int FishesCaught, bool levelcheck)
        {
            //level påverkar sannorlikheten till att fånga en rare
            int Rarity = generator.Next(101);
            if (Rarity + level >= 70)
            {
                Console.WriteLine("You caught a rare fish");
                Console.ReadLine();
                //kollar vad spelaren tidigare valde att fiska
                if(answercheck == "RIVER")
                {
                    //om man valde river så kallas metoden för rare river fishes
                    RiverFish whatrareriverfish = new RiverFish();
                    whatrareriverfish.RandomizeRareriver(FishesCaught, levelcheck);

                }
                else if(answercheck == "OCEAN")
                {
                    OceanFish whatrareoceanfish = new OceanFish();
                    whatrareoceanfish.Randomizerareocean(FishesCaught, levelcheck);
                }
            }
            else
            {
                // samma sak för rare händer på common
                Console.WriteLine("You caught a common fish");
                Console.ReadLine();

                if (answercheck == "RIVER")
                {
                    RiverFish whatcommonriverfish = new RiverFish();
                    whatcommonriverfish.RandomizeCommonriver(FishesCaught, levelcheck);

                }
                else if (answercheck == "OCEAN")
                {
                    OceanFish whatcommonoceanfish = new OceanFish();
                    whatcommonoceanfish.Randomizecommonocean(FishesCaught, levelcheck);
                }
            }
            
        }

       
    }
}
