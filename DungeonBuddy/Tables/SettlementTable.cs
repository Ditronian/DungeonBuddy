using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Tables
{
    class SettlementTable
    {
        
        private static String[] raceRelations = {"Harmony", "Harmony", "Harmony", "Harmony", "Harmony", "Harmony", "Harmony", "Harmony", "Harmony", "Harmony", "Tension/Rivalry", "Tension/Rivalry",
            "Tension/Rivalry", "Tension/Rivalry", "Racial Majority are conquerors", "Racial Majority are conquerors", "Racial Minority are rulers", "Racial Minority are refugees",
            "Racial Majority oppresses minority", "Racial Minority oppresses majority"};


        private static String[] rulerStatus = {"Respected/Just", "Respected/Just", "Respected/Just", "Respected/Just", "Respected/Just", "Feared Tyrant", "Feared Tyrant", "Feared Tyrant",
            "Weakling Manipulated by others", "Illegitimate ruler/simmering civil war", "Ruler or controlled by a powerful monster","Mysterious/Anonymous cabal","Contested Leadership/Open-Fighting",
            "Cabal seized power openly","Doltish lout","On deathbed/claimants compete for power","Iron-willed but respected","Iron-willed but respected","Religious Leader","Religious Leader"};


        private static String[] notableTrait = {"Canals instead of streets", "Massive statue or monument", "Grand Temple", "Large Fortress", "Verdant Parks/Orchards", "River Divides Town",
            "Major Trade Center", "Headquarters of powerfuly family/guild","Population mostly wealthy","Destitute/Rundown","Awful Smell (sewers)","Center of Trade for one good","Site of many battles",
            "Site of mythic/magical event","Important library or archive","Worship of all gods banned","Sinister reputation","Notable Library or Academy","Site of important tomb/graveyard",
            "Built atop ancient ruins" };

        private static String[] knownFor = { "Delicious cuisine", "Rude people", "Greedy merchants", "Artists and writers", "Great Hero/savior", "Flowers", "Beggars", "Tough Warriors", "Dark magic",
            "Decadence", "Piety", "Gambling", "Godlessness", "Education", "Wines", "High Fashion", "Political intrigue", "Strong drink", "Patriotism", "Powerful guilds"};

        private static String[] currentCalamity = { "Suspected Vampires", "Cult seeks converts", "Important figure murdured", "War between thieves' guilds", "Plague/Famine", "Plague/Famine",
            "Corrupt Officials", "Marauding monsters", "Marauding monsters", "Powerful Wizard has moved into town", "Economic depression (trade disrupted)", "Flooding", "Undead stirring in cemetaries",
            "Prophecy of doom", "Brink of war", "Internal strife (pre-anarchy)", "Besieged by enemies", "Scandal threatens powerful families", "Dungeon discovered (Adventurers flock to town)",
            "Religious sects struggle for power" };

        public static String getRaceRelations()
        {
            return raceRelations[Program.random.Next(raceRelations.Length)];
        }

        public static String getRulerStatus()
        {
            return rulerStatus[Program.random.Next(rulerStatus.Length)];
        }

        public static String getNotableTrait()
        {
            return notableTrait[Program.random.Next(notableTrait.Length)];
        }

        public static String getKnownFor()
        {
            return knownFor[Program.random.Next(knownFor.Length)];
        }

        public static String getCurrentCalamity()
        {
            return currentCalamity[Program.random.Next(currentCalamity.Length)];
        }
    }
}
