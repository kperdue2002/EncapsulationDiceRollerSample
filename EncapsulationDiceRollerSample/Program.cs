using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = InitDice();
            PrintDieFaceValues(dice);

            //hold the first three dice
            dice[0].IsHeld = true;
            dice[1].IsHeld = true;
            dice[2].IsHeld = true;

            Console.WriteLine("\n\nholding first three.\n\n");
            RollAllDice(dice);
            PrintDieFaceValues(dice);

            Console.ReadKey();
        }

        private static void RollAllDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }

        private static void PrintDieFaceValues(Die[] dice)
        {
            //print out the values
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }
        }

        /// <summary>
        /// initializes all die in a given array
        /// assumes array has been given a length
        /// </summary>
        /// <returns></returns>
        private static Die[] InitDice()
        {
            //create five dice
            Die[] dice = new Die[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }

            return dice;
        }
    }
}
