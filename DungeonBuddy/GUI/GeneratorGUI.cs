using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonBuddy.Entities;
using DungeonBuddy.Main;
using DungeonBuddy.Tables;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {
        private NameTable humanNames = new NameTable("human");
        private NameTable elvenNames = new NameTable("elven");
        private NameTable dwarvenNames = new NameTable("dwarven");
        private NameTable halflingNames = new NameTable("halfling");
        private NameTable gnomishNames = new NameTable("gnomish");
        private NameTable gnollNames = new NameTable("gnoll");
        private GeographyTable forestNames = new GeographyTable("forest");
        private GeographyTable mountainNames = new GeographyTable("mountain");
        private GeographyTable riverNames = new GeographyTable("river");
        private GeographyTable swampNames = new GeographyTable("swamp");
        private GeographyTable islandNames = new GeographyTable("island");

        //Grabs a random first name using the appropriate combo boxes
        private void rollFirstNameButton_Click(object sender, EventArgs e)
        {
            String name = null;
            if (raceComboBox.Text == "Human" && genderComboBox.Text == "Male") name = humanNames.getMaleFirstName();
            else if (raceComboBox.Text == "Human" && genderComboBox.Text == "Female") name = humanNames.getFemaleFirstName();
            else if (raceComboBox.Text == "Elven" && genderComboBox.Text == "Male") name = elvenNames.getMaleFirstName();
            else if (raceComboBox.Text == "Elven" && genderComboBox.Text == "Female") name = elvenNames.getFemaleFirstName();
            else if (raceComboBox.Text == "Dwarven" && genderComboBox.Text == "Male") name = dwarvenNames.getMaleFirstName();
            else if (raceComboBox.Text == "Dwarven" && genderComboBox.Text == "Female") name = dwarvenNames.getFemaleFirstName();
            else if (raceComboBox.Text == "Halfling" && genderComboBox.Text == "Male") name = halflingNames.getMaleFirstName();
            else if (raceComboBox.Text == "Halfling" && genderComboBox.Text == "Female") name = halflingNames.getFemaleFirstName();
            else if (raceComboBox.Text == "Gnomish" && genderComboBox.Text == "Male") name = gnomishNames.getMaleFirstName();
            else if (raceComboBox.Text == "Gnomish" && genderComboBox.Text == "Female") name = gnomishNames.getFemaleFirstName();
            else if (raceComboBox.Text == "Gnoll" && genderComboBox.Text == "Male") name = gnollNames.getMaleFirstName();
            else if (raceComboBox.Text == "Gnoll" && genderComboBox.Text == "Female") name = gnollNames.getFemaleFirstName();

            if (name != null) firstNameLabel.Text = name;
        }

        //Grabs a random last name using the appropriate combo boxes
        private void rollLastNameButton_Click(object sender, EventArgs e)
        {
            String name = null;
            if (raceComboBox.Text == "Human") name = humanNames.getLastName();
            else if (raceComboBox.Text == "Elven") name = elvenNames.getLastName();
            else if (raceComboBox.Text == "Dwarven") name = dwarvenNames.getLastName();
            else if (raceComboBox.Text == "Halfling") name = halflingNames.getLastName();
            else if (raceComboBox.Text == "Gnomish") name = gnomishNames.getLastName();
            else if (raceComboBox.Text == "Gnoll") name = gnollNames.getLastName();

            if (name != null) lastNameLabel.Text = name;
        }

        //Grabs a random full name using the appropriate combo boxes
        private void rollFullNameButton_Click(object sender, EventArgs e)
        {
            String[] name = null;
            if (raceComboBox.Text == "Human" && genderComboBox.Text == "Male") name = humanNames.getMaleFullName();
            else if (raceComboBox.Text == "Human" && genderComboBox.Text == "Female") name = humanNames.getFemaleFullName();
            else if (raceComboBox.Text == "Elven" && genderComboBox.Text == "Male") name = elvenNames.getMaleFullName();
            else if (raceComboBox.Text == "Elven" && genderComboBox.Text == "Female") name = elvenNames.getFemaleFullName();
            else if (raceComboBox.Text == "Dwarven" && genderComboBox.Text == "Male") name = dwarvenNames.getMaleFullName();
            else if (raceComboBox.Text == "Dwarven" && genderComboBox.Text == "Female") name = dwarvenNames.getFemaleFullName();
            else if (raceComboBox.Text == "Halfling" && genderComboBox.Text == "Male") name = halflingNames.getMaleFullName();
            else if (raceComboBox.Text == "Halfling" && genderComboBox.Text == "Female") name = halflingNames.getFemaleFullName();
            else if (raceComboBox.Text == "Gnomish" && genderComboBox.Text == "Male") name = gnomishNames.getMaleFullName();
            else if (raceComboBox.Text == "Gnomish" && genderComboBox.Text == "Female") name = gnomishNames.getFemaleFullName();
            else if (raceComboBox.Text == "Gnoll" && genderComboBox.Text == "Male") name = gnollNames.getMaleFullName();
            else if (raceComboBox.Text == "Gnoll" && genderComboBox.Text == "Female") name = gnollNames.getFemaleFullName();

            if (name != null)
            {
                firstNameLabel.Text = name[0];
                lastNameLabel.Text = name[1];
            }
        }

        //Grabs a random geography name using the appropriate combo boxes
        private void geographyButton_Click(object sender, EventArgs e)
        {
            String name = null;
            if (geographyComboBox.Text == "River") name = riverNames.getName();
            else if (geographyComboBox.Text == "Forest") name = forestNames.getName();
            else if (geographyComboBox.Text == "Mountain") name = mountainNames.getName();
            else if (geographyComboBox.Text == "Swamp") name = swampNames.getName();
            else if (geographyComboBox.Text == "Island") name = islandNames.getName();

            if (name != null) geographyNameLabel.Text = name;
        }

        //Generates a NPC from the random stuff
        private void saveNPCButton_Click(object sender, EventArgs e)
        {
            String bio = npcBioRichTextBox.Text;
            String name = firstNameLabel.Text + " " + lastNameLabel.Text;
            String location = generatorLocationTextBox.Text;
            String sex =  genderComboBox.Text.ElementAt(0).ToString();
            String race = raceComboBox.Text;

            String appearance = appearanceLabel.Text;
            String mannerism = mannerismLabel.Text;
            String interactionStyle = interactionLabel.Text;
            String flaw_secret = flawLabel.Text;
            String talent = talentLabel.Text;

            NPC npc = new NPC(name, sex, race, location,appearance, mannerism, interactionStyle, flaw_secret, talent, bio);

            DungeonBuddy.Main.Main.Npcs.Add(npc);
            npcListView.AddObject(npc);
            if (npcListView.SelectedObject != null) ((NPC)npcListView.SelectedObject).Bio = npcBiographyRichTextBox.Text;  //save existing bio so can be cleared
            npcListView.SelectedObject = npc;   //Set selected object to new npc to protect old npc's bio
            Main.Save.save();
        }

        //Generates the NPC's appearance trait
        private void appearanceButton_Click(object sender, EventArgs e)
        {
            appearanceLabel.Text = NPCTable.getAppearance();
        }

        //Generates the NPC's mannerism trait
        private void mannerismButton_Click(object sender, EventArgs e)
        {
            mannerismLabel.Text = NPCTable.getMannerism();
        }

        //Generates the NPC's interaction style trait
        private void interactionButton_Click(object sender, EventArgs e)
        {
            interactionLabel.Text = NPCTable.getInteractionStyle();
        }

        //Generates the NPC's appearance trait
        private void flawButton_Click(object sender, EventArgs e)
        {
            flawLabel.Text = NPCTable.getFlawSecret();
        }

        //Generates the NPC's talent trait
        private void talentButton_Click(object sender, EventArgs e)
        {
            talentLabel.Text = NPCTable.getTalent();
        }

        //Generates all NPC traits
        private void allTraitsButton_Click(object sender, EventArgs e)
        {
            appearanceButton_Click(sender, e);
            mannerismButton_Click(sender, e);
            interactionButton_Click(sender, e);
            flawButton_Click(sender, e);
            talentButton_Click(sender, e);
        }

        //100% generates a random npc
        private void createNPCButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            genderComboBox.SelectedIndex = random.Next(genderComboBox.Items.Count);
            raceComboBox.SelectedIndex = random.Next(raceComboBox.Items.Count);
            rollFullNameButton_Click(sender, e);
            allTraitsButton_Click(sender, e);
        }

    }
}
