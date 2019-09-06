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
using DungeonBuddy.Tables;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {
        //Handles the generating of treasure
        private void rollTreasureButton_Click(object sender, EventArgs e)
        {
            String CRs = treasureTextBox.Text;
            String[] crSplit = CRs.Split(',');

            bool error = false;
            int copper = 0;
            int silver = 0;
            int gold = 0;
            int platinum = 0;

            //Foreach CR in the input
            foreach(String s in crSplit)
            {
                int cr;
                if (Int32.TryParse(s, out int newCR))   //If input can be parsed to an int
                {
                    cr = newCR;
                    int[] treasure = TreasureTable.getLoot(cr); //Retrieve the array of individual loot
                    copper += treasure[0];
                    silver += treasure[1];
                    gold += treasure[2];
                    platinum += treasure[3];
                }
                else error = true;
            }
            if(!error) treasureLabel.Text = $"{copper} Copper Pieces, {silver} Silver Pieces, {gold} Gold Pieces, and {platinum} Platinum Pieces";
            else
            {
                notificationBar.Text = "Invalid CR Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }
        }
    }
}