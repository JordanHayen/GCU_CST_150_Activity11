using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This code runs when the RollDice button is clicked
        private void RollDice_Click(object sender, EventArgs e)
        {

            Dice dice1; // A Dice object called dice1 is created
            Dice dice2; // A Dice object called dice2 is created
            int currentRoll1; // An integer variable called currentRoll1 is created. This will contain the last value rolled on dice1
            int currentRoll2; // An integer variable called currentRoll2 is created. This will contain the last value rolled on dice2
            int totalRolls = 1; // An integer variable called totalRolls is created. This will contain the number of rolls. It is set to 1 by default as at least 1 roll will be necessary

            try
            {
                dice1 = new Dice(int.Parse(Dice1Sides.Text)); // Initializes the dice1 object, parsing the data in the Dice1Sides textbox into an integer and using the result as the parameter for the constructor
                dice2 = new Dice(int.Parse(Dice2Sides.Text)); // Initializes the dice2 object, parsing the data in the Dice2Sides textbox into an integer and using the result as the parameter for the constructor
                currentRoll1 = dice1.RollDie(); // Calls the dice1 object's RollDie method, setting currentRoll1 to the result
                currentRoll2 = dice2.RollDie(); // Calls the dice2 object's RollDie method, setting currentRoll2 to the result

                while (currentRoll1 != 1 && currentRoll2 != 1) // This code runs until the currentRoll1 and currentRoll2 variables are both equal to 1. Made with help from the textbook (Gaddis, 317).
                {
                    currentRoll1 = dice1.RollDie(); // Calls the dice1 object's RollDie method, setting currentRoll1 to the result
                    currentRoll2 = dice2.RollDie(); // Calls the dice2 object's RollDie method, setting currentRoll2 to the result
                    totalRolls++; // Increases the totalRolls variable by 1
                }

                MessageBox.Show("It took " + totalRolls + " rolls to roll 1 on both dice."); // Displays a message box that contains the totalRolls variable
            } 
            catch(Exception ex) // If the data entered in the textboxes cannot be parsed into integer variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.
