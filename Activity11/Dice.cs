using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity11
{
    class Dice
    {
        private int sides; // A private field that contains the number of sides on the dice
        private Random randomGenerator; // A private field that contains a Random object

        // This is a constructor for the Dice object. It takes in one integer parameter, representing the number of sides. The number of sides will always be between 4 and 20. If a number greater than 20 is used, the sides field is set to 20 and if a number less than 4 is used it is set to 4
        public Dice(int sides)
        {
            this.randomGenerator = new Random(); // The Random object is initialized

            if(sides >= 4 && sides <= 20) // If the sides paramameter is between 4 and 20, the sides field is set to the value of the sides parameter
            {
                this.sides = sides;
                
            }
            else if(sides > 20) // If the sides parameter is greater than 20, the sides field is set to 20
            {
                this.sides = 20;
            }
            else if (sides < 4) // If the sides parameter is less than 4, the sides field is set to 4
            {
                this.sides = 4;
            }

            
        }

        // This method simulates rolling the dice, returning an integer between 1 and the number of sides
        public int RollDie()
        {
            return this.randomGenerator.Next(1, this.sides + 1); // Return a random integer between 1 and the number of sides
        }
    }
}
