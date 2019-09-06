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
        private Party party;

        public Form1()
        {
            InitializeComponent();
            rationLevelComboBox.SelectedIndex = 0;
            DungeonBuddy.Main.Main.begin(this);
        }

        //Initial load state
        public void load()
        {
            partyListView.AddObjects(DungeonBuddy.Main.Main.Party.PartyMembers);
            npcListView.AddObjects(DungeonBuddy.Main.Main.Npcs);
            combatListView.AddObjects(DungeonBuddy.Main.Main.Party.PartyMembers);

            magicItemShopListView.AddObjects(DungeonBuddy.Main.Main.MagicItems);
            party = Main.Main.Party;
            if (party.CurrentBiome.GetType() == typeof(ArcticBiome)) arcticRadioButton.Checked = true;
            else if (party.CurrentBiome.GetType() == typeof(PlainsBiome)) plainsRadioButton.Checked = true;
        }

        //On program exiting, save all program data.
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Save.save();
        }

    }
}