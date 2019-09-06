using DungeonBuddy.Entities;
using DungeonBuddy.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.Tables;
using DungeonBuddy.Items;

namespace DungeonBuddy.Main
{
    class Main
    {
        private static Form1 dbForm;
        private static Party party;
        private static List<NPC> npcs;
        private static Dictionary<String, Monster> monsters;
        private static List<MagicItem> magicItems;
        private static String dmNotes;

        //MY Code begins execution here
        public static void begin(Form1 form)
        {
            dbForm = form;
            party = new Party();
            npcs = new List<NPC>();
            magicItems = new List<MagicItem>();
            monsters = new Dictionary<String, Monster>();

            //Load data from files
            Load.load();
            dbForm.updateInformation();
            SpellTable.initializeSpellTable();
            MagicItemTable.initializeMagicItemTables();
            TreasureTable.initializeTreasureTables();
        }

        


        public static Form1 Form { get => dbForm; set => dbForm = value; }
        public static string DmNotes { get => dmNotes; set => dmNotes = value; }
        public static Party Party { get => party; set => party = value; }
        public static List<NPC> Npcs { get => npcs; set => npcs = value; }
        public static List<MagicItem> MagicItems { get => magicItems; set => magicItems = value; }
        public static Dictionary<String, Monster> Monsters { get => monsters; set => monsters = value; }
    }
}
