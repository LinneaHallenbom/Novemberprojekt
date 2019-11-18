using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingsimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
            Console.WriteLine("Welcome to fishing simulator");

        }


        static void StartGame()
        {
            bool GameIsRunning = true;

            
            bool answeriscorrect = false;

            while (GameIsRunning == true)
            {

                while (answeriscorrect == false)
                {                    
                    Console.WriteLine("Do you want to fish in river or ocean?");
                    string answer = Console.ReadLine();
                    string answercheck = answer.ToUpper();

                    if (answercheck == "RIVER")
                    {
                        Console.WriteLine("at the river");
                        Fish fishriver = new Fish();
                        fishriver.Willyoucatchfish(answercheck);
                        answercheck = "";
                        
                    }
                    else if (answercheck == "OCEAN")
                    {
                        Console.WriteLine("at the ocean");
                        Fish fishocean = new Fish();
                        answercheck = "";
                    }
                    else if (answercheck == "GO BACK")
                    {
                        answeriscorrect = true;
                        Console.WriteLine("Going back");
                    }
                    else
                    {
                        Console.WriteLine("You have to choose where to fish");

                    }


                }


                Console.WriteLine("out of loop");
                Console.ReadLine();

            }



        }

       

    }
}

