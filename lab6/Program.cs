using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int sides = 0;
                int dice = 0;
                Random ran = new Random();

                Console.WriteLine("Welcome to the Dice Rolling Thing:");
                Console.WriteLine("\nHow many sides does the dice have?");

                while (!SidesInRange(Console.ReadLine()))
                {
                    Console.WriteLine("\nEnter a whole number greater than 1.");
                }


                Console.WriteLine("\nHow many die are we throwing today?");

                while (!DiceInRange(Console.ReadLine()))
                {
                    Console.WriteLine("\nEnter a whole number greater than 0.");
                }

                while (true)
                {
                    Console.WriteLine("Alright lets do this, press any key to roll");
                    Console.ReadKey();
                    Roll(sides, dice, ran);
                    Console.WriteLine("Press R to roll again or any key to continue");
                    string uReroll = Console.ReadLine().ToUpper();
                    if (uReroll == "R")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Press R to restart the program or any key to quit");
                string uRestart = Console.ReadLine().ToUpper();
                if (uRestart == "R")
                {
                    continue;
                }
                else
                {
                    break;
                }

                //these check if the inputs are valid
                bool SidesInRange(string num)
                {
                    if (Int32.TryParse(num, out sides))
                    {
                        if (sides <= 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                bool DiceInRange(string num)
                {
                    if (Int32.TryParse(num, out dice))
                    {
                        if (dice <= 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static int GetRandom(int max, Random ran)
        { 
            int ranNum = ran.Next(1, (max + 1));
            return ranNum;
        }

        public static void Roll(int sides, int dice, Random ran)
        {
            for(int i = 0; i < dice; i++)
            {
                Console.WriteLine(GetRandom(sides, ran));
            }
        }

    }
}
