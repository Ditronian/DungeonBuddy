using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Biome
{
    [Serializable]
    class PlainsBiome : Biome
    {
        public PlainsBiome()
        {
            this.movementPenalty = 1;
            generateWeather();
        }
        override public void generateWeather()
        {
            weather = new ArcticWeather();
        }
    }
}
