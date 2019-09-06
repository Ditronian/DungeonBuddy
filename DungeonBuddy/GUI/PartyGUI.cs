using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonBuddy.Entities;
using DungeonBuddy.Main;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {
        //Color codes Combat View so players are harder to skip
        private void partyListView_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            Entity entity = (Entity)e.Model;
            if (entity.GetType() == typeof(Player) && !((Player)entity).IsNpc) e.Item.BackColor = Color.LightBlue;
            else if (entity.GetType() == typeof(Player) && ((Player)entity).IsNpc) e.Item.BackColor = Color.LightGreen;
        }

        private void addPartyButton_Click(object sender, EventArgs e)
        {
            String name = partyNameTextBox.Text;
            String race = partyRaceTextBox.Text;

            //Try and parse textbox to int, notify if not valid.
            if (!Int32.TryParse(partyPerceptionTextBox.Text, out int perception))
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //Try and parse textbox to int, notify if not valid.
            if (!Char.TryParse(partySizeTextBox.Text, out char size))
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            Player player = new Player(name, race, perception, size);

            //Try and parse textbox to int, notify if not valid.
            if (Int32.TryParse(partyHPTextBox.Text, out int hp))
            {
                player.CurrentHP = hp;
                player.MaxHP = hp;
            }

            //Try and parse textbox to int, notify if not valid.
            if (Int32.TryParse(partyACTextBox.Text, out int ac))
            {
                player.ArmorClass = ac;
            }

            //Add monster to dictionary, and add to combat list
            if (partyIsNpcCheckbox.Checked == true) player.IsNpc = true;
            DungeonBuddy.Main.Main.Party.PartyMembers.Add(player);
            partyListView.AddObject(player);
            combatListView.AddObject(player);
            Main.Save.save();
        }

        //Removes the selected creature from the party
        private void removePartyButton_Click(object sender, EventArgs e)
        {
            foreach(Player player in (partyListView.SelectedObjects))
            {
                DungeonBuddy.Main.Main.Party.PartyMembers.Remove(player);
            }
            partyListView.RemoveObjects(partyListView.SelectedObjects);
            
            Main.Save.save();
        }
    }
}
