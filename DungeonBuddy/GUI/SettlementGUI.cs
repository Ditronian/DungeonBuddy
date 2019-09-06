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
        //Constructs a settlement object then save its
        private void saveSettlementButton_Click(object sender, EventArgs e)
        {
            string name = settlementNameTextBox.Text;
            string type = settlementTypeComboBox.Text;
            string owningCountry = settlementCountryTextBox.Text;
            string dominantRace = settlementRaceTextBox.Text;
            string raceRelations = settlementRaceRelationsTextBox.Text;
            string rulerStatus = settlementRulerStatusTextBox.Text;
            string notableTrait = settlementNotableTraitTextBox.Text;
            string knownFor = settlementKnownForTextBox.Text;
            string currentCalamity = settlementCurrentCalamityTextBox.Text;
            string description = settlementDescriptionRichTextBox.Text;

            string settlement = $"Name: {name}\n" +
                $"Type: {type}\n" +
                $"Owning Country: {owningCountry}\n" +
                $"Dominant Race: {dominantRace}\n" +
                $"\n" +
                $"Traits\n" +
                $"Race Relations: {raceRelations}\n" +
                $"Ruler Status: {rulerStatus}\n" +
                $"Notable Trait: {notableTrait}\n" +
                $"Known For: {knownFor}\n" +
                $"Current Calamity: {currentCalamity}\n" +
                $"\n" +
                $"Description:\n" +
                $"{description}";

            System.IO.File.WriteAllText($"Settlements/{name}.txt", settlement);
            notificationBar.Text = $"Settlement Saved as {name}.txt";
            System.Media.SystemSounds.Beep.Play();
            
        }

        private void rollSettlementButton_Click(object sender, EventArgs e)
        {
            rollSettlementNameButton_Click(sender, e);
            rollSettlementTraitsButton_Click(sender, e);

            notificationBar.Text = $"Settlement Name Generation not yet functional!";
            System.Media.SystemSounds.Beep.Play();
        }

        private void rollSettlementNameButton_Click(object sender, EventArgs e)
        {
            notificationBar.Text = $"Settlement Name Generation not yet functional!";
            System.Media.SystemSounds.Beep.Play();
        }

        private void rollSettlementTraitsButton_Click(object sender, EventArgs e)
        {
            rollSettlementCalamityButton_Click(sender, e);
            rollSettlementNotableTraitButton_Click(sender, e);
            rollSettlementRelationsButton_Click(sender, e);
            rollSettlementRulerStatusButton_Click(sender, e);
            rollSettlementKnownForButton_Click(sender, e);
        }

        private void rollSettlementRelationsButton_Click(object sender, EventArgs e)
        {
            settlementRaceRelationsTextBox.Text = SettlementTable.getRaceRelations();
        }

        private void rollSettlementRulerStatusButton_Click(object sender, EventArgs e)
        {
            settlementRulerStatusTextBox.Text = SettlementTable.getRulerStatus();
        }

        private void rollSettlementNotableTraitButton_Click(object sender, EventArgs e)
        {
            settlementNotableTraitTextBox.Text = SettlementTable.getNotableTrait();
        }

        private void rollSettlementCalamityButton_Click(object sender, EventArgs e)
        {
            settlementCurrentCalamityTextBox.Text = SettlementTable.getCurrentCalamity();
        }

        private void rollSettlementKnownForButton_Click(object sender, EventArgs e)
        {
            settlementKnownForTextBox.Text = SettlementTable.getKnownFor();
        }

    }
}