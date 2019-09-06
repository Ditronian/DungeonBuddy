using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DungeonBuddy.Entities;

namespace DungeonBuddy.Main
{
    class Save
    {
        private static string playerPath = "Bins/Players.bin";
        private static string npcPath = "Bins/NPCs.bin";
        private static string magicItemPath = "Bins/MagicItems.bin";
        private static string notesPath = "Notes/DMNotes.txt";
        private static string survivalNotesPath = "Notes/SurvivalNotes.txt";

        //Saves all program data
        public static void save()
        {
            if (Main.Form.npcListView.SelectedObject != null) ((NPC)Main.Form.npcListView.SelectedObject).Bio = Main.Form.npcBiographyRichTextBox.Text;  //save as npc's bio
            saveEntities();
            saveNotes();
        }

        //Saves all NPCs and Players to bin files when called.
        private static void saveEntities()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream playerStream = new FileStream(playerPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Stream npcStream = new FileStream(npcPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Stream magicItemStream = new FileStream(magicItemPath, FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(playerStream, DungeonBuddy.Main.Main.Party);
            formatter.Serialize(npcStream, Main.Npcs);
            formatter.Serialize(magicItemStream, Main.MagicItems);

            playerStream.Close();
            npcStream.Close();
            magicItemStream.Close();
        }

        //Saves the current encounter (monsters) to the provided path
        public static void saveEncounter(String encounterPath)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream monsterStream = new FileStream(encounterPath, FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(monsterStream, Main.Monsters);

            monsterStream.Close();
        }

        //Saves DM Notes to text file
        private static void saveNotes()
        {
            
            System.IO.File.WriteAllText(@notesPath, Main.Form.notesTextBox.Text);
            System.IO.File.WriteAllText(@survivalNotesPath, Main.Form.survivalNotesTextBox.Text);

            
        }




    }
}
