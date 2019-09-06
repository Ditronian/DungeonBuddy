using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Tables
{
    class SpellTable
    {
        

        private static List<String> levelC = new List<String>();
        private static List<String> level1 = new List<String>();
        private static List<String> level2 = new List<String>();
        private static List<String> level3 = new List<String>();
        private static List<String> level4 = new List<String>();
        private static List<String> level5 = new List<String>();
        private static List<String> level6 = new List<String>();
        private static List<String> level7 = new List<String>();
        private static List<String> level8 = new List<String>();
        private static List<String> level9 = new List<String>();

        //Loads all the spells from text files to their appropriate list
        public static void initializeSpellTable()
        {
            foreach (String line in File.ReadLines("Spells/LevelC.txt", Encoding.UTF8)) levelC.Add(line);
            foreach (String line in File.ReadLines("Spells/Level1.txt", Encoding.UTF8)) level1.Add(line);
            foreach (String line in File.ReadLines("Spells/Level2.txt", Encoding.UTF8)) level2.Add(line);
            foreach (String line in File.ReadLines("Spells/Level3.txt", Encoding.UTF8)) level3.Add(line);
            foreach (String line in File.ReadLines("Spells/Level4.txt", Encoding.UTF8)) level4.Add(line);
            foreach (String line in File.ReadLines("Spells/Level5.txt", Encoding.UTF8)) level5.Add(line);
            foreach (String line in File.ReadLines("Spells/Level6.txt", Encoding.UTF8)) level6.Add(line);
            foreach (String line in File.ReadLines("Spells/Level7.txt", Encoding.UTF8)) level7.Add(line);
            foreach (String line in File.ReadLines("Spells/Level8.txt", Encoding.UTF8)) level8.Add(line);
            foreach (String line in File.ReadLines("Spells/Level9.txt", Encoding.UTF8)) level9.Add(line);
        }

        //Returns a random spell from the appropriate spell list
        public static String getRandomSpell(int level)
        {
            if (level == 0) return levelC.ElementAt(Program.random.Next(levelC.Count));
            else if (level == 1) return level1.ElementAt(Program.random.Next(level1.Count));
            else if (level == 2) return level2.ElementAt(Program.random.Next(level2.Count));
            else if (level == 3) return level3.ElementAt(Program.random.Next(level3.Count));
            else if (level == 4) return level4.ElementAt(Program.random.Next(level4.Count));
            else if (level == 5) return level5.ElementAt(Program.random.Next(level5.Count));
            else if (level == 6) return level6.ElementAt(Program.random.Next(level6.Count));
            else if (level == 7) return level7.ElementAt(Program.random.Next(level7.Count));
            else if (level == 8) return level8.ElementAt(Program.random.Next(level8.Count));
            else if (level == 9) return level9.ElementAt(Program.random.Next(level9.Count));
            else return "ERROR";
        }
    }
}
