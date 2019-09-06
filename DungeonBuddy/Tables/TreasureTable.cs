using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.Mechanics;

namespace DungeonBuddy.Tables
{
    class TreasureTable
    {
        
        //2d Arrays, rows are dice rolls, cols are loot type/amount
        private static String[,] table0 = new String[100,4];
        private static String[,] table5 = new String[100, 4];
        private static String[,] table11 = new String[100, 4];
        private static String[,] table17 = new String[100, 4];

        //Fills in all the Magic Item Tables from text files
        public static void initializeTreasureTables()
        {
            foreach (String line in File.ReadLines("Treasure/Table0.txt", Encoding.UTF8)) disectAndAddItem(line, table0);
            foreach (String line in File.ReadLines("Treasure/Table5.txt", Encoding.UTF8)) disectAndAddItem(line, table5);
            foreach (String line in File.ReadLines("Treasure/Table11.txt", Encoding.UTF8)) disectAndAddItem(line, table11);
            foreach (String line in File.ReadLines("Treasure/Table17.txt", Encoding.UTF8)) disectAndAddItem(line, table17);

            //Test
            //for(int r = 0;r< table17.GetLength(0); r++)
            //{

            //    for(int c = 0; c < table17.GetLength(1); c++)
            //    {
            //        Console.Write((String)table17.GetValue(r,c)+'\t');
            //    }
            //    Console.WriteLine();
            //}
        }

        //Recieves a line of input and its corresponding treasure table, and inserts the item into the applicable indexes in that TreasureTable's 2d array
        private static void disectAndAddItem(string line, String[,] treasureTable)
        {
            //Parse Line
            String[] lineArray = line.Split('\t');
            String diceRolls = lineArray[0];
            String copper = lineArray[1];
            String silver = lineArray[2];
            String gold = lineArray[3];
            String platinum = lineArray[4];

            //Get dice rolls of this item
            int startPos;
            int endPos;
            if (diceRolls.Length == 5)
            {
                startPos = Int32.Parse(Char.ToString(diceRolls[0]) + Char.ToString(diceRolls[1])) - 1;
                endPos = Int32.Parse(Char.ToString(diceRolls[3]) + Char.ToString(diceRolls[4])) - 1;
            }
            //Length is 6, ie some#-100
            else
            {
                startPos = Int32.Parse(Char.ToString(diceRolls[0]) + Char.ToString(diceRolls[1])) - 1;
                endPos = Int32.Parse(Char.ToString(diceRolls[3]) + Char.ToString(diceRolls[4]) + Char.ToString(diceRolls[5])) - 1;
            }

            //Add the item to the applicable indexes of the table
            for (int i = startPos; i <= endPos; i++)
            {
                treasureTable[i,0] = copper;
                treasureTable[i, 1] = silver;
                treasureTable[i, 2] = gold;
                treasureTable[i, 3] = platinum;
            }
        }

        //Returns the loot acquired from a given CR creature
        public static int[] getLoot(int cr)
        {
            //Get the appropriate loot table
            String[,] table;
            if (cr <= 4) table = table0;
            else if (cr <= 10) table = table5;
            else if (cr <= 16) table = table11;
            else table = table17;

            int roll = Program.random.Next(100);

            //Individual Loot components
            int copper = 0;
            if ((String) table.GetValue(roll, 0) != "-")
            {
                String[] splitArray = ((String)table.GetValue(roll, 0)).Split('d');
                int numberOfDice = Int32.Parse(splitArray[0]);
                copper = Roll.d6(0, numberOfDice);
            }

            int silver = 0;
            if ((String)table.GetValue(roll, 1) != "-")
            {
                String[] splitArray = ((String)table.GetValue(roll, 1)).Split('d');
                int numberOfDice = Int32.Parse(splitArray[0]);
                silver = Roll.d6(0, numberOfDice);
            }
            int gold = 0;
            if ((String)table.GetValue(roll, 2) != "-")
            {
                String[] splitArray = ((String)table.GetValue(roll, 2)).Split('d');
                int numberOfDice = Int32.Parse(splitArray[0]);
                gold = Roll.d6(0, numberOfDice);
            }
            int platinum = 0;
            if ((String)table.GetValue(roll, 3) != "-")
            {
                String[] splitArray = ((String)table.GetValue(roll, 3)).Split('d');
                int numberOfDice = Int32.Parse(splitArray[0]);
                platinum = Roll.d6(0, numberOfDice);
            }
            int[] treasure = {copper, silver, gold, platinum};

            return treasure;
        }
    }
}
