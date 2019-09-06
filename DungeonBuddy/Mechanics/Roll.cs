using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Mechanics
{
    class Roll
    {
        /**************************************************************************************************************************************************************************
         * Class Description: Felt like dice rolling should have its own class (as opposed to merging into Mechanics).  If I ever need to roll dice, this is where I should do it.
         * Can also do stuff like translate integers into the String dice equivalent for printing.  A lot of overloading is included so it can handle dice with modifiers, and rolling
         * multiple dice at the same time.
         * ************************************************************************************************************************************************************************
         */

        //Translates an integer value into the String equivalent for a given sided dice.
        public static String getDice(int num)   //Pass by Value
        {
            String str = "";
            switch (num)
            {
                case 4: str = "d4"; break;
                case 6: str = "d6"; break;
                case 8: str = "d8"; break;
                case 10: str = "d10"; break;
                case 12: str = "d12"; break;
                case 20: str = "d20"; break;
            }
            return str;
        }

        // Roll 20 sided dice method/overloaded methods
        public static int d20()
        {
            return Program.random.Next(20) + 1;
        }

        public static int d20(int modifier) //Pass by Value
        {
            return Program.random.Next(20) + 1 + modifier;
        }

        public static int d20(int modifier, int diceNumber) //Pass by Value
        {
            int total = 0;
            for (int i = 0; i < diceNumber; i++)
            {
                total += Program.random.Next(20) + 1 ;
            }
            return total + modifier;
        }

        // Roll 12 sided dice method/overloaded methods
        public static int d12()
        {
            return Program.random.Next(12) + 1;
        }

        public static int d12(int modifier) //Pass by Value
        {
            return Program.random.Next(12) + 1 + modifier;
        }

        public static int d12(int modifier, int diceNumber)     //Pass by Value
        {
            int total = 0;
            for (int i = 0; i < diceNumber; i++)
            {
                total += Program.random.Next(12) + 1 ;
            }
            return total + modifier;
        }

        // Roll 10 sided dice method/overloaded methods
        public static int d10()
        {
            return Program.random.Next(10) + 1;
        }

        public static int d10(int modifier)     //Pass by Value
        {
            return Program.random.Next(10) + 1 + modifier;
        }

        public static int d10(int modifier, int diceNumber)     //Pass by Value
        {
            int total = 0;
            for (int i = 0; i < diceNumber; i++)
            {
                total += Program.random.Next(10) + 1;
            }
            return total + modifier;
        }

        // Roll 8 sided dice method/overloaded methods
        public static int d8()
        {
            return Program.random.Next(8) + 1;
        }

        public static int d8(int modifier)      //Pass by Value
        {
            return Program.random.Next(8) + 1 + modifier;
        }

        public static int d8(int modifier, int diceNumber)      //Pass by Value
        {
            int total = 0;
            for (int i = 0; i < diceNumber; i++)
            {
                total += Program.random.Next(8) + 1;
            }
            return total + modifier;
        }

        // Roll 6 sided dice method/overloaded methods
        public static int d6()
        {
            return Program.random.Next(6) + 1;
        }

        public static int d6(int modifier)      //Pass by Value
        {
            return Program.random.Next(6) + 1 + modifier;
        }

        public static int d6(int modifier, int diceNumber)      //Pass by Value
        {
            int total = 0;
            for (int i = 0; i < diceNumber; i++)
            {
                total += Program.random.Next(6) + 1 ;
            }
            return total + modifier;
        }

        // Roll 4 sided dice method/overloaded methods
        public static int d4()
        {
            return Program.random.Next(4) + 1;
        }

        public static int d4(int modifier)      //Pass by Value
        {
            return Program.random.Next(4) + 1 + modifier;
        }

        public static int d4(int modifier, int diceNumber)      //Pass by Value
        {
            int total = 0;
            for (int i = 0; i < diceNumber; i++)
            {
                total += Program.random.Next(4) + 1 ;
            }
            return total + modifier;
        }


    }
}
