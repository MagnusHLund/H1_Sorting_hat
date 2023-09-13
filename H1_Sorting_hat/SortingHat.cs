using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace H1_Sorting_hat
{
    internal class SortingHat
    {
        // Enum that contains each house
        public enum houses { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }

        /// <summary>
        /// Method that gets called by the Main method, in class program.
        /// This returns the enum values name, to he Main method
        /// </summary>
        /// <returns></returns>
        public string House()
        {
            // Creates a random and gives a value between 0 and 3
            Random rnd = new Random();
            int value = rnd.Next(4);

            // Gets the name of the enum, based on the random value.
            // Returns to Main()
            return Enum.GetName(typeof(houses), value);
        }
    }
}
