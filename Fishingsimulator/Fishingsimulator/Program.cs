using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class Program
    {
        //globala variabler så att de kan nås i hela koden
        static int level { get; set; }

        static bool levelcheck = false;

        //Kallar metoden för att starta spelet
        static void Main(string[] args)
        {
            int FishesCaught = 0;
            StartGame(level, FishesCaught, levelcheck);
        }

        //Metod för att starta spelet
        static void StartGame(int level, int FishesCaught, bool levelcheck)
        {
            //När spelet startas blir level 0
            level = 0;
            bool GameIsRunning = true;

            bool answeriscorrect = false;

            while (GameIsRunning == true)
            {
                //Man måste svara korrekt för att kunna komma vidare
                while (answeriscorrect == false)
                {
                    //Konsol clear så att det inte ser så rörigt ut
                    Console.Clear();
                    Console.WriteLine("Do you want to fish in river or ocean?");
                    string answer = Console.ReadLine();
                    string answercheck = answer.ToUpper();
                    //Vart vill spelaren spela
                    if (answercheck == "RIVER")
                    {
                        //skappar en ny riverfisk
                        Console.WriteLine("at the river");
                        Fish fishriver = new Fish();
                        bool a = fishriver.Willyoucatchfish(answercheck, level, FishesCaught, levelcheck);
                        answercheck = "";

                    }
                    else if (answercheck == "OCEAN")
                    {
                        Console.WriteLine("at the ocean");
                        Fish fishocean = new Fish();
                        fishocean.Willyoucatchfish(answercheck, level, FishesCaught, levelcheck);
                        answercheck = "";
                    }




                }




            }



        }
        //level systemet, levlar upp efter varje fisk spelaren fångar och gör att det inte går att komma över 100% att fånga en fisk
        public static void Level(int FishesCaught, bool levelcheck)
        {
            

            if (levelcheck == true)
            {
                FishesCaught++;

                if (level == 50)
                {
                    FishesCaught = 0;
                }

            }

            if (FishesCaught == 1)
            {
                level += 1;

             

                //räknar ut hur många % chans det är att fånga rare och common
                int chancefish = 50 + level;
                int chancerare = 30 + level;

                
                Console.WriteLine("You went up a level, now you are level: " + level + " your chances of catching fish is now " + chancefish + " %, and your chances of rare fish is " + chancerare + " %" );
                Console.ReadLine();
            }
        }

        



    }
}

