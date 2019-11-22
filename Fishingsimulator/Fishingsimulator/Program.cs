using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class Program
    {
        static int level { get; set; }
        static int FishesCaught = 0;

        static void Main(string[] args)
        {
            StartGame(level, FishesCaught);
        }


        static void StartGame(int level, int FishesCaught)
        {
            level = 0;
            bool GameIsRunning = true;
          
            bool answeriscorrect = false;
            
            while (GameIsRunning == true)
            {
                
                while (answeriscorrect == false)
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to fish in river or ocean?");
                    string answer = Console.ReadLine();
                    string answercheck = answer.ToUpper();

                    if (answercheck == "RIVER")
                    {
                        Console.WriteLine("at the river");
                        Fish fishriver = new Fish();
                        bool a = fishriver.Willyoucatchfish(answercheck, level, FishesCaught);



                        answercheck = "";
                        
                    }
                    else if (answercheck == "OCEAN")
                    {
                        Console.WriteLine("at the ocean");
                        Fish fishocean = new Fish();
                        fishocean.Willyoucatchfish(answercheck, level, FishesCaught);
                        answercheck = "";
                    }
                   
                   


                }


                

            }



        }

        public static void Level(int FishesCaught)
        {
            
            
            bool FishorTrash = false;

            if (FishorTrash == true)
            {
                FishesCaught = FishesCaught + 1;
            }

            if (FishesCaught >= 5)
            {
                level += 1;
                FishesCaught = 0;
                Console.WriteLine("You went up a level, now you are level: " + level + " your chances of catching fish and rare fish increased by 1%");
                Console.ReadLine();
            }
        }

    
       

    }
}

