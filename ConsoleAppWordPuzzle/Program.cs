using System;

namespace WordPuzzleGame
{
    class Game
    {


        String input = "";


        int Score = 0;
        string[] Words = new string[] { "TAE","TEA","EMS","ERA","TAR","TAM", "ATE"  ,"EAT","ARE", "EAR","ARM","ART", "TAS", "ERS","ARS","MAR","RET","RAM",
            "RES","REM", "MAS","MAT", "MET","RAT","RAS","SAE","SAT", "SET", "EMA","SEA","MAE"
           };

        public static void Ruth(int n)
        {
            
            for (int i = 0; i <= n; i++)
            {
                switch (i)
                {

                    case 0:

                        Console.WriteLine("\t");
                        Console.WriteLine("--------WelCome To Puzzle Game----------------");
                        Console.WriteLine("\t");
                        break;
                    case 1:

                        Console.WriteLine("1.Read all The Instruction");
                        break;
                    case 2:

                        Console.WriteLine("2.Please enter the words in uppercase");
                        break;
                    case 3:

                        Console.WriteLine("3.Every correct word will add 1 point to your score");
                        break;
                    case 4:

                        Console.WriteLine("4.Enter The Words From MASTER");
                        break;
                    case 5:

                        Console.WriteLine("5.In Order to Restart The Game Press Contintue.");
                        Console.Write("___________________________________________________________");
                        break;
                    case 6:

                        Console.WriteLine("6.Exit the game by press the Esc");
                        break;
                    default:
                        Console.WriteLine("Thank you For playing");
                        break;
                }
            }
        }


        public void play()
        {
            Console.WriteLine("\t");
            Console.WriteLine("Enter The Combination Of Three Words Using MASTER :");
            Console.Write("ENTER THE WORDS :");
            input = Console.ReadLine();
            Console.WriteLine();
            int pos = Array.IndexOf(Words, input);
            if (pos > -1)
            {

                Console.WriteLine("Whoo ! You Guess Right");
                Score++;
                play();

            }
            else
            {
                
                Console.WriteLine("Your SCORE." + Score + " Try again!");
                Console.WriteLine("Press enter to continue...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                play();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
  
            Game.Ruth(5);
            Game g = new Game();
            Console.WriteLine("\t");
            g.play();
            Console.ReadKey();
        }
    }
}
