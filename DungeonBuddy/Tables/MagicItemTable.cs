using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.Items;

namespace DungeonBuddy.Tables
{
    class MagicItemTable
    {

        private static MagicItem[] magicItemTableA = new MagicItem[100];
        private static MagicItem[] magicItemTableB = new MagicItem[100];
        private static MagicItem[] magicItemTableC = new MagicItem[100];
        private static MagicItem[] magicItemTableD = new MagicItem[100];
        private static MagicItem[] magicItemTableE = new MagicItem[100];
        private static MagicItem[] magicItemTableF = new MagicItem[100];
        private static MagicItem[] magicItemTableG = new MagicItem[100];
        private static MagicItem[] magicItemTableH = new MagicItem[100];
        private static MagicItem[] magicItemTableI = new MagicItem[100];

        //Fills in all the Magic Item Tables from text files
        public static void initializeMagicItemTables()
        {
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableA.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableA);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableB.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableB);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableC.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableC);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableD.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableD);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableE.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableE);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableF.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableF);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableG.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableG);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableH.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableH);
            foreach (String line in File.ReadLines("MagicItems/MagicItemTableI.txt", Encoding.UTF8)) disectAndAddItem(line, magicItemTableI);
        }

        //Recieves a line of input and its corresponding item table, and inserts the item into the applicable indexes in that ItemTable's array
        private static void disectAndAddItem(string line, MagicItem[] magicItemTable)
        {
            //Get Item
            String[] lineArray = line.Split('\t');
            String diceRolls = lineArray[0];
            String name = lineArray[1];
            String rarity = lineArray[2];
            String value = lineArray[3];

            //Get dice rolls of this item
            int startPos;
            int endPos;
            if (diceRolls.Length == 2)
            {
                startPos = Int32.Parse(Char.ToString(diceRolls[0]) + Char.ToString(diceRolls[1]));
                endPos = startPos;
            }
            else if (diceRolls.Length == 3)
            {
                startPos = Int32.Parse(Char.ToString(diceRolls[0]) + Char.ToString(diceRolls[1]) + Char.ToString(diceRolls[2]));
                endPos = startPos;
            }
            else
            {
                startPos = Int32.Parse(Char.ToString(diceRolls[0]) + Char.ToString(diceRolls[1]));
                endPos = Int32.Parse(Char.ToString(diceRolls[3]) + Char.ToString(diceRolls[4]));
            }

            //Add the item to the applicable indexes of the table
            for(int i = startPos-1;i<endPos;i++)
            {
                magicItemTable[i] = new MagicItem(name, rarity, value);
            }
        }

        //Randomly gets a magic item from the appropriate Item Table, and assigns spells to any scrolls
        public static MagicItem getItem(String letter)
        {
            MagicItem item;

            if (letter == "A") item = magicItemTableA.ElementAt(Program.random.Next(magicItemTableA.Length));
            else if (letter == "B") item = magicItemTableB.ElementAt(Program.random.Next(magicItemTableB.Length));
            else if (letter == "C") item = magicItemTableC.ElementAt(Program.random.Next(magicItemTableC.Length));
            else if (letter == "D") item = magicItemTableD.ElementAt(Program.random.Next(magicItemTableD.Length));
            else if (letter == "E") item = magicItemTableE.ElementAt(Program.random.Next(magicItemTableE.Length));
            else if (letter == "F") item = magicItemTableF.ElementAt(Program.random.Next(magicItemTableF.Length));
            else if (letter == "G") item = magicItemTableG.ElementAt(Program.random.Next(magicItemTableG.Length));
            else if (letter == "H") item = magicItemTableH.ElementAt(Program.random.Next(magicItemTableH.Length));
            else if (letter == "I") item = magicItemTableI.ElementAt(Program.random.Next(magicItemTableI.Length));
            else item = new MagicItem("ERROR", "ERROR", "0");

            //Make a copy of the item so any changes dont mess with the table
            MagicItem itemCopy = new MagicItem(item.Name, item.Rarity, item.Value);

            //If grabbed item is a scroll, determine its level then acquire a random spell of that level and append the spell name to the item
            if (itemCopy.Name.Contains("scroll"))
            {
                int level = 0;

                //Check for #, which will be the spell lvl
                foreach (Char c in itemCopy.Name) if (Int32.TryParse(Char.ToString(c), out int spellLvl)) level = spellLvl;

                //Grab a random spell of the appropriate level and add to name
                itemCopy.Name +=$" of {SpellTable.getRandomSpell(level)}";
            }

            return itemCopy;
        }

        
        
    }
}
