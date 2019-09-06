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
        private NPC oldSelected;

        private void npcListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (npcListView.SelectedObject != null)
            {
                if (oldSelected != null) oldSelected.Bio = npcBiographyRichTextBox.Text;  //save as npc's bio

                //Set new npc
                npcBiographyRichTextBox.Text = ((NPC)npcListView.SelectedObject).Bio; //Set bio box to new npc's bio
                npcNameLabel.Text = ((NPC)npcListView.SelectedObject).Name;
                npcSexLabel.Text = ((NPC)npcListView.SelectedObject).Sex;
                npcRaceLabel.Text = ((NPC)npcListView.SelectedObject).Race;
                npcLocationLabel.Text = ((NPC)npcListView.SelectedObject).Location;

                //Check if npc has traits
                if (((NPC)npcListView.SelectedObject).Appearance != null)
                {
                    npcAppearanceLabel.Text = ((NPC)npcListView.SelectedObject).Appearance;
                    npcMannerismLabel.Text = ((NPC)npcListView.SelectedObject).Mannerism;
                    npcInteractionLabel.Text = ((NPC)npcListView.SelectedObject).InteractionStyle;
                    npcFlawLabel.Text = ((NPC)npcListView.SelectedObject).Flaw_secret;
                    npcTalentLabel.Text = ((NPC)npcListView.SelectedObject).Talent;
                }
                else
                {
                    npcAppearanceLabel.Text = "";
                    npcMannerismLabel.Text = "";
                    npcInteractionLabel.Text = "";
                    npcFlawLabel.Text = "";
                    npcTalentLabel.Text = "";
                }

                oldSelected = ((NPC)npcListView.SelectedObject);
                Main.Save.save();
            }

        }



        //Adds new npc to list/listview.  Can write bio by selecting new npc
        private void addNPCButton_Click(object sender, EventArgs e)
        {
            String name = npcNameTextBox.Text;
            String race = npcRaceTextBox.Text;
            String sex = npcSexTextBox.Text;
            String location = npcLocationTextBox.Text;

            //Try and parse textbox to int, notify if not valid.
            if (name == "" || race == "" || sex == "" || location == "")
            {
                notificationBar.Text = "Invalid Input provided!";
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            NPC npc = new NPC(name, sex, race, location);

            //Add npc to npc list, and add to npc list view

            DungeonBuddy.Main.Main.Npcs.Add(npc);
            npcListView.AddObject(npc);
            if (npcListView.SelectedObject != null) ((NPC)npcListView.SelectedObject).Bio = npcBiographyRichTextBox.Text;  //save existing bio so can be cleared
            npcListView.SelectedObject = npc;   //Set selected object to new npc to protect old npc's bio
            Main.Save.save();

            //Blank fields
            npcNameTextBox.Text = "";
            npcRaceTextBox.Text = "";
            npcSexTextBox.Text = "";
            npcLocationTextBox.Text = "";
        }

        //Remove selected npcs from the listview/list
        private void removeNPCButton_Click(object sender, EventArgs e)
        {
            foreach (NPC npc in (npcListView.SelectedObjects))
            {
                DungeonBuddy.Main.Main.Npcs.Remove(npc);
            }
            npcListView.RemoveObjects(npcListView.SelectedObjects);

            Main.Save.save();
        }

    }
}
