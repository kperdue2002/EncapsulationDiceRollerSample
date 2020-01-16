using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    /// <summary>
    /// Represents a single six sided die
    /// </summary>
    class Die
    {
        //static members get shared across all instances of this class
        private static Random rand;

        /// <summary>
        /// runs once before any die objects are created and initializes Random object once
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll();
        }

        /// <summary>
        /// the current value of the die 1-6
        /// </summary>
        public byte FaceValue
        {
            get { return FaceValue; }
            private set
            {
                if(value < 1 || value > 6)
                {
                    throw new ArgumentException("invalid face value!");
                }
                FaceValue = value;
            }
        }

        /// <summary>
        /// die that are held are not rolled
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// generates a new random face value
        /// sets FaceValue to the new value
        /// returns generated value
        /// </summary>
        public byte Roll() {

            if (IsHeld)
            {
                return FaceValue;
            }

            const byte minVal = 1;
            const byte maxVal = 6;
            //offset is for the exclusive range of Random.Next()
            const byte offset = 1;
            byte newValue = (byte)rand.Next(minVal, maxVal + offset);
            FaceValue = newValue;
            return newValue;
        }
    }
}
