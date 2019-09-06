using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonBuddy.Entities;
using DungeonBuddy.Main;
using DungeonBuddy.Tables;
using DungeonBuddy.Biome;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {
        private double mouthsToFeed = 0.0;

        //Updates all Food/Survival Information
        public void updateInformation()
        {
            mouthsToFeed = 0.0;
            foreach(Player player in party.PartyMembers)
            {
                if (player.Size == 'M') mouthsToFeed+=1.0;
                else if(player.Size == 'S') mouthsToFeed += 0.5;
            }
            if (rationLevelComboBox.SelectedIndex == 0) party.RationsMultiplier = 1;
            else party.RationsMultiplier = 2;

            if(party.CurrentBiome.Weather.Duration == 1) weatherLabel.Text = party.CurrentBiome.Weather.Type;
            else weatherLabel.Text = party.CurrentBiome.Weather.Type + $" ({party.CurrentBiome.Weather.Duration})";
            weatherEffectLabel.Text = party.CurrentBiome.Weather.Effect;

            int miles = party.PlayerMovement;
            double hexes = Math.Round((party.PlayerMovement / 12.0), 2);
            double leftoverHexes = Math.Round((party.LeftoverMovement / 12.0), 2);
            int totalHexes = (party.PlayerMovement + party.LeftoverMovement) / 12;

            movementLabel.Text = ($"{miles} miles / {hexes} hexes +  {leftoverHexes} leftover =  {totalHexes} hexes traveled.");
            foodForagedLabel.Text = $"{party.FoodForaged} Lbs / {Math.Round(((party.FoodForaged * (double)party.RationsMultiplier) / ((double)mouthsToFeed)), 2)} Day(s)";

            foodRemainingLabel.Text = $"{party.FoodRemainingPounds} Lbs / {Math.Round(((party.FoodRemainingPounds* (double)party.RationsMultiplier) / ((double) mouthsToFeed) ),2)} Day(s)";

            int daysWithoutFood = party.DaysWithoutFood;
            if(daysWithoutFood > 0) daysWithoutFoodLabel.ForeColor = System.Drawing.Color.Red;
            else daysWithoutFoodLabel.ForeColor = System.Drawing.Color.Black;
            daysWithoutFoodLabel.Text = $"{party.DaysWithoutFood} Day(s)";
        }

        private void miscTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateInformation();
        }

        private void pursuitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateInformation();
        }

        private void rationLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rationLevelComboBox.SelectedIndex == 1) party.RationsMultiplier = 1; //Full Rations
            else party.RationsMultiplier = 2;   //Half Rations

            updateInformation();
        }

        private void incerementMovementButton_Click(object sender, EventArgs e)
        {
            party.PlayerMovement+=8/party.CurrentBiome.MovementPenalty;
            updateInformation();
        }

        private void decerementMovementButton_Click(object sender, EventArgs e)
        {
            if (party.PlayerMovement != 0) party.PlayerMovement-= 8 / party.CurrentBiome.MovementPenalty;
            updateInformation();
        }

        private void incerementFoodButton_Click(object sender, EventArgs e)
        {
            party.FoodForaged++;
            updateInformation();
        }

        private void decerementFoodButton_Click(object sender, EventArgs e)
        {
            if(party.FoodForaged != 0) party.FoodForaged--;
            updateInformation();
        }


        private void plainsRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            updateInformation();
        }

        private void arcticRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (!arcticRadioButton.Checked) return; //Not the button being checked
            //party.CurrentBiome = new Biome.ArcticBiome();
            updateInformation();
        }

        private void endDayButton_Click(object sender, EventArgs e)
        {
            //switch party biomes if neccessary
            if (arcticRadioButton.Checked && party.CurrentBiome.GetType() != typeof(ArcticBiome)) party.CurrentBiome = new ArcticBiome();
            else if (plainsRadioButton.Checked && party.CurrentBiome.GetType() != typeof(PlainsBiome)) party.CurrentBiome = new PlainsBiome();

            if (party.CurrentBiome.Weather.Duration == 1) party.CurrentBiome.generateWeather();
            else party.CurrentBiome.Weather.Duration--;

            party.FoodRemainingPounds += party.FoodForaged;
            party.FoodForaged = 0;
            party.FoodRemainingPounds -= mouthsToFeed/ party.RationsMultiplier;

            //If party did not receive enough food for the day, begin starvation.
            if (party.FoodRemainingPounds < 0)
            {
                party.FoodRemainingPounds = 0;
                party.DaysWithoutFood++;
            }
            else if (party.FoodRemainingPounds >= 0 && party.DaysWithoutFood > 0) party.DaysWithoutFood = 0;    //Party is no longer starving.

            party.LeftoverMovement = (party.LeftoverMovement + party.PlayerMovement) % 12;
            party.PlayerMovement = 0;
            updateInformation();
        }

        //Sets the party's food to the entered amount
        private void setFoodButton_Click(object sender, EventArgs e)
        {
            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(setFoodTextBox.Text, out int food))
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            party.FoodRemainingPounds = food;
            setFoodTextBox.Text = "";
            updateInformation();
        }

        internal Party Party { get => party; set => party = value; }
    }
}
