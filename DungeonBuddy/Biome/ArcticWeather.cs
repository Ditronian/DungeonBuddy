using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.Mechanics;

namespace DungeonBuddy.Biome
{
    [Serializable]
    class ArcticWeather : Weather
    {
        public ArcticWeather()
        {
            this.type = getWeatherType();
            this.effect = getWeatherEffect();
        }

        //Gets the current weather's type
        override public String getWeatherType()
        {
            int roll = Roll.d20();
            string weatherType;

            if (roll >= 1 && roll <= 3) weatherType = "None";
            else if (roll >= 4 && roll <= 12) weatherType = "Windy";
            else if (roll >= 13 && roll <= 17) weatherType = "Snowfall";
            else if (roll >= 18 && roll <= 20) weatherType = "Blizzard";
            else weatherType = "Error w/ Dice Roll";

            return weatherType;
        }

        //Gets the current weather's effect
        override public String getWeatherEffect()
        {
            
            if (type == "Windy") effect = "Disadvantage on ranged weapon attack rolls, and Perception checks to hear.";
            else if (type == "Snowfall") effect = "Disadvantage on Perception checks to see.";
            else if (type == "Blizzard")
            {
                duration = Roll.d4();
                effect = "Every hour not spent in warm shelter results in a DC 14 Con saving throw or gain 1 point of exhaustion.";
            }
            else effect = "No negative effects.";
            return effect;
        }
    }
}
