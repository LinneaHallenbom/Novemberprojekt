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

        public bool Willyoucatchfish(int level)
        {
            bool FishorTrash = false;
            int Randomfishornot = generator.Next(101);
            
            if (Randomfishornot + level >= 50)
            {
                Rareity();
            }
            else
            {

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
            }


            return FishorTrash;
        }

        public void Rareity()
        {
            int Rarity = generator.Next(101);
            if (Rarity + level >= 99)
            {
                
            }
            else
            {
               

            }
            
        }

        void Catchingfish()
        {


        }

    }
}
