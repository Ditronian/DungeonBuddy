using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DungeonBuddy.Entities;
using DungeonBuddy.Main;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {

        //Reads Delete key having been pressed, and does remove combat button's functionality
        private void combatListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) removeCombatButton_Click(sender, e);
        }


        //Color codes Combat View so players are harder to skip
        private void combatListView_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            Entity entity = (Entity)e.Model;
            if (entity.GetType() == typeof(Player) && !((Player)entity).IsNpc) e.Item.BackColor = Color.LightBlue;
            else if (entity.GetType() == typeof(Player) && ((Player)entity).IsNpc) e.Item.BackColor = Color.LightGreen;
            else if (entity.GetType() == typeof(Monster) && !((Monster)entity).IsNPC) e.Item.BackColor = Color.LightSalmon;
            else if (entity.GetType() == typeof(Monster) && ((Monster)entity).IsNPC) e.Item.BackColor = Color.LightGreen;
        }

        //Handles the adding of monsters/creatures to combat.  Shouldnt be used for players/permanent npcs, use partylist instead.
        private void addCombatButton_Click(object sender, EventArgs e)
        {
            String name = monsterNameTextBox.Text;
            String originalName = monsterNameTextBox.Text;

            //Adds suffix to distinguish multiple monsters with the same name
            int i = 2;
            while (Main.Main.Monsters.ContainsKey(name))
            {
                name = originalName + " (" + i + ")";
                i++;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(monsterInitiativeTextBox.Text, out int initiative))
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(monsterHPTextBox.Text, out int hp))
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(monsterACTextBox.Text, out int ac))
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Add monster to dictionary, and add to combat list
            Monster monster = new Monster(name, initiative, hp, ac);
            if (combatIsNPCCheckbox.Checked == true) monster.IsNPC = true;
            Main.Main.Monsters.Add(name, monster);
            combatListView.AddObject(monster);
        }

        //Removes the selected creature from the combat tracker
        private void removeCombatButton_Click(object sender, EventArgs e)
        {
            foreach (Entity entity in combatListView.SelectedObjects)
            {
                if(entity.GetType() == typeof(Monster)) Main.Main.Monsters.Remove(entity.Name);
            }
            combatListView.RemoveObjects(combatListView.SelectedObjects);
        }

        //Inflicts a provided amount of damage to the selected entity
        private void monsterDamageButton_Click(object sender, EventArgs e)
        {
            //Make sure value can be parsed
            if (Int32.TryParse(monsterDamageTextBox.Text, out int damage))
            {
                foreach (Entity entity in combatListView.SelectedObjects)
                {
                    entity.CurrentHP -= damage;
                    if (entity.CurrentHP < 0) entity.CurrentHP = 0;
                }
                combatListView.UpdateObjects(combatListView.SelectedObjects);
                monsterDamageTextBox.Text = "";
                combatListView.SelectedObject = null;
            }
            else
            {
                notificationBar.Text = "Invalid Damage Value provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }
        }

        private void loadCombatButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String encounterPath = openFileDialog1.FileName;
                DungeonBuddy.Main.Load.loadEncounter(encounterPath);
                combatListView.ClearObjects();
                combatListView.AddObjects(DungeonBuddy.Main.Main.Monsters.Values);
                combatListView.AddObjects(DungeonBuddy.Main.Main.Party.PartyMembers);

            }
        }

        //Saves the current encounter, aka monster list
        private void saveCombatButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Encounter    
            saveFileDialog1.Filter = "Bin File|*.bin";
            saveFileDialog1.Title = "Save Encounter File";
            saveFileDialog1.ShowDialog();
            String encounterPath = saveFileDialog1.FileName;
            // If the file name is not an empty string open it for saving.  
            if (encounterPath != "") DungeonBuddy.Main.Save.saveEncounter(encounterPath);
        }

        //Rolls the dice and provides result as part of notification bar.
        private void combatRollDiceButton_Click(object sender, EventArgs e)
        {
            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(combatNumberDiceTextBox.Text, out int numberOfDice))
            {
                notificationBar.Text = "Invalid Dice Number provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(combatDiceSizeTextBox.Text, out int sizeOfDice))
            {
                notificationBar.Text = "Invalid Dice Size provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(combatDiceModifierTextBox.Text, out int diceModifier))
            {
                notificationBar.Text = "Invalid Modifier provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            int dieResult = 0;
            for (int die = 0; die < numberOfDice; die++)
            {
                dieResult += DungeonBuddy.Program.random.Next(1, sizeOfDice + 1);
            }

            int finalResult = dieResult + diceModifier;
            notificationBar.Text = $"Die Result: {finalResult} ({dieResult} + {diceModifier})";
        }
    }
}
