using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonBuddy.Entities;
using DungeonBuddy.Main;
using DungeonBuddy.Biome;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {
        //Rolls Dice
        private void diceRollButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(numberDiceTextBox.Text, out int numberOfDice))
            {
                notificationBar.Text = "Invalid Dice Number provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(diceSizeTextBox.Text, out int sizeOfDice))
            {
                notificationBar.Text = "Invalid Dice Size provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(modifierTextBox.Text, out int diceModifier))
            {
                notificationBar.Text = "Invalid Modifier provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            int dieResult = 0;
            for(int die = 0; die<numberOfDice; die++)
            {
                dieResult += random.Next(1, sizeOfDice+1);
            }

            int finalResult = dieResult + diceModifier;
            diceResultLabel.Text = $"{finalResult} ({dieResult} + {diceModifier})";
        }

    }
}