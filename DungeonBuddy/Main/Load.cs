using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DungeonBuddy.Entities;
using DungeonBuddy.GUI;
using DungeonBuddy.Items;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DungeonBuddy.Main
{
    class Load
    {
        private static string playerPath = "Bins/Players.bin";
        private static string npcPath = "Bins/NPCs.bin";
        private static string magicItemPath = "Bins/MagicItems.bin";
        private static string notesPath = "Notes/DMNotes.txt";
        private static string survivalNotesPath = "Notes/SurvivalNotes.txt";

        //Loads all program data
        public static void load()
        {
            loadEntities();
            loadNotes();
        }

        //Loads all entities
        private static void loadEntities()
        {
            if (System.IO.File.Exists(playerPath))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(playerPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                DungeonBuddy.Main.Main.Party = (Party)formatter.Deserialize(stream);
                stream.Close();
            }

            //Reset initiatives just in case user forgets to add new ones in new combats.
            foreach (Entity player in DungeonBuddy.Main.Main.Party.PartyMembers) player.Initiative = 0;

            if (System.IO.File.Exists(npcPath))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(npcPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                Main.Npcs = (List<NPC>)formatter.Deserialize(stream);
                stream.Close();
            }

            if (System.IO.File.Exists(magicItemPath))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(magicItemPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                DungeonBuddy.Main.Main.MagicItems = (List<MagicItem>)formatter.Deserialize(stream);
                stream.Close();
            }

            Main.Form.load();
        }

        //Loads DM Notes from Text File
        private static void loadNotes()
        {
            if (System.IO.File.Exists(notesPath))
            {
                string inputText = System.IO.File.ReadAllText(@notesPath);
                Main.Form.notesTextBox.Text = inputText;
            }

            if (System.IO.File.Exists(survivalNotesPath))
            {
                string inputText = System.IO.File.ReadAllText(@survivalNotesPath);
                Main.Form.survivalNotesTextBox.Text = inputText;
            }
        }

        //Loads the monsters from the provided filepath
        public static void loadEncounter(String encounterPath)
        {
            if (System.IO.File.Exists(encounterPath))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(encounterPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                DungeonBuddy.Main.Main.Monsters = (Dictionary<String,Monster>)formatter.Deserialize(stream);
                stream.Close();
            }
        }

    }
}
